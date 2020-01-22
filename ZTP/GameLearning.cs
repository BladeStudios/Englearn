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
            setMode(mode);
            switch (level)
            {
                case 1: this.level = new EasyLevel(); break;
                case 2: this.level = new MediumLevel(); break;
                case 3: this.level = new HardLevel(); break;
                case 4: this.level = new VeryHardLevel(); break;
                case 5: this.level = new ExpertLevel(); break;
                default: this.level = new EasyLevel(); break;
            }
        }
    }
}
