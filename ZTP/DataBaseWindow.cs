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
        public DatabaseWindow()
        {
            InitializeComponent();
            Database db = new Database();
            db.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\PolishDictionary.txt");
            foreach (var c in db.getData())
            {
                listBox1.Items.Add(c);
                
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
    }
}
