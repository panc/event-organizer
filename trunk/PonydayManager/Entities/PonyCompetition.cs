using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class PonyCompetition : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(PonyCompetition));

        public int PonyId { get; set; }
        public int SortIndex { get; set; }
        public int? Assessment { get; set; }
        public string Comment { get; set; }


        // to use the property in the datagridview, it musst be nullable
        // in DB the column is not nullable
        private int? _originalCompetitionId;
        private int? _competitionId;
        public int? CompetitionId
        {
            get { return _competitionId; }
            set
            {
                if (value.HasValue)
                {
                    _competitionId = value.Value;

                    if (!_originalCompetitionId.HasValue)
                        _originalCompetitionId = _competitionId;
                }
            }
        }

        public int StarterId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Pony { get; private set; }

        public static IEntityList<PonyCompetition> Select(int ponyId)
        {
            IEntityList<PonyCompetition> result = new EntityList<PonyCompetition>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    StringBuilder sb = new StringBuilder()
                        .Append("SELECT Id, PonyId, CompetitionId, SortIndex, Assessment, Comment ")
                        .Append("FROM EO_PonyCompetition ")
                        .Append("WHERE PonyId = ?");

                    cmd.CommandText = sb.ToString();
                    cmd.Parameters.Add(new SQLiteParameter { Value = ponyId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new PonyCompetition
                            {
                                Id = rdr.GetInt32(0),
                                PonyId = rdr.GetInt32(1),
                                CompetitionId = rdr.GetInt32(2),
                                SortIndex = rdr.GetInt32(3),
                                Assessment = rdr.GetNullableInt32(4),
                                Comment = rdr.GetNullableString(5)
                            });
                        }
                    }
                }
            }

            return result;
        }

        public static IEntityList<PonyCompetition> SelectForCompetition(int competitionId, bool orderByAssessment)
        {
            IEntityList<PonyCompetition> result = new EntityList<PonyCompetition>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    StringBuilder sb = new StringBuilder()
                        .Append("SELECT ")
                        .Append("pc.Id, pc.CompetitionId, pc.PonyId, pc.SortIndex, ")
                        .Append("pc.Assessment, pc.Comment, ")
                        .Append("s.FirstName, s.LastName, p.Name as Pony ")
                        .Append("FROM EO_PonyCompetition AS pc ")
                        .Append("INNER JOIN EO_Pony AS p ON p.Id = pc.PonyId ")
                        .Append("INNER JOIN EO_Starter AS s ON s.Id = p.StarterId ")
                        .Append("WHERE pc.CompetitionId = ? ");

                    if (orderByAssessment)
                        sb.Append("ORDER BY pc.Assessment DESC;");
                    else
                        sb.Append("ORDER BY pc.SortIndex;");

                    cmd.CommandText = sb.ToString();

                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(new PonyCompetition
                            {
                                Id = rdr.GetInt32(0),
                                CompetitionId = rdr.GetInt32(1),
                                PonyId = rdr.GetInt32(2),
                                SortIndex = rdr.GetInt32(3),
                                Assessment = rdr.GetNullableInt32(4),
                                Comment = rdr.GetNullableString(5),
                                FirstName = rdr.GetNullableString(6),
                                LastName = rdr.GetNullableString(7),
                                Pony = rdr.GetNullableString(8)
                            });
                        }

                    }
                }
            }

            return result;
        }

        public static int SelectInUseCount(int competitionId)
        {
            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM EO_PonyCompetition WHERE CompetitionId = ?;";
                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });

                    object result = cmd.ExecuteScalar();
                    if(result != null && result is long)
                        return (int)((long)result);

                    return 0;
                }
            }
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
            if (this.Id == Entity.NEW_ID && this.IsDeleted)
                return;

            if (this.Id == Entity.NEW_ID)
                Insert(connection);
            else if (this.IsDeleted)
                Delete(connection);
            else
                Update(connection);
        }

        private void Update(SQLiteConnection connection)
        {
            SetSortIndex(connection);

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "UPDATE EO_PonyCompetition SET PonyId = ?, CompetitionId = ?, SortIndex = ?, Assessment = ?, Comment = ? WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.PonyId },
                    new SQLiteParameter{ Value = this.CompetitionId },
                    new SQLiteParameter{ Value = this.SortIndex },
                    new SQLiteParameter{ Value = this.Assessment },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Update effects more than one record!");
            }
        }

        private void Delete(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM EO_PonyCompetition WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Delete effects more than one record!");
            }
        }

        private void Insert(SQLiteConnection connection)
        {
            SetSortIndex(connection);

            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO EO_PonyCompetition (PonyId, CompetitionId, SortIndex) VALUES(?, ?, ?);";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.PonyId },
                    new SQLiteParameter{ Value = this.CompetitionId },
                    new SQLiteParameter{ Value = this.SortIndex }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Insert effects more than one record!");

                ReadBackId(cmd.Connection);
            }
        }

        /// <summary>
        /// Selects the last sortindex from the database and sets the current sortIndex to the next value
        /// </summary>
        /// <param name="connection"></param>
        private void SetSortIndex(SQLiteConnection connection)
        {
            if (this.Id == NEW_ID || _competitionId != _originalCompetitionId)
            {
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT MAX(SortIndex) FROM EO_PonyCompetition WHERE CompetitionId = ?;";
                    cmd.Parameters.Add(new SQLiteParameter { Value = this.CompetitionId });

                    _log.Debug("Get last sortindex from database...");
                    _log.Debug(CreateLogString(cmd));

                    object result = cmd.ExecuteScalar();
                    if (result != null && result is long)
                        this.SortIndex = (int)((long)result) + 1;
                    else
                        this.SortIndex = 1;
                }
            }
        }
    }
}
