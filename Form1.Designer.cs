namespace LA1300_Penut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuthabenZahl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.WenigerWetten = new System.Windows.Forms.Button();
            this.MehrWetten = new System.Windows.Forms.Button();
            this.WetteZahl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.panel1.Controls.Add(this.GuthabenZahl);
            this.panel1.Location = new System.Drawing.Point(361, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 81);
            this.panel1.TabIndex = 0;
            // 
            // GuthabenZahl
            // 
            this.GuthabenZahl.AutoSize = true;
            this.GuthabenZahl.BackColor = System.Drawing.Color.SaddleBrown;
            this.GuthabenZahl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuthabenZahl.ForeColor = System.Drawing.SystemColors.Control;
            this.GuthabenZahl.Location = new System.Drawing.Point(23, 17);
            this.GuthabenZahl.Name = "GuthabenZahl";
            this.GuthabenZahl.Size = new System.Drawing.Size(324, 54);
            this.GuthabenZahl.TabIndex = 0;
            this.GuthabenZahl.Text = "Guthaben: 0 CHF";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.WenigerWetten);
            this.panel2.Controls.Add(this.MehrWetten);
            this.panel2.Controls.Add(this.WetteZahl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 242);
            this.panel2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(3, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 41);
            this.button8.TabIndex = 4;
            this.button8.Text = "Setzen";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // WenigerWetten
            // 
            this.WenigerWetten.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.WenigerWetten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WenigerWetten.ForeColor = System.Drawing.SystemColors.Control;
            this.WenigerWetten.Location = new System.Drawing.Point(26, 144);
            this.WenigerWetten.Name = "WenigerWetten";
            this.WenigerWetten.Size = new System.Drawing.Size(112, 34);
            this.WenigerWetten.TabIndex = 3;
            this.WenigerWetten.Text = "-";
            this.WenigerWetten.UseVisualStyleBackColor = true;
            this.WenigerWetten.Click += new System.EventHandler(this.WenigerWetten_Click);
            // 
            // MehrWetten
            // 
            this.MehrWetten.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.MehrWetten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MehrWetten.ForeColor = System.Drawing.SystemColors.Control;
            this.MehrWetten.Location = new System.Drawing.Point(26, 56);
            this.MehrWetten.Name = "MehrWetten";
            this.MehrWetten.Size = new System.Drawing.Size(112, 34);
            this.MehrWetten.TabIndex = 2;
            this.MehrWetten.Text = "+";
            this.MehrWetten.UseVisualStyleBackColor = true;
            this.MehrWetten.Click += new System.EventHandler(this.MehrWetten_Click);
            // 
            // WetteZahl
            // 
            this.WetteZahl.AutoSize = true;
            this.WetteZahl.BackColor = System.Drawing.Color.SaddleBrown;
            this.WetteZahl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WetteZahl.ForeColor = System.Drawing.SystemColors.Control;
            this.WetteZahl.Location = new System.Drawing.Point(51, 102);
            this.WetteZahl.Name = "WetteZahl";
            this.WetteZahl.Size = new System.Drawing.Size(78, 32);
            this.WetteZahl.TabIndex = 1;
            this.WetteZahl.Text = "0 CHF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wette";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1367, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Leave";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(272, 601);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 176);
            this.panel3.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(777, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 117);
            this.button7.TabIndex = 3;
            this.button7.Text = "+ Karte";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(534, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 117);
            this.button6.TabIndex = 2;
            this.button6.Text = "Stay";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(289, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 117);
            this.button5.TabIndex = 1;
            this.button5.Text = "Split";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(47, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 117);
            this.button4.TabIndex = 0;
            this.button4.Text = "Double";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.BackgroundImage = global::LA1300_Penut.Properties.Resources.Wood;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(1367, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 90);
            this.button9.TabIndex = 4;
            this.button9.Text = "Anleitung";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LA1300_Penut.Properties.Resources.Billiard;
            this.ClientSize = new System.Drawing.Size(1567, 827);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button WenigerWetten;
        private System.Windows.Forms.Button MehrWetten;
        private System.Windows.Forms.Label WetteZahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label GuthabenZahl;
        private System.Windows.Forms.Button button9;
    }
}
