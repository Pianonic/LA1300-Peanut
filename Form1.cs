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
        int WetteZwischenSp = 0;
        double Guthaben = 10;
        string currentdyrectorry = Environment.CurrentDirectory;
        string[] fileArray = Directory.GetFiles(@"C:\Users\nicla\source\repos\LA1300-Peanut\Cards\", "*.png", SearchOption.AllDirectories);
        string CardBackground = @"C:\Users\nicla\source\repos\LA1300-Peanut\Bilder\CardBackground.png";

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

        //karte aufnehmen
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
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack - Mitteilung");
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
        //Leave
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

        //setzen
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
                        cache[0] = fileArray[rndNum];
                        AddPoints();

                        rndNum = rnd.Next(fileArray.Length);
                        K2.Image = new Bitmap(fileArray[rndNum]);
                        cache[1] = fileArray[rndNum];
                        AddPoints();

                        

                        if (Points == 21)
                        {
                            MessageBox.Show("Sie haben BlackJack", "BalckJack - Mitteilung");
                            Guthaben = Guthaben + Wette + (1.5 * Wette);
                            GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                            GuthabenZahl.Refresh();
                            Wette = 0;
                        }

                        FirstRound = false;
                    }
                    isBet = true;
                    isClick = false;
                    WetteZwischenSp = Wette;
                }
            }
            else
            {
                MessageBox.Show("Sie können nicht mehr wetten!", "BlackJack - Mitteilung");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Zuerst platzieren Sie Ihren Einsatz.  \r\n2. Der Dealer teilt jedem Spieler zwei Karten und sich selbst zwei Karten aus, eine nach oben, eine nach unten.  \r\n3. Der Spieler mit der höchsten Karte erhält den Dealer-Button und beginnt.  \r\n4. Der erste Spieler hat die Option, zu Hit (eine Karte ziehen) oder zu Stand (keine Karte ziehen).  \r\n5. Der Spieler kann auch Doubledown, Split oder Surrender wählen, wenn er die entsprechenden Karten erhält. \r\n6. Nachdem der erste Spieler fertig ist, geht das Spiel weiter, bis alle Spieler ihre Hände abgeschlossen haben. \r\n7. Der Dealer dreht dann die untere Karte um und entscheidet, ob er Hit oder Stand wählt.  \r\n8. Der Dealer muss Hit nehmen, wenn seine Gesamtsumme weniger als 17 beträgt. Er muss Stand nehmen, wenn seine Gesamtsumme 17 oder mehr beträgt.  \r\n9. Nachdem der Dealer seine Hand abgeschlossen hat, werden alle Spielerhände mit der Hand des Dealers verglichen.  \r\n10. Wenn die Hand des Spielers höher ist als die des Dealers, gewinnt der Spieler. Wenn die Hand des Dealers höher ist, gewinnt der Dealer. Wenn es ein Unentschieden gibt, erhält der Spieler seinen Einsatz zurück.", "BlackJack - Anleitung");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isBet)
            {
                if (WetteZwischenSp <= Guthaben)
                {
                    Guthaben = Guthaben - WetteZwischenSp;
                    WetteZwischenSp = WetteZwischenSp * 2;
                    GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                    GuthabenZahl.Refresh();
                    button7_Click(sender, e);
                    isBet = true;
                    Wette = WetteZwischenSp;
                    button6_Click(sender, e);
                    WetteZwischenSp = 0;
                }
                else
                {
                    MessageBox.Show("Sie haben zu wenig Geld", "BlackJack - Mitteilung");
                }
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack - Mitteilung");
            }
        }

        //Stay
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
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack - Mitteilung");
            }
        }

        //Split
        private void SplitB_Click(object sender, EventArgs e)
        {
            if (isBet)
            {
                MessageBox.Show("Sie können diesen Button nicht betätigen.", "BlackJack - Mitteilung");
                if (cache[0] == cache[1])
                {
                    MessageBox.Show("Leeres Feld wurde generiert.", "BlackJack - Mitteilung");
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Sie müssen zuerst wetten!", "BlackJack - Mitteilung");
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
                MessageBox.Show("Sie haben kein Geld mehr. Spiel Beendet", "BlackJack - Mitteilung");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
