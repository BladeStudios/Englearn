using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTP
{
    public partial class GameWindow : Form
    {
        private int selectedLevel; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int selectedMode; //0-default, 1-tryb nauki, 2-tryb testu
        private int selectedTranslation; //0-default, 1-polski-angielski, 2-angielski-polski

        public GameWindow(int selectedLevel, int selectedMode, int selectedTranslation)
        {
            InitializeComponent();
            setSelectedLevel(selectedLevel);
            setSelectedMode(selectedMode);
            setSelectedTranslation(selectedTranslation);
            Game game = new Game(selectedLevel, selectedMode);
            game.setState(1); //ustawienie przy ktorym pytaniu jestesmy
            if(answerEButton.Visible==false)
            {
                answerAButton.Visible = true;
                answerBButton.Visible = true;
                answerCButton.Visible = true;
                answerDButton.Visible = true;
                answerEButton.Visible = true;
            }
            createButtons(selectedLevel);
        }

        //GETTERY I SETTERY

        public int getSelectedLevel()
        {
            return this.selectedLevel;
        }

        public void setSelectedLevel(int selectedLevel)
        {
            levelLabel.Text = "Poziom trudności: " + getLevelName(selectedLevel);
            this.selectedLevel = selectedLevel;
        }

        public int getSelectedMode()
        {
            return this.selectedMode;
        }

        public void setSelectedMode(int selectedMode)
        {
            modeLabel.Text = "Tryb programu: " + getModeName(selectedMode);
            this.selectedMode = selectedMode;
        }

        public int getSelectedTranslation()
        {
            return this.selectedTranslation;
        }

        public void setSelectedTranslation(int selectedTranslation)
        {
            translationLabel.Text = "Tłumaczenie: " + getTranslationName(selectedTranslation);
            this.selectedTranslation = selectedTranslation;
        }

        public void createButtons(int selectedLevel) // tworzy odpowiednia ilosc i ulozenie buttonow zaleznie od wybranego poziomu
        {
            if(selectedLevel==0) //tryb nieznany
            {

            }
            else if(selectedLevel==5)//ekspert
            {

            }
            else
            {
                if (selectedLevel <= 3) //latwy,sredni,trudny
                    answerEButton.Visible = false;
                if (selectedLevel <= 2) //latwy, sredni
                    answerDButton.Visible = false;
                if (selectedLevel == 1) //latwy
                    answerCButton.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string getLevelName(int level)
        {
            switch(level)
            {
                case 1: return "ŁATWY";
                case 2: return "ŚREDNI";
                case 3: return "TRUDNY";
                case 4: return "BARDZO TRUDNY";
                case 5: return "EKSPERT";
                default: return "Poziom nieznany!";
            }
        }

        public string getModeName(int mode)
        {
            switch (mode)
            {
                case 1: return "TRYB NAUKI";
                case 2: return "TRYB TESTU";
                default: return "Tryb nieznany!";
            }
        }

        public string getTranslationName(int translation)
        {
            switch (translation)
            {
                case 1: return "POLSKI-ANGIELSKI";
                case 2: return "ANGIELSKI-POLSKI";
                default: return "Tłumaczenie nieznane!";
            }
        }
    }
}
