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
        public MenuWindow()
        {
            InitializeComponent();
            Database database = new Database();
            database.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\PolishDictionary.txt");
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
            GameWindow game = new GameWindow();
            game.Closed += (s, args) => this.Close();
            game.Show();
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
            DatabaseWindow db = new DatabaseWindow();
            db.Closed += (s, args) => this.Close();
            db.Show();
        }
    }
}
