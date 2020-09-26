using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StringSearch_Project
{
    public static class SearchHelper
    {
        public static char[] wordseperators = { ' ', '\r', '\n', '\t', '?', ',', ';', '.', '"', '\'', ':', '\\', '/', '–', '-', '_', ')', '(', '&', '@', '!', '+', '*', '}', '{', '[', ']', '<', '=', '>', '|', '^', '%', '#', '$', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public static List<string> StopList = null;


        private static List<string> GetList(string TableName, string ColumnName)
        {
            List<string> lst = new List<string>();
            SqlConnection cn = new SqlConnection(DB.constr);
            SqlCommand com = new SqlCommand("select * from [" + TableName + "]", cn);
            cn.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
                lst.Add(r[ColumnName].ToString());
            cn.Close();
            return lst;
        }

        internal static void Init()
        {
            if (SearchHelper.StopList == null)
                StopList = GetList("Stop_Words", "Word");
        }
    }
}
