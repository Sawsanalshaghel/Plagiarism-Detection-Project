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
    public partial class frm_show_all : Form
    {
        public frm_show_all()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frm_add myform = new frm_add();
            myform.MdiParent = this.MdiParent;
            myform.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {  DataGridViewRow myrow = dataGridView1.CurrentRow;
            if (myrow != null)
            { 

            if (MessageBox.Show("هل أنت متأكد من جذف الأطروحة, سيتم حذف كافة المعلومات الخاصة بها", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               
                string id = myrow.Cells["Book_id"].Value.ToString();
                DB.Delete_Id("Delete_Teacher", id);
                DB.Delete_Id("Delete_Student", id);
                DB.Delete_Id("Delete_Book", id);
                dataGridView1.DataSource = DB.Show("GetAllBooks");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Teachers"].Value = DB.GetTeachers(dataGridView1.Rows[i].Cells["book_id"].Value.ToString());
                    dataGridView1.Rows[i].Cells["Students"].Value = DB.GetStudents(dataGridView1.Rows[i].Cells["book_id"].Value.ToString());
                }
            }
            }
            else
                MessageBox.Show("لاتوجد معلومات لحذفها");

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            frm_edit myfrm_edit = new frm_edit();
            DataGridViewRow myrow = dataGridView1.CurrentRow;
            if (myrow != null)
            { 
                string id = myrow.Cells["Book_id"].Value.ToString();
                myfrm_edit.paper_name_txtBox.Text = myrow.Cells["Book_name"].Value.ToString();
                myfrm_edit.paper_notes_txtBox.Text = myrow.Cells["notes"].Value.ToString();
                myfrm_edit.dataGridView1.DataSource = DB.Show_Parameter("SearchStudent", id);
                myfrm_edit.dataGridView2.DataSource = DB.Show_Parameter("SearchTeacher", id);
                myfrm_edit.id = id;
                myfrm_edit.dataGridView2.Columns[0].HeaderText = "المشرفين";
                myfrm_edit.dataGridView1.Columns[0].HeaderText= "الطلاب";
                myfrm_edit.ShowDialog();
                this.OnShown(e);
            }
            else
            MessageBox.Show("لاتوجد معلومات لتعديلها");

        }

        private void frm_show_all_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Show("GetAllBooks");
            dataGridView1.Columns[0].HeaderText = "رقم الأطروحة";
            dataGridView1.Columns[1].HeaderText = "عنوان الأطروحة";
            dataGridView1.Columns[2].HeaderText = "ملاحظـــــــــات";
            dataGridView1.Columns.Add("Teachers", "المشرفين");
            dataGridView1.Columns.Add("Students", "الطلاب");
        }

        private void frm_show_all_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Teachers"].Value = DB.GetTeachers(dataGridView1.Rows[i].Cells["book_id"].Value.ToString());
                dataGridView1.Rows[i].Cells["Students"].Value = DB.GetStudents(dataGridView1.Rows[i].Cells["book_id"].Value.ToString());
            }
        }
    }
}
