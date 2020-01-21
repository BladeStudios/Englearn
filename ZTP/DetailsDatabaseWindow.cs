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
    public partial class DetailsDatabaseWindow : Form
    {
        private string Pol;
        private string Eng;
        private int choise; // 1 dodawanie 2 edycja
        private int indexEdit; // które słówka do edycjii
        Database dbPol = new Database();
        Database dbEng = new Database();
        DatabaseWindow dbWindow = new DatabaseWindow();

        public DetailsDatabaseWindow(int index, int selectedIndexWord ) // index jeżeli 1 to dodanie słówka jeżeli 2 edycja
        {
            InitializeComponent();
            choise = index;
            dbPol.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\PolishDictionary.txt");
            dbEng.loadData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\EnglishDictionary.txt");
            if(choise == 2 )
            {
                indexEdit = selectedIndexWord;
                Pol = dbPol.getWord(selectedIndexWord);
                Eng = dbEng.getWord(selectedIndexWord);
                richTextBox1.Text = Pol;
                richTextBox2.Text = Eng;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Pol = richTextBox1.Text;
            Eng = richTextBox2.Text;
            if (choise == 1)
            { 
                dbPol.addWord(Pol);
                dbEng.addWord(Eng);
            }
            else if(choise == 2)
            {
                dbPol.editWord(indexEdit, Pol);
                dbEng.editWord(indexEdit, Eng);
            }
            MessageBox.Show("Sukces!!");
            dbPol.saveData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\PolishDictionary.txt");
            dbEng.saveData("C:\\Users\\Maksi\\Source\\Repos\\BladeStudios\\Englearn\\ZTP\\EnglishDictionary.txt");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void back_Button(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
