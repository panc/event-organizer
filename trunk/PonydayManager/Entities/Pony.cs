using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class Pony : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(Pony));

        public int StarterId { get; set; }
        public string Name { get; set; }
        public int SortIndex { get; set; }

        public static IList<Pony> Select(int starterId)
        {
            List<Pony> result = new List<Pony>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, StarterId, Name, SortIndex FROM EO_Pony WHERE StarterId = ?;";
                    cmd.Parameters.Add(new SQLiteParameter { Value = starterId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new Pony
                            {
                                Id = rdr.GetInt32(0),
                                StarterId = rdr.GetInt32(1),
                                Name = rdr.GetNullableString(2),
                                SortIndex = rdr.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return result;
        }

        public void Save(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                if (this.Id == Starter.NEW_ID)
                    Insert(cmd);
                else
                    Update(cmd);
            }
        }

        private void Update(SQLiteCommand cmd)
        {
            cmd.CommandText = "UPDATE EO_Pony SET StarterId = ?, Name = ?, SortIndex = ? WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.StarterId },
                    new SQLiteParameter{ Value = this.Name },
                    new SQLiteParameter{ Value = this.SortIndex },
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Update effects more than one record!");
        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO EO_Pony (StarterId, Name, SortIndex) VALUES(?, ?, ?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.StarterId },
                    new SQLiteParameter{ Value = this.Name },
                    new SQLiteParameter{ Value = this.SortIndex }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");

            ReadBackId(cmd.Connection);
        }
    }
}
