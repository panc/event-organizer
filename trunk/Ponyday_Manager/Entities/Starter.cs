using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;

namespace PonydayManager.Entities
{
    public class Starter : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(Starter));

        private IList<StarterCompetition> _competitions;

        public Starter()
        {
            Id = NEW_ID;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PonyOne { get; set; }
        public string PonyTwo { get; set; }
        public string PonyThree { get; set; }
        public string Club { get; set; }
        public string Comment { get; set; }
        public decimal? Costs { get; set; }
        public bool Paied { get; set; }

        public IList<StarterCompetition> Competitions
        {
            get
            {
                if (_competitions == null)
                    _competitions = StarterCompetition.Select(this.Id);

                return _competitions;
            }
        }

        public static IList<Starter> Select(string filter)
        {
            List<Starter> result = new List<Starter>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, FirstName, LastName, Birthdate, Club, Comment, PonyOne, PonyTwo, PonyThree, Costs, Paied FROM Starter;";

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        result = CreateStarterList(rdr);
                    }
                }
            }

            return result;
        }

        public static IList<Starter> SelectForCompetition(int competitionId)
        {
            List<Starter> result = new List<Starter>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT s.Id, FirstName, LastName, Birthdate, Club, Comment, PonyOne, PonyTwo, PonyThree, Costs, Paied FROM Starter AS s " +
                                      "INNER JOIN StarterCompetition AS sc ON s.Id = sc.StarterId AND CompetitionId = ?;";

                    cmd.Parameters.Add(new SQLiteParameter { Value = competitionId });

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        result = CreateStarterList(rdr);
                    }
                }
            }

            return result;
        }

        private static List<Starter> CreateStarterList(SQLiteDataReader rdr)
        {
            List<Starter> result = new List<Starter>();

            while (rdr.Read())
            {
                result.Add(new Starter
                {
                    Id = rdr.GetInt32(0),
                    FirstName = rdr.GetNullableString(1),
                    LastName = rdr.GetNullableString(2),
                    Birthdate = rdr.GetNullableDateTime(3),
                    Club = rdr.GetNullableString(4),
                    Comment = rdr.GetNullableString(5),
                    PonyOne = rdr.GetNullableString(6),
                    PonyTwo = rdr.GetNullableString(7),
                    PonyThree = rdr.GetNullableString(8),
                    Costs = rdr.GetNullableDecimal(9),
                    Paied = rdr.GetBoolean(10)
                });
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
            cmd.CommandText = "UPDATE Starter SET FirstName = ?, LastName = ?, Birthdate = ?, Club = ?, Comment = ?, PonyOne = ?, PonyTwo = ?, PonyThree = ?, Costs = ?, Paied = ? WHERE Id = ?;";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.PonyOne },
                    new SQLiteParameter{ Value = this.PonyTwo },
                    new SQLiteParameter{ Value = this.PonyThree },
                    new SQLiteParameter{ Value = this.Costs },
                    new SQLiteParameter{ Value = this.Paied },
                    new SQLiteParameter{ Value = this.Id }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");

            if (_competitions != null)
            {
                foreach (var item in _competitions)
                    item.Save();
            }
        }

        private void Insert(SQLiteCommand cmd)
        {
            cmd.CommandText = "INSERT INTO Starter (FirstName, LastName, Birthdate, Club, Comment, PonyOne, PonyTwo, PonyThree, Costs, Paied) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
            cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.PonyOne },
                    new SQLiteParameter{ Value = this.PonyTwo },
                    new SQLiteParameter{ Value = this.PonyThree },
                    new SQLiteParameter{ Value = this.Costs },
                    new SQLiteParameter{ Value = this.Paied }
                });

            _log.Debug(CreateLogString(cmd));

            if (cmd.ExecuteNonQuery() != 1)
                throw new Exception("Insert effects more than one record!");

            cmd.CommandText = "SELECT last_insert_rowid();";
            object newId = cmd.ExecuteScalar();
            int id = Convert.ToInt32(newId);
                
            if (_competitions != null)
            {
                foreach (var item in _competitions)
                {
                    item.StarterId = id;
                    item.Save();
                }
            }
        }
    }
}
