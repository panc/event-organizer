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

        private EntityBindingList<PonyCompetition> _competitions;

        public int? StarterId { get; set; }
        public string Name { get; set; }

        public EntityBindingList<PonyCompetition> Competitions
        {
            get
            {
                if (_competitions == null)
                    _competitions = PonyCompetition.Select(this.Id);

                return _competitions;
            }
        }

        public static EntityBindingList<Pony> Select(int starterId)
        {
            EntityBindingList<Pony> result = new EntityBindingList<Pony>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "SELECT Id, StarterId, Name FROM EO_Pony WHERE StarterId = ?;";
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
                                Name = rdr.GetNullableString(2)
                            });
                        }
                    }
                }
            }

            return result;
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
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "UPDATE EO_Pony SET StarterId = ?, Name = ? WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.StarterId },
                    new SQLiteParameter{ Value = this.Name },
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Update effects more than one record!");
            }

            SavePonyCompetitions(connection);
        }

        private void Insert(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "INSERT INTO EO_Pony (StarterId, Name) VALUES(?, ?);";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.StarterId },
                    new SQLiteParameter{ Value = this.Name }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Insert effects more than one record!");
            }

            ReadBackId(connection);
            SavePonyCompetitions(connection);
        }

        private void Delete(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "DELETE FROM EO_Pony WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Delete effects more than one record!");
            }

            foreach (var item in _competitions)
            {
                item.SetDeleted();
                item.Save(connection);
            }
        }

        private void SavePonyCompetitions(SQLiteConnection connection)
        {
            if (_competitions != null)
            {
                foreach (var item in _competitions)
                {
                    item.PonyId = this.Id;
                    item.Save(connection);
                }
            }
        }
    }
}