using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop.Word;
namespace StringSearch_Project
{
        
    static class Book
    {
        static public void Add_Book(string name, byte[] file_content, string notes, byte[] metadata, string filetxt, byte[] logfile, string codedfile, DateTime date)
        {
            SqlParameter[] myarr = new SqlParameter[8];
            myarr[0] = new SqlParameter("@vname", name);
            myarr[1] = new SqlParameter("@vfile_content", file_content);
            myarr[2] = new SqlParameter("@vnotes", notes);
            myarr[3] = new SqlParameter("@vmetadata", metadata);
            myarr[4] = new SqlParameter("@vfiletxt", filetxt);
            myarr[5] = new SqlParameter("@vlogfile", logfile);
            myarr[6] = new SqlParameter("@vcodedfile", codedfile);
            myarr[7] = new SqlParameter("@vdate", date);
            DB.Insert_update("InsertBook", myarr);
        }

        static public string Read_FileContent(string path)
        { 
            string res;
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            object file = path;
            object nullobj = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(
                ref file, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj);
            doc.ActiveWindow.Selection.WholeStory();
            doc.ActiveWindow.Selection.Copy();
            IDataObject data = Clipboard.GetDataObject();
            res= data.GetData(DataFormats.Text).ToString();
            
           ((_Document) doc).Close(ref nullobj, ref nullobj, ref nullobj);
           ((_Application)wordApp).Quit(ref nullobj, ref nullobj, ref nullobj);
            return res;
        }  

        public static SqlDataReader GetThesis(string spname, int srange,int erange)
        {
            SqlConnection cn = new SqlConnection(DB.constr);
            SqlCommand com = new SqlCommand(spname, cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@srow", srange);
            com.Parameters.AddWithValue("@erow", erange);
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlDataReader ScanningFiles = com.ExecuteReader();
            
            return ScanningFiles;

        }

        public static SqlDataReader GetAll(string spname)
        {
            SqlConnection cn = new SqlConnection(DB.constr);
            SqlCommand com = new SqlCommand(spname, cn);
            com.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
             SqlDataReader Res = com.ExecuteReader();


            return Res;
        }

        public static int GetCount(string spname)
        {
            SqlConnection cn = new SqlConnection(DB.constr);
            SqlCommand com = new SqlCommand(spname, cn);
            com.CommandType = CommandType.StoredProcedure;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            int count = (int)com.ExecuteScalar();
            cn.Close();
            return count;
        }

        static public void Update_Book(string name, string notes,string id)
        {
            SqlParameter[] myarr = new SqlParameter[3];
            myarr[0] = new SqlParameter("@vname", name);
            myarr[1] = new SqlParameter("@vnotes", notes);
            myarr[2] = new SqlParameter("@book_id", id);
            DB.Insert_update("UpdateBook", myarr);
        }
    }
}

	