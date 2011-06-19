using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class Result : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(Result));

        public int PonyId { get; set; }
        public int CompetitionId { get; set; }
        public int SortIndex { get; set; }
        public int? AssessmentOne { get; set; }
        public int? AssessmentTwo { get; set; }
        public int? AssessmentThree { get; set; }
        public int? AssessmentFour { get; set; }
        public int? AssessmentFive { get; set; }
        public int? AssessmentSum { get; set; }
        public string Comment { get; set; }

        public int StarterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pony { get; set; }
                
        public static IList<Result> SelectForCompetition(int competitionId)
        {
            List<Result> result = new List<Result>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    StringBuilder sb = new StringBuilder()
                        .Append("SELECT ")
                        .Append("r.Id, r.CompetitionId, r.PonyId, r.SortIndex, ")
                        .Append("r.AssessmentOne, r.AssessmentTwo, r.AssessmentThree, r.AssessmentFour, r.AssessmentFive, r.AssessmentSum, r.Comment, ")
                        .Append("s.FirstName, s.LastName, p.Name as Pony ")
                        .Append("FROM EO_Result AS r ")
                        .Append("INNER JOIN EO_Pony AS p ON p.Id = r.PonyId AND p.Name is not null and length(p.Name) > 0  ")
                        .Append("INNER JOIN EO_Starter AS s ON s.Id = p.StarterId ")
                        .Append("INNER JOIN EO_StarterCompetition AS sc ON sc.StarterId = s.Id AND sc.CompetitionId = r.CompetitionId ")
                        .Append("WHERE r.CompetitionId = ? ")
                        //.Append("ORDER BY s.LastName, s.FirstName, p.Name;");
                        .Append("ORDER BY r.SortIndex;"); 

                    cmd.CommandText = sb.ToString();

                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new Result
                            {
                                Id = rdr.GetInt32(0),
                                CompetitionId = rdr.GetInt32(1),
                                PonyId = rdr.GetInt32(2),
                                SortIndex = rdr.GetInt32(3),
                                AssessmentOne = rdr.GetNullableInt32(4),
                                AssessmentTwo = rdr.GetNullableInt32(3),
                                AssessmentThree = rdr.GetNullableInt32(6),
                                AssessmentFour = rdr.GetNullableInt32(7),
                                AssessmentFive = rdr.GetNullableInt32(8),
                                AssessmentSum = rdr.GetNullableInt32(9),
                                Comment = rdr.GetNullableString(10),
                                FirstName = rdr.GetNullableString(11),
                                LastName = rdr.GetNullableString(12),
                                Pony = rdr.GetNullableString(13)
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
                Save(connection);
            }
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
            cmd.CommandText = "UPDATE EO_Result SET PonyId = ?, CompetitionId = ?, SortIndex = ?, AssessmentOne = ?, AssessmentTwo = ?, AssessmentThree = ?, AssessmentFour = ?, AssessmentFive = ?, AssessmentSum = ?, Comment = ? WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.PonyId },
                    new SQLiteParameter{ Value = this.CompetitionId },
                    new SQLiteParameter{ Value = this.SortIndex },
                    new SQLiteParameter{ Value = this.AssessmentOne },
                    new SQLiteParameter{ Value = this.AssessmentTwo },
                    new SQLiteParameter{ Value = this.AssessmentThree },
                    new SQLiteParameter{ Value = this.AssessmentFour },
                    new SQLiteParameter{ Value = this.AssessmentFive },
                    new SQLiteParameter{ Value = this.AssessmentSum },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Update effects more than one record!");

        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO EO_Result (PonyId, CompetitionId, SortIndex, AssessmentOne, AssessmentTwo, AssessmentThree, AssessmentFour, AssessmentFive, AssessmentSum, Comment) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.PonyId },
                    new SQLiteParameter{ Value = this.CompetitionId },
                    new SQLiteParameter{ Value = this.SortIndex },
                    new SQLiteParameter{ Value = this.AssessmentOne },
                    new SQLiteParameter{ Value = this.AssessmentTwo },
                    new SQLiteParameter{ Value = this.AssessmentThree },
                    new SQLiteParameter{ Value = this.AssessmentFour },
                    new SQLiteParameter{ Value = this.AssessmentFive },
                    new SQLiteParameter{ Value = this.AssessmentSum },
                    new SQLiteParameter{ Value = this.Comment }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");

            ReadBackId(cmd.Connection);
        }
    }
}
