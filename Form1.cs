using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button7_Click(object sender, EventArgs e)
        {
            Count++;
            GuthabenZahl.Text = $"Guthaben: {Count} CHF";
        }

        private void MehrWetten_Click(object sender, EventArgs e)
        {
            Wette++;
            WetteZahl.Text = Convert.ToString(Wette);
        }
        private void WenigerWetten_Click(object sender, EventArgs e)
        {
            Wette++;
            WetteZahl.Text = Convert.ToString(Wette);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuthabenZahl.BackColor = System.Drawing.Color.Transparent;
            WetteZahl.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
