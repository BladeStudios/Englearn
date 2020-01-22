using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTP
{
    public abstract class GameLevel
    {
       public abstract void setButtonsVisibility(Button answerA, Button answerB, Button answerC, Button answerD, Button answerE, RichTextBox answerBox, Button enterButton);
    }
}
