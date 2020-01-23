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
    public partial class MenuWindow : Form
    {
        private int level; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int mode; //0-default, 1-tryb nauki, 2-tryb testu
        private int translation; //0-nie wybrane, 1-polski-angielski, 2-angielski-polski

        private static MenuWindow instance;

        private MenuWindow()
        {
            InitializeComponent();
            Database database = new Database();
            database.loadData("PolishDictionary.txt");
            modeBox.Text = "TRYB NAUKI";
            setMode(modeBox.Text);
            levelBox.Text = "ŁATWY";
            setLevel(levelBox.Text);
            translationBox.Text = "POLSKI-ANGIELSKI";
            setTranslation(translationBox.Text);
        }

        public static MenuWindow getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new MenuWindow();
            return instance;
        }

        void setMode(string mode)
        {
            if (String.Compare(mode, "TRYB NAUKI") == 0)
                this.mode = 1;
            else if (String.Compare(mode, "TRYB TESTU") == 0)
                this.mode = 2;
            else
                this.mode = 0;
        }

        int getMode()
        {
            return this.mode;
        }

        void setLevel(string level)
        {
            if (String.Compare(level, "ŁATWY") == 0)
                this.level = 1;
            else if (String.Compare(level, "ŚREDNI") == 0)
                this.level = 2;
            else if (String.Compare(level, "TRUDNY") == 0)
                this.level = 3;
            else if (String.Compare(level, "BARDZO TRUDNY") == 0)
                this.level = 4;
            else if (String.Compare(level, "EKSPERT") == 0)
                this.level = 5;
            else
                this.level = 0;
        }

        int getLevel()
        {
            return this.level;
        }

        void setTranslation(string translation)
        {
            if (String.Compare(translation, "POLSKI-ANGIELSKI") == 0)
                this.translation = 1;
            else if (String.Compare(translation, "ANGIELSKI-POLSKI") == 0)
                this.translation = 2;
            else
                this.translation = 0;
        }

        int getTranslation()
        {
            return this.translation;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            setMode(modeBox.Text);
            setLevel(levelBox.Text);
            setTranslation(translationBox.Text);
            GameWindow game = new GameWindow(getLevel(),getMode(),getTranslation());
            game.Show();
            game.Closed += (s, args) => this.Show();
            
        }

        private void learningModelLabel_Click(object sender, EventArgs e)
        {

        }

        private void endButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BazaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseWindow db = DatabaseWindow.getInstance();
            db.Show();
            db.Closed += (s, args) => this.Show();
        }
    }
}
