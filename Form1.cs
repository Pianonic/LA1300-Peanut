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
        int AnzahlKarten = 2;
        int Wette = 1;
        int Guthaben = 10;
        string currentdyrectorry = Environment.CurrentDirectory;
        string[] fileArray = Directory.GetFiles(@"C:\Users\nicla\source\repos\LA1300-Peanut\Cards\", "*.png", SearchOption.AllDirectories);

        string filename = null;
        string[] ArrayNames = new string[52];
        string[] ArrayNamesFull = new string[52];
        string[] cache = new string[2];
        int Points = 0;
        int cachePoints = 0;

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
                // using the method
                filename = Path.GetFileName(item);
                ArrayNames[counter] = filename;
                counter++;
            }
            counter = 0;

            foreach (string s in ArrayNames)
            {
                cache = s.Split('_');
                ArrayNamesFull[counter] = cache[0];
                counter++;
            }
            counter = 0;

            rndNum = rnd.Next(fileArray.Length);
            K1.Image = new Bitmap(fileArray[rndNum]);

            try
            {
                Points = Points + Convert.ToInt32(ArrayNamesFull[rndNum]);
                DebugText.Text = Convert.ToString(Points);
                GuthabenZahl.Refresh();
            }
            catch
            {
                if (ArrayNamesFull[rndNum] == "ace")
                {
                    cachePoints = Points;
                    cachePoints = cachePoints + 10;
                    if (cachePoints > 20)
                    {
                        cachePoints = 0;
                        Points++;
                    }
                    else
                    {
                        Points = Points + 10;
                    }
                    DebugText.Text = Convert.ToString(Points);
                    DebugText.Refresh();
                }
                else
                {
                    Points = Points + 10;
                    DebugText.Text = Convert.ToString(Points);
                    DebugText.Refresh();
                }
            }

            rndNum = rnd.Next(fileArray.Length);
            K2.Image = new Bitmap(fileArray[rndNum]);

            try
            {
                Points = Points + Convert.ToInt32(ArrayNamesFull[rndNum]);
                DebugText.Text = Convert.ToString(Points);
                DebugText.Refresh();
            }
            catch
            {
                if (ArrayNamesFull[rndNum] == "ace")
                {
                    cachePoints = Points;
                    cachePoints = cachePoints + 10;
                    if (cachePoints > 20)
                    {
                        cachePoints = 0;
                        Points++;
                    }
                    else
                    {
                        Points = Points + 10;
                    }
                    DebugText.Text = Convert.ToString(Points);
                    DebugText.Refresh();
                }
                else
                {
                    Points = Points + 10;
                    DebugText.Text = Convert.ToString(Points);
                    DebugText.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Points < 20)
            {
                if (counter == 0)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K3.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 1)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K4.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 2)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K5.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 3)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K6.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 4)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K7.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 5)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K8.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 6)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K9.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 7)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K10.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 8)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K11.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                else if (counter == 9)
                {
                    rndNum = rnd.Next(fileArray.Length);
                    K12.Image = new Bitmap(fileArray[rndNum]);
                    DebugText.Text = ArrayNamesFull[rndNum];
                    DebugText.Refresh();
                    counter++;
                }
                try
                {
                    Points = Points + Convert.ToInt32(ArrayNamesFull[rndNum]);
                    DebugText.Text = Convert.ToString(Points);
                    DebugText.Refresh();
                }
                catch
                {
                    if (ArrayNamesFull[rndNum] == "ace")
                    {
                        cachePoints = Points;
                        cachePoints = cachePoints + 10;
                        if (cachePoints > 20)
                        {
                            cachePoints = 0;
                            Points++;
                        }
                        else
                        {
                            Points = Points + 10;
                        }
                        DebugText.Text = Convert.ToString(Points);
                        DebugText.Refresh();
                    }
                    else
                    {
                        Points = Points + 10;
                        DebugText.Text = Convert.ToString(Points);
                        DebugText.Refresh();
                    }
                }
            }
            else if (Points > 20)
            {
                MessageBox.Show("Verloren", "!!! DU GAGGAO !!!");
            }
            else if (Points == 20)
            {
                MessageBox.Show("Gewonnen", "!!! DU GAGGAO !!!");
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
            if (Wette <= Guthaben)
            {
                Guthaben = Guthaben - Wette;
                GuthabenZahl.Text = $"Guthaben: {Guthaben} CHF";
                GuthabenZahl.Refresh();
            }
            else
            {
                WetteZahl.Text = "None!";
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

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Hallo", "Test", buttons);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Wette <= Guthaben / 2)
            {
                Wette = Wette * 2;
                button7_Click(sender, e);
            }
            else
            {
                 MessageBox.Show("zu", "ARM");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

            //DEALER
            int DealerPoints = 18;
            //blackjack
            if (AnzahlKarten == 2)
            {
                if (Points == 21)
                {
                    Guthaben = (2 * Guthaben + 2 * Wette + 3 * Wette) / 2;
                }
            }



            if (Points < DealerPoints || Points > 21)
            {
                Guthaben = Guthaben - Wette;
            }
        }

    }
}
