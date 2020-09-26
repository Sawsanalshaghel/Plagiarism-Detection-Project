using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StringSearch_Project
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void طلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add myform = new frm_add();
            myform.MdiParent = this;
            myform.Show();
        }



        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frm_show_all myform = new frm_show_all();
            //myform.Load(sender, e);
            // myform.Load += new EventHandler(frm_show_all);
            myform.dataGridView1.DataSource = DB.Show("GetAllBooks");
            myform.dataGridView1.Columns[0].HeaderText = "رقم الأطروحة";
            myform.dataGridView1.Columns[1].HeaderText = "عنوان الأطروحة";
            myform.dataGridView1.Columns[2].HeaderText = "ملاحظـــــــــات";
            myform.dataGridView1.DataSource = DB.Show("GetAllBooks");
            myform.MdiParent = this;
            myform.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frm_show_all myform = new frm_show_all();
            myform.MdiParent = this;
            myform.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_Shown(object sender, EventArgs e)
        {
            frm_show_all myform = new frm_show_all();
            myform.MdiParent = this;
            myform.Show();
        }

        

        private void frm_main_Load(object sender, EventArgs e)
        {
           
        }

        private void stroBtnCompare_Click(object sender, EventArgs e)
        {
            frm_settings myform = new frm_settings();
            myform.MdiParent = this;
            myform.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_search myform = new frm_search();
            myform.MdiParent = this;
            myform.Show();

        }
    }
}
