using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

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

        public static decimal? GetNullableDecimal(this SQLiteDataReader rdr, int index)
        {
            if (!rdr.IsDBNull(index) && rdr[index] is decimal)
                return rdr.GetDecimal(index);

            return null;
        }

        public static string GetNullableString(this SQLiteDataReader rdr, int index)
        {
            if (!rdr.IsDBNull(index))
                return rdr.GetString(index);

            return string.Empty;
        }

        public static decimal? GetTextAsDecimal(this TextBox tb)
        {
            decimal result;
            if (!string.IsNullOrEmpty(tb.Text) && decimal.TryParse(tb.Text, out result))
                return result;

            return null;
        }
    }
}
