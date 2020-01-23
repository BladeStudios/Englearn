using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTP
{
    class MediumLevel : GameLevel
    {
        public override void setButtonsVisibility(Button answerA, Button answerB, Button answerC, Button answerD, Button answerE, TextBox answerBox, Button enterButton)
        {
            answerA.Visible = true;
            answerB.Visible = true;
            answerC.Visible = true;
            answerD.Visible = false;
            answerE.Visible = false;
            answerBox.Visible = false;
            enterButton.Visible = false;
        }
    }
}
