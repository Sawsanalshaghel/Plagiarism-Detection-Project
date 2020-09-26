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
using System.Threading;
using System.Diagnostics;

namespace StringSearch_Project
{
    public partial class frm_search : Form
    {
        Stopwatch sw;
        TimeSpan elapsedTime;
        
        public void NoThreads()
        {
                frm_settings fs = new frm_settings();
                int metawords = (int)fs.numericUpDown1.Value;
                int count = Book.GetCount("GetCountBooks");
                PreProcess LogResults = new PreProcess(ComparingTxt, Convert.ToInt32(numGram.Value),metawords);
                LogResults.ScanFilesReader = Book.GetThesis("GetRangeBook", 1, count);
                LogResults.SearchSimilarity();

        }



        string ComparingTxt = "";
        string Message = "";

        public frm_search()
        {
            InitializeComponent();
        }


        public void ShowResult()
        {
            if (PreProcess.FinalFiles.Count == 0)
            {


                sw.Stop();
                elapsedTime = sw.Elapsed;
                lblProgress.Text = "الوقت المستغرق بالثواني" + elapsedTime.TotalSeconds.ToString();
                lstResults.Items.Add("لاتوجد ملفات متشابهة");
                return;
            }
            for (int i = 0; i < PreProcess.FinalFiles.Count; i++)
                for (int j = 0; j < PreProcess.FinalFiles.Count - 1; j++)
                    if (PreProcess.FinalFiles[j].sl < PreProcess.FinalFiles[j + 1].sl)
                    {
                        file_con temp = PreProcess.FinalFiles[j + 1];
                        PreProcess.FinalFiles[j + 1] = PreProcess.FinalFiles[j];
                        PreProcess.FinalFiles[j] = temp;
                    }
            for (int i = 0; i < PreProcess.FinalFiles.Count; i++)
            {
                string s = "";
                SqlConnection myconnection = new SqlConnection(DB.constr);
                SqlCommand mycom = new SqlCommand("SearchStudent", myconnection);
                myconnection.Open();
                mycom.CommandType = CommandType.StoredProcedure;
                mycom.Parameters.AddWithValue("@book_id", PreProcess.FinalFiles[i].id);

                SqlDataReader students;

                students = mycom.ExecuteReader();



                while (students.Read())
                    s +=" " +students["student_name"].ToString();

                myconnection.Close();
                lstResults.Items.Add(" عنوان الأطروحة " + PreProcess.FinalFiles[i].name);
                lstResults.Items.Add("  للمؤلفين  " + "/" + s + "/" + "  تاريخ الإضافة " + "-" + "14/5/2012" + "-" + "\t بنسبة تشابه \t" + PreProcess.FinalFiles[i].sl + "%");
            }

            sw.Stop();
            elapsedTime = sw.Elapsed;
            lblProgress.Text = "الوقت المستغرق بالثواني" + elapsedTime.TotalSeconds.ToString();
           /* for (int i = 0; i < PreProcess.ResFile.sim; i++)
            {
                for (int j = i+1; j < PreProcess.ResFile.sim - 1; j++)
                    if (PreProcess.ResFile.dim[j, 0] >= PreProcess.ResFile.dim[i, 0] && (PreProcess.ResFile.dim[j, 1] + PreProcess.ResFile.dim[j, 0]) <= (PreProcess.ResFile.dim[i, 0] + PreProcess.ResFile.dim[i, 1]))
                            PreProcess.ResFile.dim[j, 1] = -1;
                    else
                        if (PreProcess.ResFile.dim[i, 0] >= PreProcess.ResFile.dim[j, 0] && PreProcess.ResFile.dim[i, 1] <= PreProcess.ResFile.dim[j, 1])
                            PreProcess.ResFile.dim[i, 1] = -1;
                        

            }
            int all=0;
            for (int i = 0; i < PreProcess.ResFile.sim; i++)
            {
                if   (PreProcess.ResFile.dim[i, 1]!=-1)
                     all +=PreProcess.ResFile.dim[i, 1];
            }
            lstResults.Items.Add("نسبة المتشابه في الملف المدخل" + all * 100 / PreProcess.c_text.Length + "%" + "من الملف");*/
        }
        
