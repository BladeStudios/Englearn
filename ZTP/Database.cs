using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ZTP
{
    class Database
    {
        private ArrayList data = new ArrayList();

        public void loadData(string filename) //laduje dane z pliku do zmiennej data
        {
            //TODO
        }

        public void saveData(string filename) //nadpisuje plik wartosciami ze zmiennej data
        {
            //TODO
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
    }
}
