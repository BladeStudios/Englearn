using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class GameTest : Game
    {
        private int points; // punkty za prawidłowe odpowiedzi
        private int questionNumber; //przy ktorym pytaniu aktualnie jestesmy
        private int licznik; // czas na odpowiedz
       

        public GameTest(int level, int mode) : base(level, mode)
        {
            setMode(mode);
        }

        public int getPoints()
        {
            return this.points;
        }

        public void setPoints(int points)
        {
            this.points = points;
        }
        public int getLicznik()
        {
            return this.licznik;
        }
        public void setLicznik(int licznik)
        {
            this.licznik = licznik;
        }
        public int getQuestionNumber()
        {
            return this.questionNumber;
        }

        public void setQuestionNumber(int number)
        {
            this.questionNumber = number;
        }

      


    }
}
