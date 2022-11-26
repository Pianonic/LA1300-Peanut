using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA1300_Penut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Wette = 0;
        int Count = 1000;
        string currentdyrectorry = Environment.CurrentDirectory;
        string[] fileArray = Directory.GetFiles(@"C:\Users\nicla\source\repos\LA1300-Peanut\Cards\", "*.png", SearchOption.AllDirectories);

        Random rnd = new Random();
        int rndNum = 0;
        int counter = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                rndNum = rnd.Next(fileArray.Length);
                K3.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 1)
            {
                rndNum = rnd.Next(fileArray.Length);
                K4.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 2)
            {
                rndNum = rnd.Next(fileArray.Length);
                K5.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 3)
            {
                rndNum = rnd.Next(fileArray.Length);
                K6.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 4)
            {
                rndNum = rnd.Next(fileArray.Length);
                K7.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 5)
            {
                rndNum = rnd.Next(fileArray.Length);
                K8.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 6)
            {
                rndNum = rnd.Next(fileArray.Length);
                K9.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 7)
            {
                rndNum = rnd.Next(fileArray.Length);
                K10.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 8)
            {
                rndNum = rnd.Next(fileArray.Length);
                K11.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
            else if (counter == 9)
            {
                rndNum = rnd.Next(fileArray.Length);
                K12.Image = new Bitmap(fileArray[rndNum]);
                counter++;
            }
        }

        private void MehrWetten_Click(object sender, EventArgs e)
        {
            Wette++;
            WetteZahl.Text = Convert.ToString(Wette) + " CHF";
            WetteZahl.Refresh();
        }
        private void WenigerWetten_Click(object sender, EventArgs e)
        {
            Wette++;
            WetteZahl.Text = Convert.ToString(Wette);
            WetteZahl.Refresh();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            GuthabenZahl.BackColor = System.Drawing.Color.Transparent;
            WetteZahl.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            GuthabenZahl.Text = $"Guthaben: {Count} CHF";
            GuthabenZahl.Refresh();

            rndNum = rnd.Next(fileArray.Length);
            K1.Image = new Bitmap(fileArray[rndNum]);

            rndNum = rnd.Next(fileArray.Length);
            K2.Image = new Bitmap(fileArray[rndNum]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GuthabenZahl.Text = currentdyrectorry;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Hallo", "Test", buttons);
        }
    }
}
