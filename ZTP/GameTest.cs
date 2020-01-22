using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class GameTest : Game
    {
        private int points;
        private int licznik;

       public GameTest(int level, int mode) : base(level, mode)
        {
            setLevel(level);
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
    }
}
