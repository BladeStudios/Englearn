using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace ZTP
{
    public partial class GameWindow : Form
    {
        private int selectedLevel; //0-default, 1-łatwy, 2-sredni, 3-trudny, 4-bardzo trudny, 5-ekspert
        private int selectedMode; //0-default, 1-tryb nauki, 2-tryb testu
        private int selectedTranslation; //0-default, 1-polski-angielski, 2-angielski-polski
        public Game game;
        public ArrayList polishWords; //przechowuje liste polskich slow wczytanych z pliku
        public ArrayList englishWords; //przechowuje liste angielskich slow wczytanych z pliku
        private int Licz = 3;
        private int wordIndex;

        public GameWindow(int selectedLevel, int selectedMode, int selectedTranslation)
        {
            InitializeComponent();
            setSelectedLevel(selectedLevel);
            setSelectedMode(selectedMode);
            setSelectedTranslation(selectedTranslation);
            if (selectedMode == 1)
            {
                questionLabel.Visible = false;
                game = new GameLearning(selectedLevel);
            }
            else
            {
                game = new GameTest(selectedLevel);
                questionLabel.Visible = true;
            }
            game.setQuestionNumber(1); //ustawienie przy ktorym pytaniu jestesmy
            if(answerEButton.Visible==false)
            {
                answerAButton.Visible = true;
                answerBButton.Visible = true;
                answerCButton.Visible = true;
                answerDButton.Visible = true;
                answerEButton.Visible = true;
            }
            //createButtons(selectedLevel);
            game.setButtonsVisibility(answerAButton, answerBButton, answerCButton, answerDButton, answerEButton, answerBox, enterButton);
            pointsLabel.Visible = false;

            Database polishDictionary = new Database();
            polishDictionary.loadData("PolishDictionary.txt");
            polishWords = polishDictionary.getData();

            Database englishDictionary = new Database();
            englishDictionary.loadData("EnglishDictionary.txt");
            englishWords = englishDictionary.getData();

            if(selectedTranslation==1)
                onChangeQuestion(polishWords, englishWords, selectedLevel, selectedMode, game);
            else if(selectedTranslation==2)
                onChangeQuestion(englishWords, polishWords, selectedLevel, selectedMode, game);
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

        /*
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
        }*/

        public string getLevelName(int level) //zwraca nazwe poziomu
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

        public string getModeName(int mode) //zwraca nazwe trybu
        {
            switch (mode)
            {
                case 1:
                    licznikLabel.Visible = false;
                    return "TRYB NAUKI";
                case 2:
                    licznikLabel.Visible = true;
                    StartTimer();
                    return "TRYB TESTU";
                default: return "Tryb nieznany!";
            }
        }

        public void StartTimer()
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = 1000;
           // licznikLabel.Text = "Czas: " + Licz;
            MyTimer.Tick += new EventHandler(nextQuestion);
            MyTimer.Start();
        }

        private void nextQuestion(object sender, EventArgs e)
        {
            //GameTest gameT = new GameTest(getSelectedLevel(), getSelectedMode());
            game.setLicznik(Licz);
            licznikLabel.Text = "Czas:" + game.getLicznik();
            game.setLicznik(--Licz);
           
            if (Licz == 0 && game.getQuestionNumber() <= 20)
            {
                if(selectedTranslation==1)
                    onChangeQuestion(polishWords, englishWords, selectedLevel, selectedMode, game);
                else if(selectedTranslation==2)
                    onChangeQuestion(englishWords, polishWords, selectedLevel, selectedMode, game);
            }
            else 
            {
                
            }
            
        }

        public string getTranslationName(int translation) //zwraca nazwe tlumaczenia
        {
            switch (translation)
            {
                case 1: return "POLSKI-ANGIELSKI";
                case 2: return "ANGIELSKI-POLSKI";
                default: return "Tłumaczenie nieznane!";
            }
        }

        public void setButtons(int selectedLevel) //ustawia odpowiednie wartosci buttonów
        {
            if (selectedLevel == 0) //tryb nieznany
            {

            }
            else if (selectedLevel == 5)//ekspert
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

        public void onChangeQuestion(ArrayList firstDictionary, ArrayList secondDictionary, int selectedLevel, int selectedMode, Game g)
        {
            Licz = 3;
            questionLabel.Text = "PYTANIE NUMER: " + g.getQuestionNumber() + "/20"; 
            if(g.getQuestionNumber()==21 && selectedMode==2)
            {
                wordLabel.Visible = false;
                answerAButton.Visible = false;
                answerBButton.Visible = false;
                answerCButton.Visible = false;
                answerDButton.Visible = false;
                answerEButton.Visible = false;
                answerBox.Visible = false;
                enterButton.Visible = false;
                pointsLabel.Visible = true;
                pointsLabel.Text = "TWOJE ZDOBYTE PUNKTY:" + g.getPoints().ToString();
                licznikLabel.Visible = false;
                pointsLabel.Visible = false;
            }
            //zmiana tła wszystkich odpowiedzi na biały
            answerAButton.BackColor = System.Drawing.Color.White;
            answerBButton.BackColor = System.Drawing.Color.White;
            answerCButton.BackColor = System.Drawing.Color.White;
            answerDButton.BackColor = System.Drawing.Color.White;
            answerEButton.BackColor = System.Drawing.Color.White;
            //lista przechowujaca indeksy slow ze slownika tak, aby na jej podstawie zapobiec powtarzaniu sie odpowiedzi
            List<int> list = new List<int>();
            //wylosowanie indexu slowa do odgadniecia
            wordIndex = g.getRandom(0, firstDictionary.Count-1);
            //dodanie indeksu do listy
            list.Add(wordIndex);
            //wpisanie wartosci spod wylosowanego indeksu jako wordLabel
            wordLabel.Text = firstDictionary[wordIndex].ToString();
            //wylosowanie, która odpowiedz bedzie prawdziwa
            g.setGoodAnswerIndex(g.getRandom(1, selectedLevel + 1)); //1-odpowiedzA, 2-odpowiedzB itd.
            //wpisanie poprawnej odpowiedzi pod odpowiedni button
            switch(g.getGoodAnswerIndex())
            {
                case 1:
                    {
                        answerAButton.Text = secondDictionary[wordIndex].ToString();
                        answerBButton.Text = secondDictionary[g.getWrongAnswerIndex(list,firstDictionary.Count-1)].ToString();
                        answerCButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerDButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerEButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                    } break;
                case 2:
                    {
                        answerAButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerBButton.Text = secondDictionary[wordIndex].ToString();
                        answerCButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerDButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerEButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                    }
                    break;
                case 3:
                    {
                        answerAButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerBButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerCButton.Text = secondDictionary[wordIndex].ToString();
                        answerDButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerEButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                    }
                    break;
                case 4:
                    {
                        answerAButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerBButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerCButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerDButton.Text = secondDictionary[wordIndex].ToString();
                        answerEButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                    }
                    break;
                case 5:
                    {
                        answerAButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerBButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerCButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerDButton.Text = secondDictionary[g.getWrongAnswerIndex(list, firstDictionary.Count - 1)].ToString();
                        answerEButton.Text = secondDictionary[wordIndex].ToString();
                    }
                    break;
                default: MessageBox.Show("Error: GameWindow.cs:onChangeState"); break;
            }

            g.setQuestionNumber(g.getQuestionNumber() + 1);
        }

        public void checkAnswer(int index, Button button) //index - jest to numer buttona z odpowiedziami, button - jest to obiekt tego buttona
        {
            if (game.getGoodAnswerIndex() == index)
            {
                game.setPoints(game.getPoints()+1);
                if(selectedTranslation==1)
                    onChangeQuestion(polishWords, englishWords, selectedLevel, selectedMode, game);
                else if(selectedTranslation==2)
                    onChangeQuestion(englishWords, polishWords, selectedLevel, selectedMode, game);
            }
            else
            {
                button.BackColor = System.Drawing.Color.Red;
                if (selectedTranslation == 1)
                    onChangeQuestion(polishWords, englishWords, selectedLevel, selectedMode, game);
                else if (selectedTranslation == 2)
                    onChangeQuestion(englishWords, polishWords, selectedLevel, selectedMode, game);
                game.setPoints(game.getPoints() + 0);
            }
        }
        public void checkAnswerText()
        {
            answerBox.BackColor = System.Drawing.Color.White;
            if (englishWords.IndexOf(answerBox.Text) == wordIndex)
            {
                onChangeQuestion(polishWords, englishWords, selectedLevel, selectedMode, game);
            }
            else
            {
                answerBox.BackColor = System.Drawing.Color.Red;
            }
            answerBox.Text = "";
           
        }

        private void answerAButton_Click(object sender, EventArgs e)
        {
            checkAnswer(1, answerAButton);
        }

        private void answerBButton_Click(object sender, EventArgs e)
        {
            checkAnswer(2, answerBButton);
        }

        private void answerCButton_Click(object sender, EventArgs e)
        {
            checkAnswer(3, answerCButton);
        }

        private void answerDButton_Click(object sender, EventArgs e)
        {
           checkAnswer(4, answerDButton);
        }

        private void answerEButton_Click(object sender, EventArgs e)
        {
           checkAnswer(5, answerEButton);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuWindow menu = new MenuWindow();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            checkAnswerText();
        }

       
    }
}
