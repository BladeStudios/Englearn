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
        //0-default, 1-polski-angielski, 2-angielski-polski
        Database dbPol = new Database();
        Database dbEng = new Database();
        private int selectedWordIndex;
                  
        private static DatabaseWindow instance;

        private DatabaseWindow()
        {
            InitializeComponent();
            loadData();
        }

        public static DatabaseWindow getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new DatabaseWindow();
            return instance;
        }

        private void loadData()
        {
            dbPol.ClearData();
            dbEng.ClearData();
            listBoxPol.Items.Clear();
            listBoxEng.Items.Clear();
            dbPol.loadData("PolishDictionary.txt");
            foreach (var c in dbPol.getData())
            {
                listBoxPol.Items.Add(c);
            }
            dbEng.loadData("EnglishDictionary.txt");
            foreach (var c in dbEng.getData())
            {
                listBoxEng.Items.Add(c);
            }


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DetailsDatabaseWindow detailsdata = new DetailsDatabaseWindow(1, -1);
            detailsdata.ShowDialog();
            loadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxPol.SelectedIndex != -1)
            {
                dbPol.deleteWord(listBoxPol.SelectedIndex);
                dbEng.deleteWord(listBoxPol.SelectedIndex);
                dbPol.saveData("PolishDictionary.txt");
                dbEng.saveData("EnglishDictionary.txt");
                loadData();
            }
            else if (listBoxEng.SelectedIndex != -1)
            {
                dbPol.deleteWord(listBoxEng.SelectedIndex);
                dbEng.deleteWord(listBoxEng.SelectedIndex);
                dbPol.saveData("PolishDictionary.txt");
                dbEng.saveData("EnglishDictionary.txt");
                loadData();
            }
            else
                MessageBox.Show("Nie wybrałeś słówka do usunięcia!");


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuWindow menu = MenuWindow.getInstance();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBoxPol.SelectedIndex != -1)
            {
                DetailsDatabaseWindow detailsdata = new DetailsDatabaseWindow(2, listBoxPol.SelectedIndex);
                selectedWordIndex = listBoxPol.SelectedIndex;
                detailsdata.setIndexEdit(listBoxPol.SelectedIndex);
                detailsdata.ShowDialog();
                loadData();
            }
            else if (listBoxEng.SelectedIndex != -1)
            {
                DetailsDatabaseWindow detailsdata = new DetailsDatabaseWindow(2, listBoxEng.SelectedIndex);
                selectedWordIndex = listBoxEng.SelectedIndex;
                detailsdata.setIndexEdit(listBoxEng.SelectedIndex);
                detailsdata.ShowDialog();
                loadData();
            }
            else
                MessageBox.Show("Nie wybrałeś słówka do edycji!");


        }
    }
}
