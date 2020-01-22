using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ZTP
{
    public abstract class Game
    {
        protected GameLevel level; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int mode; //0-default, 1-tryb nauki, 2-tryb testu
        private int questionNumber; //przy ktorym pytaniu aktualnie jestesmy
        private int goodAnswerIndex; //indeks prawidlowej odpowiedzi: 1-A, 2-B itd.

        public abstract void setLicznik(int licznik);
        public abstract int getLicznik();
        public abstract void setPoints(int points);
        public abstract int getPoints();

        public Game(int level)
        {
            setMode(mode);
            switch(level)
            {
                case 1: this.level = new EasyLevel(); break;
                case 2: this.level = new MediumLevel(); break;
                case 3: this.level = new HardLevel(); break;
                case 4: this.level = new VeryHardLevel(); break;
                case 5: this.level = new ExpertLevel(); break;
                default: this.level = new EasyLevel(); break;
            }
        }

        public void setButtonsVisibility(Button answerA, Button answerB, Button answerC, Button answerD, Button answerE, RichTextBox answerBox, Button enterButton)
        {
            this.level.setButtonsVisibility(answerA, answerB, answerC, answerD, answerE, answerBox, enterButton);
        }

        //GETTERY I SETTERY
        public GameLevel getLevel()
        {
            return this.level;
        }

        public void setLevel(GameLevel level)
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

        public int getQuestionNumber()
        {
            return this.questionNumber;
        }

        public void setQuestionNumber(int number)
        {
            this.questionNumber = number;
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
            //int rnd = random.Next(min, max);
            //return rnd;
            return random.Next(min, max+1);
        }

        public string getWord(ArrayList dictionary, int index)
        {
            return dictionary[index].ToString();
        }

        public int getWrongAnswerIndex(List<int> numbersToNotGenerate, int maxIndex)
        {
            int rnd;
            bool generated;
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
