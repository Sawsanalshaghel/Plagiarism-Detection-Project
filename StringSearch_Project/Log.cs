using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace StringSearch_Project
{
    public class Log
    {
        class LogObject
        {
            public int pos;
            public int length;
        }

        private List<LogObject> Logfile = null;

        public byte[] Serialize()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(stream);
                bw.Write(Logfile.Count);
                foreach (LogObject logobj in Logfile)
                {
                    // Save each value pair
                    bw.Write(logobj.pos);
                    bw.Write(logobj.length);
                }
                stream.Seek(0, SeekOrigin.Begin);
                BinaryReader reader = new BinaryReader(stream);
                byte[] data = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();
                bw.Close();
                return data;
            }
        }

        public void Deserialize(byte[] file)
        {
            Logfile.Clear();
            if (file.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.Write(file, 0, file.Length);
                    stream.Seek(0, SeekOrigin.Begin);
                    BinaryReader br = new BinaryReader(stream);
                    int entryCount = br.ReadInt32();
                    for (int entries = 0; entries < entryCount; entries++)
                    {
                        LogObject o = new LogObject();
                        // Read in the value pairs
                        o.pos = br.ReadInt32();
                        o.length = br.ReadInt32();
                        Logfile.Add(o);
                    }
                }
            }
        }

        private void LogEvent(int pos, int length)
        {
            LogObject o = new LogObject();
            o.pos = pos;
            o.length = length;
            Logfile.Add(o);
        }

        public string CleanString(string str)
        {
            // replace word seperators with empty spaces
            for (int i = 0; i < SearchHelper.wordseperators.Length; i++)
                str = str.Replace(SearchHelper.wordseperators[i], ' ');

            // replace stop words with empty spaces
            for (int i = 0; i < SearchHelper.StopList.Count; i++)
                str = str.Replace(' ' + SearchHelper.StopList[i] + ' ', "".PadLeft(SearchHelper.StopList[i].Length + 2));

            str = str.TrimEnd(new char[] { ' ' });

            int pos = str.IndexOf(' ');
            while (pos != -1)
            {
                int len = 1;
                while (str[pos + len] == ' ')
                    len++;
                LogEvent(pos, len);
                str = str.Remove(pos, len);
                pos = str.IndexOf(' ');
            }
            return str;
        }

        public void DecodePosition(ref int start, ref int length)
        {
            int s = start;
            int le = length;
            for (int i = 0; i < Logfile.Count - 1; i++)
            {
                LogObject o = Logfile[i] as LogObject;
                if (o.pos == 0 && s == 0)
                    start = 0;
                else
                if (o.pos <= s)
                    start += o.length;
                else
                    if (o.pos > s && (o.pos < s + le))
                        length += o.length;
            }
        }

        public Log()
        {
            SearchHelper.Init();
            Logfile = new List<LogObject>();
        }
    }
}
