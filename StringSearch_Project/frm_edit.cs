using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringSearch_Project
{
    public partial class frm_edit : Form
    {
        public string id="";
        public frm_edit()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow myrow = dataGridView1.CurrentRow;

            string name = paper_name_txtBox.Text;
            string notes = paper_notes_txtBox.Text;
            DB.Delete_Id("Delete_Teacher", id);
            DB.Delete_Id("Delete_Student", id);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                Student.Add_Student2(dataGridView1.Rows[i].Cells[0].Value.ToString(), id);
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                Teacher.Add_Teacher2(dataGridView2.Rows[i].Cells[0].Value.ToString(), id);
                Book.Update_Book(name, notes, id);
           
            Close();
        }

        private void txtPathName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_edit_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
