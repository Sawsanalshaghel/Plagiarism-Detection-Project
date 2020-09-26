using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StringSearch_Project
{
    public class MetaData
    {
        public Dictionary<string, int> MetaList = null;
        public List<string> FinalMeta = null;
        public static  int MetaWordsLimit = 20;
        public MetaData(int vMetaWordsLimit)
        {
            SearchHelper.Init();
            MetaList = new Dictionary<string, int>();
            FinalMeta = new List<string>();
            MetaWordsLimit = vMetaWordsLimit;
        }

        public Dictionary<string, int> SortMyDictionaryByValue(Dictionary<string, int> myDictionary)
        {
            List<KeyValuePair<string, int>> tempList = new List<KeyValuePair<string, int>>(myDictionary);

            tempList.Sort(delegate(KeyValuePair<string, int> firstPair, KeyValuePair<string, int> secondPair)
            {
                return firstPair.Value.CompareTo(secondPair.Value);
            }
                );

            tempList.Reverse();

            Dictionary<string, int> mySortedDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> pair in tempList)
            {
                mySortedDictionary.Add(pair.Key, pair.Value);
            }

            return mySortedDictionary;
        }

        private void GenerateFinalMeta()
        {
            FinalMeta.Clear();
            MetaList = SortMyDictionaryByValue(MetaList);
            List<string> list = new List<string>(MetaList.Keys);
            int count = list.Count;
            if (count > MetaWordsLimit)
                count = MetaWordsLimit;
            for (int i = 0; i < count; i++)
                FinalMeta.Add(list[i]);
            
        }

        public void GetMeta(string Text)
        {
            string[] words = Text.Split(SearchHelper.wordseperators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                if (SearchHelper.StopList.IndexOf(words[i]) == -1)
                    if (MetaList.ContainsKey(words[i]))
                        MetaList[words[i]] += 1;
                    else
                        MetaList.Add(words[i], 1);
            GenerateFinalMeta();
        }

        public byte[] Serialize()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(stream);
                bw.Write(FinalMeta.Count);
                foreach (string metaword in FinalMeta)
                    bw.Write(metaword);
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
            FinalMeta.Clear();
            if (file.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.Write(file, 0, file.Length);
                    stream.Seek(0, SeekOrigin.Begin);
                    BinaryReader br = new BinaryReader(stream);
                    int entryCount = br.ReadInt32();
                    for (int entries = 0; entries < entryCount; entries++)
                        FinalMeta.Add(br.ReadString());
                }
            }
        }
    }
}