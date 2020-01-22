using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTP
{
    class ExpertLevel : GameLevel
    {
        public override void setButtonsVisibility(Button answerA, Button answerB, Button answerC, Button answerD, Button answerE, RichTextBox answerBox, Button enterButton)
        {
            answerA.Visible = false;
            answerB.Visible = false;
            answerC.Visible = false;
            answerD.Visible = false;
            answerE.Visible = false;
            answerBox.Visible = true;
            enterButton.Visible = true;
        }
    }
}
