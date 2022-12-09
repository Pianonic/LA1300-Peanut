using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LA1300_Penut
{
    public partial class Form1 : Form
    {
        int Wette = 1;
        double Guthaben = 10;
        string currentdyrectorry = Environment.CurrentDirectory;
        string[] fileArray = Directory.GetFiles(@"C:\Users\nicla\source\repos\LA1300-Peanut\Cards\", "*.png", SearchOption.AllDirectories);
        string CardBackground = @"C:\Users\nicla\source\repos\LA1300-Peanut\CardBackground.png";

        string filename = null;
        string[] NamesPNGFull = new string[52];
        string[] CardValue = new string[52];
        string[] cache = new string[2];
        int Points = 0;
        int BankPoints = 0;
        int cachePoints = 0;
        bool FirstRound = true;
        bool GameEndet = false;
        bool isBet = false;
        bool isClick = false;
        bool isDouble = false;

        List<PictureBox> items = new List<PictureBox>();


        Random rnd = new Random();
        int rndNum = 0;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuthabenZahl.BackColor = System.Drawing.Color.Transparent;
            WetteZahl.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
            GuthabenZahl.Refresh();
            WetteZahl.Text = Convert.ToString(Wette) + " CHF";
            WetteZahl.Refresh();

            foreach (string item in fileArray)
            {
                filename = Path.GetFileName(item);
                NamesPNGFull[counter] = filename;
                counter++;
            }
            counter = 0;

            foreach (string s in NamesPNGFull)
            {
                cache = s.Split('_');
                CardValue[counter] = cache[0];
                counter++;
            }
            counter = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isBet)
            {
                BankCard();

                if (Points < 21)
                {
                    if (counter == 0)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K3.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 1)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K4.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 2)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K5.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 3)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K6.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 4)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K7.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 5)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K8.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 6)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K9.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 7)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K10.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 8)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K11.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    else if (counter == 9)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K12.Image = new Bitmap(fileArray[rndNum]);
                        DebugText.Text = CardValue[rndNum];
                        DebugText.Refresh();
                        counter++;
                    }
                    AddPoints();
                }
                
                if (Points > 21)
                {
                    GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                    GuthabenZahl.Refresh();
                    MessageBox.Show("Sie haben Verloren", "BalckJack");
                    Reset();
                }

                if (BankPoints > 21)
                {
                    Guthaben = Guthaben + Wette * 2;
                    GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                    GuthabenZahl.Refresh();
                    MessageBox.Show("Sie haben Gewonnen", "BalckJack");
                    Reset();
                }
                
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack");
            }

        }

        private void MehrWetten_Click(object sender, EventArgs e)
        {
            if (Wette < Guthaben)
            {
                Wette++;
                WetteZahl.Text = Convert.ToString(Wette) + " CHF";
                WetteZahl.Refresh();
            }
            else
            {
                WetteZahl.Text = "Max!";
                WetteZahl.Refresh();
                WetteZahl.BackColor = System.Drawing.Color.Red;
                WetteZahl.Refresh();
                Thread.Sleep(500);
                WetteZahl.BackColor = System.Drawing.Color.Transparent;
                WetteZahl.Refresh();
                WetteZahl.Text = Convert.ToString(Wette) + " CHF";
                WetteZahl.Refresh();
            }
        }
        private void WenigerWetten_Click(object sender, EventArgs e)
        {
            if (Wette > 1)
            {
                Wette--;
                WetteZahl.Text = Convert.ToString(Wette) + " CHF";
                WetteZahl.Refresh();
            }
            else
            {
                WetteZahl.Text = "Min!";
                WetteZahl.Refresh();
                WetteZahl.BackColor = System.Drawing.Color.Red;
                WetteZahl.Refresh();
                Thread.Sleep(500);
                WetteZahl.BackColor = System.Drawing.Color.Transparent;
                WetteZahl.Refresh();
                WetteZahl.Text = Convert.ToString(Wette) + " CHF";
                WetteZahl.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Möchtest du das Spiel wirklich verlassen?";
            string title = "Verlassen";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Do something  
            }
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (isBet == false)
            {

                if (Wette <= Guthaben)
                {
                    Guthaben = Guthaben - Wette;
                    GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                    GuthabenZahl.Refresh();
                    isClick = true;
                }
                else
                {
                    WetteZahl.Text = "Zu hoch!";
                    WetteZahl.Refresh();
                    WetteZahl.BackColor = System.Drawing.Color.Red;
                    WetteZahl.Refresh();
                    Thread.Sleep(500);
                    WetteZahl.BackColor = System.Drawing.Color.Transparent;
                    WetteZahl.Refresh();
                    WetteZahl.Text = Convert.ToString(Wette) + " CHF";
                    WetteZahl.Refresh();
                }

                if (isClick)
                {
                    BankCard();

                    if (FirstRound)
                    {
                        rndNum = rnd.Next(fileArray.Length);
                        K1.Image = new Bitmap(fileArray[rndNum]);

                        AddPoints();

                        rndNum = rnd.Next(fileArray.Length);
                        K2.Image = new Bitmap(fileArray[rndNum]);

                        AddPoints();

                        FirstRound = false;

                        if (Points == 21)
                        {
                            MessageBox.Show("Sie haben BlackJack", "BalckJack");
                            Guthaben = Guthaben + Wette + (1.5 * Wette);
                            GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                            GuthabenZahl.Refresh();
                            Wette = 0;
                        }
                    }
                    isBet = true;
                    isClick = false;
                }
            }
            else
            {
                MessageBox.Show("Sie können nicht mehr wetten!", "BlackJack");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Hallo", "Test", buttons);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isBet)
            {
                if (Wette * 2 <= Guthaben)
                {
                    isDouble = true;
                    button7_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sie müssen die wette verniedrigen oder haben zu wenig Geld", "BlackJack");
                }
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isBet)
            {
                if (GameEndet == false)
                {
                    if (Points < BankPoints || Points > 21)
                    {
                        GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                        GuthabenZahl.Refresh();
                        MessageBox.Show("Sie haben Verloren", "BalckJack");
                    }
                    else if (BankPoints > 21)
                    {
                        Guthaben = Guthaben + Wette * 2;
                        GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                        GuthabenZahl.Refresh();
                        MessageBox.Show("Sie haben Gewonnen", "BalckJack");
                    }
                    else if (BankPoints == Points)
                    {
                        Guthaben = Guthaben + Wette;
                        GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                        GuthabenZahl.Refresh();
                        MessageBox.Show("Es herscht gleichstand", "BalckJack");
                    }
                    else
                    {
                        Guthaben = Guthaben + Wette * 2;
                        GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                        GuthabenZahl.Refresh();
                        MessageBox.Show("Sie haben Gewonnen", "BalckJack");
                    }
                    GameEndet = true;
                    Reset();
                }
                else
                {
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack");
            }
        }

        private void SplitB_Click(object sender, EventArgs e)
        {
            if(isBet)
            {
                MessageBox.Show("Dieser Button macht noch nichts :)", "BlackJack");
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack");
            }
            //Create_New_Card();
        }

        private void BankCard()
        {
            if (FirstRound)
            {
                rndNum = rnd.Next(fileArray.Length);
                BankPic.Image = new Bitmap(fileArray[rndNum]);

                AddBankPoins();

                rndNum = rnd.Next(fileArray.Length);
                BankPic.Image = new Bitmap(fileArray[rndNum]);

                AddBankPoins();

            }
            else
            {
                if (BankPoints >= 18)
                {
                    //nichts
                }
                else if (BankPoints < 21)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    BankPic.Image = new Bitmap(fileArray[rndNum]);

                    AddBankPoins();
                }
            }
        }

        private void AddBankPoins()
        {
            try
            {
                BankPoints = BankPoints + Convert.ToInt32(CardValue[rndNum]);
                DebugBank.Text = Convert.ToString(BankPoints);
                DebugBank.Refresh();
            }
            catch
            {

                if (CardValue[rndNum] == "ace")
                {
                    cachePoints = BankPoints;
                    cachePoints = cachePoints + 11;
                    if (cachePoints > 21)
                    {
                        cachePoints = 0;
                        BankPoints++;
                    }
                    else
                    {
                        BankPoints = BankPoints + 11;
                    }
                    DebugBank.Text = Convert.ToString(BankPoints);
                    DebugBank.Refresh();
                }
                else
                {
                    BankPoints = BankPoints + 10;
                    DebugBank.Text = Convert.ToString(BankPoints);
                    DebugBank.Refresh();
                }
            }

            DebugText.Text = CardValue[rndNum];
            DebugText.Refresh();
        }

        private void AddPoints()
        {
            try
            {
                Points = Points + Convert.ToInt32(CardValue[rndNum]);
                DebugText.Text = Convert.ToString(Points);
                DebugText.Refresh();
            }
            catch
            {
                if (CardValue[rndNum] == "ace")
                {
                    cachePoints = Points;
                    cachePoints = cachePoints + 11;
                    if (cachePoints > 21)
                    {
                        cachePoints = 0;
                        Points++;
                    }
                    else
                    {
                        Points = Points + 11;
                    }
                    DebugText2.Text = Convert.ToString(Points);
                    DebugText2.Refresh();
                }
                else
                {
                    Points = Points + 10;
                    DebugText2.Text = Convert.ToString(Points);
                    DebugText2.Refresh();
                }
            }
        }
        private void Reset()
        {
            K1.Image = new Bitmap(CardBackground);
            K2.Image = new Bitmap(CardBackground);
            K3.Image = new Bitmap(CardBackground);
            K4.Image = new Bitmap(CardBackground);
            K5.Image = new Bitmap(CardBackground);
            K6.Image = new Bitmap(CardBackground);
            K7.Image = new Bitmap(CardBackground);
            K8.Image = new Bitmap(CardBackground);
            K9.Image = new Bitmap(CardBackground);
            K10.Image = new Bitmap(CardBackground);
            K11.Image = new Bitmap(CardBackground);
            K12.Image = new Bitmap(CardBackground);
            BankPic.Image = new Bitmap(CardBackground);
            DebugBank.Text = null;
            DebugText.Text = null;
            DebugText2.Text = null;
            FirstRound = true;
            GameEndet = false;
            isBet = false;
            Points = 0;
            BankPoints = 0;
            counter = 0;
            if (Guthaben < 1)
            {
                MessageBox.Show("Sie haben Verloren. Spiel Beendet", "BalckJack");
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
