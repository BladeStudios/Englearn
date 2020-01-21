using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class Game
    {
        private int level; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int mode; //0-default, 1-tryb nauki, 2-tryb testu
        private int state; //przy ktorym pytaniu aktualnie jestesmy

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
    }
}
