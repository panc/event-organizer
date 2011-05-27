using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace PonydayManager
{
    public static class Extensions
    {
        public static DateTime? GetNullableDateTime(this SQLiteDataReader rdr, int index)
        {
            if (!rdr.IsDBNull(index) && rdr[index] is DateTime)
                return rdr.GetDateTime(index);

            return null;
        }
    }
}
