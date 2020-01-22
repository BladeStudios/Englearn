using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class GameTest : GameMode
    {
        private int points;
        private int licznik;

       public GameTest(int level) : base(level)
        {
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

        public override int getPoints()
        {
            return this.points;
        }

        public override void setPoints(int points)
        {
            this.points = points;
        }
        public override int getLicznik()
        {
            return this.licznik;
        }

        public override void setLicznik(int licznik)
        {
            this.licznik = licznik;
        }
    }
}
