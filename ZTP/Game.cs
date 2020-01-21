using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class Game
    {
        private int level; //poziom trudnosci: 0-easy, 1-medium, 2-hard, 3-ekspert
        private int mode; //tryb: 0-tryb nauki, 1-tryb testu
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
