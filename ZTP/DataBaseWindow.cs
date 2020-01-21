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
    public partial class DatabaseWindow : Form
    {
        private int selectedTranslation; //0-default, 1-polski-angielski, 2-angielski-polski
        public DatabaseWindow(int selectedTranslation)
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Database dbPol = new Database();
            Database dbEng = new Database();
            dbPol.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\PolishDictionary.txt");
            foreach (var c in dbPol.getData())
            {
                listBoxPol.Items.Add(c);
            }
            dbEng.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\EnglishDictionary.txt");
            foreach (var c in dbEng.getData())
            {
                listBoxEng.Items.Add(c);
            }
                

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuWindow menu = new MenuWindow();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void DatabaseWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
