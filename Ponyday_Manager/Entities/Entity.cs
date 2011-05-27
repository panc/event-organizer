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
        protected static SQLiteConnection OpenConnection()
        {
            string dbPath = ConfigurationManager.AppSettings["DatabaseFile"];

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            SQLiteConnection con = new SQLiteConnection("Data Source=" + dbPath);
            con.Open();

            return con;
        }
    }
}
