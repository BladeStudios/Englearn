using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP
{
    class GameLearning : GameMode
    {
        public GameLearning(int level) : base(level)
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
            return 0;
        }

        public override void setPoints(int points)
        {

        }
        public override int getLicznik()
        {
            return 0;
        }

        public override void setLicznik(int licznik)
        {

        }
        public override int getQuestionNumber()
        {
            return this.questionNumber;
        }

        public override void setQuestionNumber(int number)
        {
            this.questionNumber = number;
        }
    }
}
