using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class StarterResult : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(StarterResult));

        public StarterResult()
        {
            Id = NEW_ID;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Pony { get; set; }
        
        public static IList<StarterResult> SelectForCompetition(int competitionId)
        {
            List<StarterResult> result = new List<StarterResult>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    StringBuilder sb = new StringBuilder()
                    .Append("SELECT ")
                        .Append("s.Id, FirstName, LastName, Birthdate, PonyOne as Pony ")
                        .Append("FROM Starter AS s ")
                        .Append("INNER JOIN StarterCompetition AS sc ON s.Id = sc.StarterId AND CompetitionId = ? ")
                        .Append("WHERE s.PonyOne is not null and length(s.PonyOne) > 0 ")
                    .Append(" UNION SELECT ")
                        .Append("s.Id, FirstName, LastName, Birthdate, PonyTwo as Pony ")
                        .Append("FROM Starter AS s ")
                        .Append("INNER JOIN StarterCompetition AS sc ON s.Id = sc.StarterId AND CompetitionId = ? ")
                        .Append("WHERE s.PonyTwo is not null and length(s.PonyTwo) > 0 ")
                    .Append(" UNION SELECT ")
                        .Append("s.Id, FirstName, LastName, Birthdate, PonyThree as Pony ")
                        .Append("FROM Starter AS s ")
                        .Append("INNER JOIN StarterCompetition AS sc ON s.Id = sc.StarterId AND CompetitionId = ? ")
                        .Append("WHERE s.PonyThree is not null and length(s.PonyThree) > 0 ");


                    cmd.CommandText = sb.ToString();

                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });
                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });
                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new StarterResult
                            {
                                Id = rdr.GetInt32(0),
                                FirstName = rdr.GetNullableString(1),
                                LastName = rdr.GetNullableString(2),
                                Birthdate = rdr.GetNullableDateTime(3),
                                Pony = rdr.GetNullableString(4)
                            });
                        }

                    }
                }
            }

            return result;
        }

        //public void Save()
        //{
        //    using (SQLiteConnection connection = OpenConnection())
        //    {
        //        using (SQLiteCommand cmd = new SQLiteCommand(connection))
        //        {
        //            if (this.Id == Starter.NEW_ID)
        //                Insert(cmd);
        //            else
        //                Update(cmd);
        //        }
        //    }
        //}

        //private void Update(SQLiteCommand cmd)
        //{
        //    cmd.CommandText = "UPDATE Starter SET FirstName = ?, LastName = ?, Birthdate = ?, Club = ?, Comment = ?, PonyOne = ?, PonyTwo = ?, PonyThree = ?, Costs = ?, Paied = ? WHERE Id = ?;";
        //    cmd.Parameters.AddRange(new SQLiteParameter[]
        //        {
        //            new SQLiteParameter{ Value = this.FirstName },
        //            new SQLiteParameter{ Value = this.LastName },
        //            new SQLiteParameter{ Value = this.Birthdate },
        //            new SQLiteParameter{ Value = this.Club },
        //            new SQLiteParameter{ Value = this.Comment },
        //            new SQLiteParameter{ Value = this.PonyOne },
        //            new SQLiteParameter{ Value = this.PonyTwo },
        //            new SQLiteParameter{ Value = this.PonyThree },
        //            new SQLiteParameter{ Value = this.Costs },
        //            new SQLiteParameter{ Value = this.Paied },
        //            new SQLiteParameter{ Value = this.Id }
        //        });

        //    _log.Debug(CreateLogString(cmd));

        //    if (cmd.ExecuteNonQuery() != 1)
        //        throw new Exception("Insert effects more than one record!");

        //}

        //private void Insert(SQLiteCommand cmd)
        //{
        //    cmd.CommandText = "INSERT INTO Starter (FirstName, LastName, Birthdate, Club, Comment, PonyOne, PonyTwo, PonyThree, Costs, Paied) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
        //    cmd.Parameters.AddRange(new SQLiteParameter[]
        //        {
        //            new SQLiteParameter{ Value = this.FirstName },
        //            new SQLiteParameter{ Value = this.LastName },
        //            new SQLiteParameter{ Value = this.Birthdate },
        //            new SQLiteParameter{ Value = this.Club },
        //            new SQLiteParameter{ Value = this.Comment },
        //            new SQLiteParameter{ Value = this.PonyOne },
        //            new SQLiteParameter{ Value = this.PonyTwo },
        //            new SQLiteParameter{ Value = this.PonyThree },
        //            new SQLiteParameter{ Value = this.Costs },
        //            new SQLiteParameter{ Value = this.Paied }
        //        });

        //    _log.Debug(CreateLogString(cmd));

        //    if (cmd.ExecuteNonQuery() != 1)
        //        throw new Exception("Insert effects more than one record!");

        //    cmd.CommandText = "SELECT last_insert_rowid();";
        //    object newId = cmd.ExecuteScalar();
        //    int id = Convert.ToInt32(newId);
                
        //    if (_competitions != null)
        //    {
        //        foreach (var item in _competitions)
        //        {
        //            item.StarterId = id;
        //            item.Save();
        //        }
        //    }
        //}
    }
}
