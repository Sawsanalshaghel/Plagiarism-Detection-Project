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
namespace StringSearch_Project
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("هذه القيمة سوف تأثر فقط على الملفات المضافة بعد هذا التعديل");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " Documents|*.txt";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string txtPathName = ofd.FileName;
                string word;
                SqlConnection cn = new SqlConnection(DB.constr);
                cn.Open();
                try
                {
                    // FileStream stream = new FileStream(, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(txtPathName, Encoding.UTF8, false);
                    while (!reader.EndOfStream)
                    {
                        word = reader.ReadLine();
                        word = word.Replace("'", "''");
                        listBox1.Items.Add(word);
                        string te = "select word from  stop_words where word like '" + word + "'";
                        SqlCommand com = new SqlCommand(te, cn);
                        string t = "insert into stop_Words(word) values(" + "\'" + word + "\'" + ")";
                        SqlCommand isr = new SqlCommand(t, cn);
                        if (com.ExecuteScalar() == null)
                            isr.ExecuteNonQuery();
                    }
                    cn.Close();

                }
                       catch {MessageBox.Show("لم تنجح إضافة الملف");}
            }
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("هذه القيمة سوف تأثر فقط على الملفات المضافة بعد هذا التعديل");
        }
    }
}