        public void ThredingFiles()
        {
            Thread[] threads;
            PreProcess[] LogResults;
            int rate = 0;
            frm_settings fs = new frm_settings();
            int metawords = (int)fs.numericUpDown1.Value;
            int count = Book.GetCount("GetCountBooks");
            double r = count * 0.5;// thread count
            if (r > 0 && r < 1)
                r = 1;
            rate = (int)r;
            int start = 1;
            int end = count / rate;;
            threads = new Thread[rate];
            LogResults = new PreProcess[rate];
            for (int i = 0; i < threads.Length; ++i)
            {
                LogResults[i] = new PreProcess(ComparingTxt, Convert.ToInt32(numGram.Value),metawords);
                LogResults[i].ScanFilesReader = Book.GetThesis("GetRangeBook", start, end);
                threads[i] = new Thread(new ThreadStart(LogResults[i].SearchSimilarity));
                if (!threads[i].IsAlive)
                {
                    threads[i].Start();

                }
                start += count / rate;
                if (count % 2 == 1 && i == threads.Length - 2)
                   end += count / rate + 1;
                else
                    end += count / rate;
            }
            for (int i = 0; i < threads.Length; i++)
                threads[i].Join();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Documents|*.doc;*.docx;*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            lblProgress.Text = "جاري قراءة الملف";
          //  Application.DoEvents();

            lstResults.Items.Clear();
            txtDecoded.Clear();
            if (PreProcess.FinalFiles != null)
                PreProcess.FinalFiles.Clear();
            PreProcess.fm = null;
            PreProcess.c_text = "";
            txtPathName.Text = ofd.FileName;
            
            try
            {
                ComparingTxt = Book.Read_FileContent(ofd.FileName);
            }
            catch
            {
                lblProgress.Text = "";
                MessageBox.Show("لم تنجح اضافة الملف , الرجاء اغلاقه في حال كان مفتوحا");
                return;
            }
            sw = Stopwatch.StartNew();
            lblProgress.Text = "جاري المقارنة";
            Application.DoEvents();
            if (radioClass.Checked)
            {
                PreProcess.searchtype = "classfied";
                NoThreads();
            }
            else
            {
                PreProcess.searchtype = "meta";
                ThredingFiles();
            }
            ShowResult();
            /*DateTime startTime = DateTime.Now;
            for (int index = 0, count = lines.Count; index < count; index++) {
                // Do the processing
                ...

                // Calculate the time remaining:
                TimeSpan timeRemaining = TimeSpan.FromTicks(DateTime.Now.Subtract(startTime).Ticks * (count - (index+1)) / (index+1));

                // Display the progress to the user
                ...
            }
                   */
        }




        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreProcess.FinalFiles.Count == 0)
            return;
            else
            if (lstResults.SelectedItems.Count != 0  )
            {
                
                txtDecoded.Clear();
                txtDecoded.Text = PreProcess.FinalFiles[lstResults.SelectedIndex/2].text;
                for (int i = 0; i < PreProcess.FinalFiles[lstResults.SelectedIndex/2].sim; i++)
                {
                    txtDecoded.Select(PreProcess.FinalFiles[lstResults.SelectedIndex/2].dim[i, 0], PreProcess.FinalFiles[lstResults.SelectedIndex/2].dim[i, 1]);
                    txtDecoded.SelectionBackColor = Color.Red;
                }
            }
        }

        private void frm_search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Show myform = new frm_Show();
            myform.txtDecoded.Clear();
            for (int i = 0; i < PreProcess.ResFile.sim; i++)
            {
                int start1 = PreProcess.ResFile.dim[i, 0];
                int end1 = PreProcess.ResFile.dim[i, 0] + PreProcess.ResFile.dim[i, 1];
               
                for (int j = i + 1; j < PreProcess.ResFile.sim; j++)
                {
                    int start2 = PreProcess.ResFile.dim[j, 0]; ;
                    int end2 = PreProcess.ResFile.dim[j, 0] + PreProcess.ResFile.dim[j, 1];
                    if (start2 >= start1 && end2 <= end1)
                    {
                        PreProcess.ResFile.dim[j, 0] = 0;
                        PreProcess.ResFile.dim[j, 1] = 0;
                    }
                    else
                        if (start2 >= start1 && start2 <= end1 && end2 > end1)
                        {
                            PreProcess.ResFile.dim[j, 0] = end1;
                        }
                        else
                            if (start2 < start1 && end2 > start1 && end2 <= end1)
                            {
                                PreProcess.ResFile.dim[j, 1] = start1;
                            }



                }
            }
            int all = 0;
            for (int j = 0; j < PreProcess.ResFile.sim; j++)
                all += PreProcess.ResFile.dim[j, 1];
            myform.textBox1.Text = (all * 100 / PreProcess.c_text.Length).ToString() + " % " + "متشابه";
            myform.txtDecoded.Text = PreProcess.ResFile.text;
            for (int i = 0; i < PreProcess.ResFile.sim; i++)
            {
                PreProcess.l.DecodePosition(ref PreProcess.ResFile.dim[i, 0], ref PreProcess.ResFile.dim[i, 1]);
                myform.txtDecoded.Select(PreProcess.ResFile.dim[i, 0], PreProcess.ResFile.dim[i, 1]);
                myform.txtDecoded.SelectionBackColor = Color.Red;
                 
            }
           
          
           
         
            myform.Show();
        }

      
    }
}
