using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class Competition : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(Competition));

        public string Caption { get; set; }

        public static IList<Competition> Select()
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                return Select(connection);
            }
        }

        public static IEntityList<Competition> Select(SQLiteConnection connection)
        {
            IEntityList<Competition> result = new EntityList<Competition>();

            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "SELECT Id, Caption FROM EO_Competition;";

                _log.Debug(CreateLogString(cmd));

                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        result.Add(new Competition
                        {
                            Id = rdr.GetInt32(0),
                            Caption = rdr.GetNullableString(1)
                        });
                    }
                }
            }

            return result;
        }

        public void Save()
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    if (this.Id == NEW_ID && this.IsDeleted)
                        return;

                    if (this.Id == NEW_ID)
                        Insert(cmd);
                    else if (this.IsDeleted)
                        Delete(cmd);
                    else
                        Update(cmd);
                }
            }
        }

        private void Delete(SQLiteCommand cmd)
        {
            cmd.CommandText = "DELETE FROM EO_Competition WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Delete effects more than one record!");
        }

        private void Update(SQLiteCommand cmd)
        {
            cmd.CommandText = "UPDATE EO_Competition SET Caption = ? WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Caption },
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Update effects more than one record!");
        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO EO_Competition (Caption) VALUES(?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Caption }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");

            ReadBackId(cmd.Connection);
        }
    }
}
