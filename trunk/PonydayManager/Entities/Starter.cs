using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using log4net;
using System.ComponentModel;

namespace PonydayManager.Entities
{
    public class Starter : Entity
    {
        private static ILog _log = LogManager.GetLogger(typeof(Starter));

        private IEntityList<Pony> _ponys;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Club { get; set; }
        public string Comment { get; set; }
        public decimal? Costs { get; set; }
        public bool Paied { get; set; }

        public IEntityList<Pony> Ponys
        {
            get
            {
                if (_ponys == null)
                    _ponys = Pony.Select(this.Id);

                return _ponys;
            }
        }

        public static IEntityList<Starter> Select()
        {
            IEntityList<Starter> result = new EntityList<Starter>();

            using (SQLiteConnection connection = OpenConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    StringBuilder sb = new StringBuilder()
                        .Append("SELECT Id, FirstName, LastName, Birthdate, Club, Comment, Costs, Paied ")
                        .Append("FROM EO_Starter ")
                        .Append("ORDER BY LastName, FirstName;");

                    cmd.CommandText = sb.ToString();

                    _log.Debug(CreateLogString(cmd));

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
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
                                Costs = rdr.GetNullableDecimal(6),
                                Paied = rdr.GetBoolean(7)
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
                if (this.Id == NEW_ID && this.IsDeleted)
                    return;

                if (this.Id == Starter.NEW_ID)
                    Insert(connection);
                else if (this.IsDeleted)
                    Delete(connection);
                else
                    Update(connection);
            }
        }

        private void Delete(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "DELETE FROM EO_Starter WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Delete effects more than one record!");
            }

            foreach (var item in Ponys)
            {
                item.SetDeleted();
                item.Save(connection);
            }
        }

        private void Update(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "UPDATE EO_Starter SET FirstName = ?, LastName = ?, Birthdate = ?, Club = ?, Comment = ?, Costs = ?, Paied = ? WHERE Id = ?;";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.Costs },
                    new SQLiteParameter{ Value = this.Paied },
                    new SQLiteParameter{ Value = this.Id }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Update effects more than one record!");
            }

            SavePonys(connection);
        }

        private void Insert(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = "INSERT INTO EO_Starter (FirstName, LastName, Birthdate, Club, Comment, Costs, Paied) VALUES(?, ?, ?, ?, ?, ?, ?);";
                cmd.Parameters.AddRange(new SQLiteParameter[]
                {
                    new SQLiteParameter{ Value = this.FirstName },
                    new SQLiteParameter{ Value = this.LastName },
                    new SQLiteParameter{ Value = this.Birthdate },
                    new SQLiteParameter{ Value = this.Club },
                    new SQLiteParameter{ Value = this.Comment },
                    new SQLiteParameter{ Value = this.Costs },
                    new SQLiteParameter{ Value = this.Paied }
                });

                _log.Debug(CreateLogString(cmd));

                if (cmd.ExecuteNonQuery() != 1)
                    throw new Exception("Insert effects more than one record!");

                ReadBackId(connection);

                SavePonys(connection);
                //InsertResults(connection);
            }
        }

        private void SavePonys(SQLiteConnection connection)
        {
            if (_ponys != null)
            {
                foreach (var item in _ponys)
                {
                    item.StarterId = this.Id;
                    item.Save(connection);
                }

                foreach (var item in _ponys.RemovedEntities)
                {
                    item.Save(connection);
                }
            }
        }
    }
}
