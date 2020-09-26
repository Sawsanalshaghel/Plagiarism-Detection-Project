using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace StringSearch_Project
{
    static class Student
    {
        static public void Add_Student(string name)
        {
            SqlParameter[] myarr = new SqlParameter[1];
            myarr[0] = new SqlParameter("@vname", name);
             DB.Insert_update("InsertStudent", myarr);
        }
        static public void Add_Student2(string name,string id)
        {
            SqlParameter[] myarr = new SqlParameter[2];
            myarr[0] = new SqlParameter("@vname", name);
            myarr[1] = new SqlParameter("@vbook_id", id);
            DB.Insert_update("InsertStudent2", myarr);
        }

        static public void Update_Student(string name,string id)
        {
            SqlParameter[] myarr = new SqlParameter[2];
            myarr[0] = new SqlParameter("@vname", name);
            myarr[1] = new SqlParameter("@book_id", id);
            DB.Insert_update("Updatestudent", myarr);
        }
    }
}
