using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace StringSearch_Project
{
    public partial class frm_add : Form
    {
        byte[] file;

        public frm_add()
        {
            InitializeComponent();
        }

        void Clear_All()
        {
            txtPaperName.Clear();
            listStudents.Items.Clear();
            listTeachers.Items.Clear();
            paper_notes_txtBox.Clear();
            txtPathName.Clear();
            txtFileContent.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear_All();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear_All();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " Documents|*.doc;*.docx;*.txt";
            ofd.ShowDialog();
            txtPathName.Text = ofd.FileName;

            try
            {
                FileStream stream = new FileStream(txtPathName.Text, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream, Encoding.UTF8);

                file = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();
                txtFileContent.Text = Book.Read_FileContent(ofd.FileName);
                string name = ofd.SafeFileName.ToLower();
                txtPaperName.Text = ofd.SafeFileName.Substring(0, name.IndexOf(".doc"));
            }
            catch { MessageBox.Show("لم تنجح اضافة الملف , الرجاء اغلاقه في حال كان مفتوحا"); }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            frm_settings fs = new frm_settings();
            if (txtPathName.Text == "" || txtPaperName.Text == "")
            {
                MessageBox.Show("الرجاء أدخل معلومات الأطروحة كاملة");
                return;
            }
            if (listStudents.Items.Count == 0)
            {
                MessageBox.Show("يجب إضافة طلاب أو مؤلفين", "انتبه", MessageBoxButtons.OK);
                return;
            }
            if (listTeachers.Items.Count == 0)
            {
                if (MessageBox.Show("هل أنت متأكد أنك لاتريد إضافة مشرفين", "انتبه", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            Log l = new Log();
            string CodedFile = l.CleanString(txtFileContent.Text);
            MetaData meta = new MetaData((int)fs.numericUpDown1.Value);
            meta.GetMeta(txtFileContent.Text);
            byte[] Meta = meta.Serialize();
            byte[] LogFile = l.Serialize();
            
            Book.Add_Book(txtPaperName.Text, file, paper_notes_txtBox.Text, Meta, txtFileContent.Text, LogFile, CodedFile, dateTimePicker1.Value);

            for (int i = 0; i < listStudents.Items.Count; i++)
            {
                Student.Add_Student(listStudents.Items[i].ToString());
            }

            for (int i = 0; i < listTeachers.Items.Count; i++)
            {
                Teacher.Add_Teacher(listTeachers.Items[i].ToString());
            }


            dataGridView1.DataSource = DB.Show("GetAllBooks");
            Clear_All();

            MessageBox.Show("تمت الإضافة بنجاح");

         
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Show("GetAllBooks");
            dataGridView1.Columns[0].HeaderText = "رقم الأطروحة";
            dataGridView1.Columns[1].HeaderText = "عنوان الأطروحة";
            dataGridView1.Columns[2].HeaderText = "ملاحظـــــــــات";
        }

        private void txtStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listStudents.Items.Add(txtStudents.Text);
                txtStudents.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Clear_All();
            Close();
        }

        private void txtTeachers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listTeachers.Items.Add(txtTeachers.Text);
                txtTeachers.Clear();
            }
        }

    }
}
