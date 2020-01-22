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
                MessageBox.Show("Cannot load file. Error: " + e.ToString());
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
                MessageBox.Show("Cannot save file. Error: " + e.ToString());
            }
        }

        public void ClearData()
        {
            data.Clear();
        } // wyczyszczenie data

        public void addWord(string word)
        {
            data.Add(word);
        }

        public void deleteWord(int word)
        {
            data.RemoveAt(word);
        }
        public void editWord(int word, string newWord)
        {
            data[word] = newWord;
        }
        public string getWord(int index)
        {
            return data[index].ToString();
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
