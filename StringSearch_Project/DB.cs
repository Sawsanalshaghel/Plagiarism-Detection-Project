using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;




namespace StringSearch_Project
{
    public static class DB
    {
        public static string constr = @"Data Source=.\sqldb;AttachDbFilename=" + Application.StartupPath + @"\StringDb.mdf;Integrated Security=True";

        static SqlConnection myconnection = new SqlConnection(constr);

        public static void Insert_update(string spname, SqlParameter[] parray)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddRange(parray);
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            mycom.ExecuteNonQuery();
            myconnection.Close();

        }
        public static void Delete_Id(string spname, string id)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddWithValue("@book_id", id);
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            mycom.ExecuteNonQuery();
            myconnection.Close();

        }

        public static void Delete(string spname)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            mycom.ExecuteNonQuery();
            myconnection.Close();
        }

        public static DataTable Show(string spname)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(mycom);
            DataTable mytaple = new DataTable();
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            myDataAdapter.Fill(mytaple);
            myconnection.Close();
            return mytaple;

        }

        public static DataTable Search_full_text(string spname, string value)
        {
            SqlCommand com = new SqlCommand(spname, myconnection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Phrase", value);
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable t = new DataTable();
            da.Fill(t);
            myconnection.Close();
            return t;
        }

        public static DataTable Show_Parameter(string spname, string id)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddWithValue("@book_id", id);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(mycom);
            DataTable mytaple = new DataTable();

            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            myDataAdapter.Fill(mytaple);
            myconnection.Close();
            return mytaple;
        }

        public static string GetTeachers(string id)
        {
            SqlCommand mycom = new SqlCommand("GetTeachers", myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddWithValue("@book_id", id);
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlDataReader r = mycom.ExecuteReader();
            string s = "";
            while (r.Read())
                s += "," + r[0].ToString();
            myconnection.Close();
            if (s != "")
                s = s.Remove(0, 1);
            return s;
        }

        public static string GetStudents(string id)
        {
            SqlCommand mycom = new SqlCommand("GetStudents", myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddWithValue("@book_id", id);
            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            SqlDataReader r = mycom.ExecuteReader();
            string s = "";
            while (r.Read())
                s += "," + r[0].ToString();
            myconnection.Close();
            if (s != "")
                s = s.Remove(0, 1);
            return s;
        }




        public static byte[] GetFileContent(string spname, string id)
        {
            SqlCommand mycom = new SqlCommand(spname, myconnection);
            mycom.CommandType = CommandType.StoredProcedure;
            mycom.Parameters.AddWithValue("@book_id", id);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(mycom);
            DataTable mytaple = new DataTable();

            if (myconnection.State == ConnectionState.Closed)
                myconnection.Open();
            myDataAdapter.Fill(mytaple);
            byte[] result = null;
            if (mytaple.Rows[0][0] != DBNull.Value)
                result = (byte[])mytaple.Rows[0][0];


            myconnection.Close();
            return result;

        }

    }
}