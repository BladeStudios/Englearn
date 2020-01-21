using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ZTP
{
    public class Game
    {
        private int level; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int mode; //0-default, 1-tryb nauki, 2-tryb testu
        private int state; //przy ktorym pytaniu aktualnie jestesmy
        private int goodAnswerIndex; //indeks prawidlowej odpowiedzi: 1-A, 2-B itd.

        public Game(int level, int mode)
        {
            setLevel(level);
            setMode(mode);
        }

        //GETTERY I SETTERY
        public int getLevel()
        {
            return this.level;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public int getMode()
        {
            return this.mode;
        }

        public void setMode(int mode)
        {
            this.mode = mode;
        }

        public int getState()
        {
            return this.state;
        }

        public void setState(int state)
        {
            this.state = state;
        }

        public int getGoodAnswerIndex()
        {
            return this.goodAnswerIndex;
        }

        public void setGoodAnswerIndex(int index)
        {
            this.goodAnswerIndex = index;
        }

        public ArrayList getDictionary(string filename)
        {
            Database database = new Database();
            database.loadData(filename);
            return database.getData();
        }

        public int getRandom(int min, int max)
        {
            Random random = new Random();
            int rnd = random.Next(min, max);
            return rnd;
        }

        public string getWord(ArrayList dictionary, int index)
        {
            return dictionary[index].ToString();
        }

        public int getWrongAnswerIndex(List<int> numbersToNotGenerate, int maxIndex)
        {
            int rnd;
            bool generated = true;
            do
            {
                rnd = getRandom(0, maxIndex);
                generated = true;
                for (int i = 0; i < numbersToNotGenerate.Count; i++)
                {
                    if (numbersToNotGenerate[i] == rnd)
                    {
                        generated = false;
                    }
                }
            } while (!generated);
            numbersToNotGenerate.Add(rnd);
            return rnd;
        }
    }
}
