using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ZTP
{
    class Database
    {
        private ArrayList data = new ArrayList();

        public void loadData(string filename) //laduje dane z pliku do zmiennej data
        {
            //TODO
            try
            {
                using (StreamReader streamR = new StreamReader(filename))
                {
                    string row;

                    while ((row = streamR.ReadLine()) != null)
                    {
                        addWord(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error load File");
            }
        }

        public void saveData(string filename)  //nadpisuje plik wartosciami ze zmiennej data
        {
            //TODO
            try
            {
                using (StreamWriter streamW = new StreamWriter(filename))
                {
                    foreach (var save in data)
                    {
                        streamW.WriteLine(save);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error save File");
            }
        }

        public void addWord(string word)
        {
            data.Add(word);
        }

        public void deleteWord(string word)
        {
            data.Remove(data.LastIndexOf(word));
        }

        public void editWord(string word, string newWord)
        {
            data[data.LastIndexOf(word)] = newWord;
        }
        public ArrayList getData()
        {
            return this.data;
        }

        public void setData(ArrayList data)
        {
            this.data = data;
        }
    }
}
