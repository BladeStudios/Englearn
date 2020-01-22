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
    }
}
