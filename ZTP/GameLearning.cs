using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class GameLearning : Game
    {
        public GameLearning(int level, int mode) : base(level, mode)
        {
           // setLevel(level);
            setMode(mode);
        }
    }
}
