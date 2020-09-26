using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;

namespace StringSearch_Project
{

    public class file_con
    {
        public string text;
        public int[,] dim = new int[1000, 2];
        public int sim = 0;
        public double sl = 0;
        public string name = "";
        public string codedfile = "";
        public int id = 0;
    }

  
    class PreProcess
    {

        public SqlDataReader ScanFilesReader;
        public static string c_text = "";
        private static int ngram = 0;
        public static int MetaWordsLimit = 0;
        public static string searchtype = "";
        public List<file_con> Files = new List<file_con>();
        public static List<file_con> FinalFiles = new List<file_con>();
        public static file_con ResFile = new file_con();
        public static List<string> fm = null;
        public static Log l = new Log();

        public PreProcess(string ComparingTxt, int nGram, int vMetaWordsLimit)
        {
            if (c_text == "")
            {
               
                ResFile.text = ComparingTxt;
                c_text = l.CleanString(ComparingTxt);
              
            }
            if (fm == null)
            {
                MetaData meta = new MetaData(vMetaWordsLimit);
                meta.GetMeta(ComparingTxt);
                fm = meta.FinalMeta;
            }
            ngram = nGram;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void SearchSimilarity()
        {
            //get list from database
            while (ScanFilesReader.Read())
            {
                Log olf = new Log();
                olf.Deserialize((byte[])ScanFilesReader["log_file"]);
                MetaData meta = new MetaData(MetaWordsLimit);
                meta.Deserialize((byte[])ScanFilesReader["metadata"]);
                string DBtxt = ScanFilesReader["coded_file"].ToString();
                int c = 0;
                if (searchtype == "classfied")
                    c = 1;
                else
                foreach (string cur in fm)
                {
                    foreach (string ext in meta.FinalMeta)
                        if (cur == ext)
                        { c++; break; }
                    if (c > 0) break;
                }

                if ((c > 0))
                {
                    file_con f = new file_con();
                    int count = 0;
                    int sl = 0;

                   
                    
                    int readed_chars = 0;

                    int offset = 0;
                    while (offset < DBtxt.Length)
                    {
                        if (c_text == DBtxt)
                        {
                            count = 1;
                            sl = DBtxt.Length;
                            f.dim[0, 0] = 0;
                            f.dim[0, 1] = DBtxt.Length;
                            ResFile.dim[ResFile.sim, 0] = 0;
                            ResFile.dim[ResFile.sim, 1] = c_text.Length;
                            ResFile.sim++;
                            break;
                        }
                        // Cut a string
                        string comstr = "";
                        if (offset + ngram < DBtxt.Length)
                            comstr = DBtxt.Substring(offset, ngram);
                        else
                        {
                            comstr = DBtxt.Substring(offset, DBtxt.Length - offset);

                            if (comstr.Length < ngram)
                                break;
                        }
                        offset += ngram;

                        if (c_text.IndexOf(comstr) != -1)
                        {
                            // find it in the text 
                            // before similraty
                            int jj = c_text.IndexOf(comstr);
                            int gg = DBtxt.IndexOf(comstr, readed_chars);
                            string mystr = "";
                            while ((jj > 0) && (gg > readed_chars))
                                if (c_text[jj - 1] == DBtxt[gg - 1])
                                {
                                    string ch = Convert.ToString(DBtxt[gg - 1]);
                                    mystr = mystr.Insert(0, ch);

                                    jj--;
                                    gg--;
                                }
                                else
                                    break;

                            comstr = comstr.Insert(0, mystr);

                            // after similraty
                            int j = c_text.IndexOf(comstr) + comstr.Length;
                            gg = DBtxt.IndexOf(comstr, readed_chars) + comstr.Length;
                            for (int g = gg; g < DBtxt.Length; g++)
                            {
                                if (j >= c_text.Length)
                                    break;
                                if (DBtxt[g] == c_text[j])
                                {
                                    offset++;
                                    comstr += DBtxt[g];
                                }
                                else
                                    break;
                                j++;
                            }
                            int startindex = DBtxt.IndexOf(comstr, readed_chars);
                          //  if (startindex != -1)
                           // {
                                int sellength = comstr.Length;
                                sl += sellength;
                                f.dim[count, 0] = startindex;
                                f.dim[count, 1] = sellength;
                                count++;
                                readed_chars = DBtxt.IndexOf(comstr, readed_chars) + comstr.Length;
                                ResFile.dim[ResFile.sim, 0] = c_text.IndexOf(comstr);
                                ResFile.dim[ResFile.sim, 1] = comstr.Length;
                                
                                ResFile.sim++;
                          //  }
                           // else
                               // readed_chars = comstr.Length;
                        } // end if 
                    }// end while
                    if (count > 0)
                    {
                        f.text = ScanFilesReader["File_txt"].ToString();
                        f.sim = count;
                        f.sl = sl;
                        f.codedfile = DBtxt;
                        f.id = (int)ScanFilesReader["Book_id"];
                        f.name = ScanFilesReader["Book_name"].ToString();
                        f.sl = Math.Round((f.sl * 100) / f.codedfile.Length, 1);
                        for (int i = 0; i < f.sim; i++)
                            olf.DecodePosition(ref f.dim[i, 0], ref f.dim[i, 1]);
                         
                        Files.Add(f);
                        sl = 0;
                    }

                } // end if
            }//end while


            for (int j = 0; j < Files.Count; j++)
                PreProcess.FinalFiles.Add(Files[j]);
            // return files;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------
    }
}