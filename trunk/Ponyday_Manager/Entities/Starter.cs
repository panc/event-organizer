using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace PonydayManager.Entities
{
    public class Starter : Entity
    {
        public const int NEW_ID = -1;

        public Starter()
        {
            Id = NEW_ID;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Club { get; set; }
        public string Comment { get; set; }

        public static IList<Starter> Select(string filter)
        {
            List<Starter> result = new List<Starter>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, FirstName, LastName, Birthdate, Club, Comment FROM Starter;";

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new Starter
                            {
                                Id = rdr.GetInt32(0),
                                FirstName = rdr.GetString(1),
                                LastName = rdr.GetString(2),
                                Birthdate = rdr.GetNullableDateTime(3),
                                Club = rdr.GetString(4),
                                Comment = rdr.GetString(5)
                            });
                        }
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
                    if (this.Id == Starter.NEW_ID)
                        Insert(cmd);
                    else
                        Update(cmd);
                }
            }
        }

        private void Update(SQLiteCommand cmd)
        {
            cmd.CommandText = "UPDATE Starter SET FirstName = ?, LastName = ?, Birthdate = ?, Club = ?, Comment = ? WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.Id }
                });

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");
        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO Starter (FirstName, LastName, Birthdate, Club, Comment) VALUES(?, ?, ?, ?, ?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment }
                });

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");
        }
    }
}
