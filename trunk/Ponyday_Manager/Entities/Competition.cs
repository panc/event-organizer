using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace PonydayManager.Entities
{
    public class Competition : Entity
    {
        public Competition()
        {
            Id = NEW_ID;
        }

        public int Id { get; set; }
        public string Caption { get; set; }

        public static IList<Competition> Select(string filter)
        {
            List<Competition> result = new List<Competition>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, Caption FROM Competition;";

                    _log.Debug(CreateLogString(cmd));
                    
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new Competition
                            {
                                Id = rdr.GetInt32(0),
                                Caption = rdr.GetString(1)
                            });
                        }
                    }
                }
            }

            return result;
        }

        public static Competition SelectById(int id)
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, Caption FROM Competition WHERE Id = ?;";
                    cmd.Parameters.Add(new SQLiteParameter { Value = id });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            return new Competition
                                {
                                    Id = rdr.GetInt32(0),
                                    Caption = rdr.GetString(1)
                                };
                        }
                    }
                }
            }

            return null;
        }

        public void Save()
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    if (this.Id == Starter.NEW_ID)
                        Insert(cmd);
                    else
                        Update(cmd);
                }
            }
        }

        private void Update(SQLiteCommand cmd)
        {
            cmd.CommandText = "UPDATE Competition SET Caption = ? WHERE Id = ?;";
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
            cmd.CommandText = "INSERT INTO Starter (Caption) VALUES(?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Caption }
                });

            _log.Debug(CreateLogString(cmd));
            
            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");
        }
    }
}
