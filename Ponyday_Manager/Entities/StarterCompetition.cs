using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class StarterCompetition : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(StarterCompetition));

        private Competition _competition;

        public StarterCompetition()
        {
            Id = NEW_ID;
        }

        public int Id { get; set; }
        public int StarterId { get; set; }
        public int CompetitionId { get; set; }
        public bool IsChecked { get; set; }

        public Competition CompetitionEntity
        {
            get
            {
                if (_competition == null)
                    _competition = Competition.SelectById(this.CompetitionId);

                return _competition;
            }
        }

        public override string ToString()
        {
            return CompetitionEntity.Caption;
        }

        public static IList<StarterCompetition> Select(int? starterId = null)
        {
            List<StarterCompetition> result = new List<StarterCompetition>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, StarterId, CompetitionId FROM EO_StarterCompetition";

                    if (starterId.HasValue)
                    {
                        cmd.CommandText += " WHERE StarterId = ?";
                        cmd.Parameters.Add(new SQLiteParameter { Value = starterId.Value });
                    }

                    _log.Debug(CreateLogString(cmd));
                    
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new StarterCompetition
                            {
                                Id = rdr.GetInt32(0),
                                StarterId = rdr.GetInt32(1),
                                CompetitionId = rdr.GetInt32(2),
                                IsChecked = true
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
                    if (this.IsChecked && this.Id == Entity.NEW_ID)
                        Insert(cmd);
                    else if (!this.IsChecked && this.Id != Entity.NEW_ID)
                        Delete(cmd);
                }
            }
        }

        private void Delete(SQLiteCommand cmd)
        {
            cmd.CommandText = "DELETE FROM EO_StarterCompetition WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));
            
            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Update effects more than one record!");
        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO EO_StarterCompetition (StarterId, CompetitionId) VALUES(?, ?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.StarterId },
                    new SQLiteParameter{ Value = this.CompetitionId }
                });

            _log.Debug(CreateLogString(cmd));
            
            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");
        }
    }
}
