using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Configuration;
using System.IO;

namespace PonydayManager.Entities
{
    public class Entity
    {
        public const int NEW_ID = -1;

        public int Id { get; protected set; }

        public Entity()
        {
            Id = NEW_ID;
        }

        protected void ReadBackId(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT last_insert_rowid();";
                object newId = cmd.ExecuteScalar();
                this.Id = Convert.ToInt32(newId);
            }
        }

        protected static SQLiteConnection OpenConnection()
        {
            string dbPath = ConfigurationManager.AppSettings["DatabaseFile"];

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath);
            con.Open();

            return con;
        }

        protected static string CreateLogString(SQLiteCommand cmd)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Execute SQL: ").AppendLine(cmd.CommandText);

            for (int i = 0; i < cmd.Parameters.Count; i++)
            {
                sb.Append("\tParam ").Append(i).Append(": ").Append(cmd.Parameters[i].Value).AppendLine();
            }

            return sb.ToString();
        }
    }
}
