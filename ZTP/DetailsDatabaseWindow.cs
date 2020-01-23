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

        public DetailsDatabaseWindow(int windowMode, int selectedWordIndex ) // windowMode: 1-dodanie słówka, 2-edycja
        {
            InitializeComponent();
            choise = windowMode;
            dbPol.loadData("PolishDictionary.txt");
            dbEng.loadData("EnglishDictionary.txt");
            if(choise == 2 )
            {
                indexEdit = selectedWordIndex;
                Pol = dbPol.getWord(selectedWordIndex);
                Eng = dbEng.getWord(selectedWordIndex);
                textBoxPol.Text = Pol;
                textBoxEng.Text = Eng;
            }
        }

        public void setIndexEdit(int indexEdit)
        {
            this.indexEdit = indexEdit;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Pol = textBoxPol.Text;
            Eng = textBoxEng.Text;
            if (choise == 1)
            {
                if (textBoxPol.Text != "" && textBoxEng.Text != ""  )
                {
                    if (sprawdz_wyraz(textBoxPol.Text) && sprawdz_wyraz(textBoxEng.Text))
                    {
                        dbPol.addWord(Pol);
                        dbEng.addWord(Eng);
                        MessageBox.Show("Sukces!!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Złe Dane!!");
                }
                else
                    MessageBox.Show("Puste pola!!");
                
            }
            else if(choise == 2)
            {
                if (textBoxPol.Text != "" && textBoxEng.Text != "")
                {
                    if (sprawdz_wyraz(textBoxPol.Text) && sprawdz_wyraz(textBoxEng.Text))
                    {
                        dbPol.editWord(indexEdit, Pol);
                        dbEng.editWord(indexEdit, Eng);
                        MessageBox.Show("Sukces!!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Złe Dane!!");
                }
                else
                    MessageBox.Show("Puste pola!!");

            }
            
            dbPol.saveData("PolishDictionary.txt");
            dbEng.saveData("EnglishDictionary.txt");
            

        }

        private bool sprawdz_wyraz(string wyraz)
        {
            foreach(var znak in wyraz)
            {
                if (!Char.IsLetter(znak))
                    return false;
            }
            return true;
        }

        private void back_Button(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void seve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
