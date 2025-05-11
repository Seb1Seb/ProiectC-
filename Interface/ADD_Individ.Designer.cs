namespace Interface
{
    partial class ADD_Individ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.NoneBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.InaltBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.ScundBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.SlabBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.GrasBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.SanatosBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.BolnavBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(23, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(24, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.metroRadioButton1.CustomBackground = true;
            this.metroRadioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroRadioButton1.Location = new System.Drawing.Point(24, 124);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(82, 15);
            this.metroRadioButton1.TabIndex = 16;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "MASCULIN";
            this.metroRadioButton1.UseVisualStyleBackColor = false;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.BackColor = System.Drawing.Color.MediumPurple;
            this.metroRadioButton2.CustomBackground = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(112, 124);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButton2.TabIndex = 17;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "FEMININ";
            this.metroRadioButton2.UseVisualStyleBackColor = false;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.BackColor = System.Drawing.Color.MediumPurple;
            this.metroRadioButton3.CustomBackground = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(188, 124);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(67, 15);
            this.metroRadioButton3.TabIndex = 18;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "CHESTIE";
            this.metroRadioButton3.UseVisualStyleBackColor = false;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SlateBlue;
            this.metroPanel1.Controls.Add(this.BolnavBox7);
            this.metroPanel1.Controls.Add(this.SanatosBox6);
            this.metroPanel1.Controls.Add(this.GrasBox5);
            this.metroPanel1.Controls.Add(this.SlabBox4);
            this.metroPanel1.Controls.Add(this.ScundBox3);
            this.metroPanel1.Controls.Add(this.InaltBox2);
            this.metroPanel1.Controls.Add(this.NoneBox1);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroRadioButton3);
            this.metroPanel1.Controls.Add(this.metroRadioButton2);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.Controls.Add(this.textBox2);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(312, 241);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Tomato;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(285, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(27, 24);
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "X";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // NoneBox1
            // 
            this.NoneBox1.AutoSize = true;
            this.NoneBox1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.NoneBox1.Location = new System.Drawing.Point(238, 169);
            this.NoneBox1.Name = "NoneBox1";
            this.NoneBox1.Size = new System.Drawing.Size(56, 15);
            this.NoneBox1.TabIndex = 20;
            this.NoneBox1.Text = "NONE";
            this.NoneBox1.UseVisualStyleBackColor = true;
            // 
            // InaltBox2
            // 
            this.InaltBox2.AutoSize = true;
            this.InaltBox2.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.InaltBox2.Location = new System.Drawing.Point(168, 190);
            this.InaltBox2.Name = "InaltBox2";
            this.InaltBox2.Size = new System.Drawing.Size(56, 15);
            this.InaltBox2.TabIndex = 21;
            this.InaltBox2.Text = "INALT";
            this.InaltBox2.UseVisualStyleBackColor = true;
            // 
            // ScundBox3
            // 
            this.ScundBox3.AutoSize = true;
            this.ScundBox3.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.ScundBox3.Location = new System.Drawing.Point(168, 169);
            this.ScundBox3.Name = "ScundBox3";
            this.ScundBox3.Size = new System.Drawing.Size(64, 15);
            this.ScundBox3.TabIndex = 22;
            this.ScundBox3.Text = "SCUND";
            this.ScundBox3.UseVisualStyleBackColor = true;
            // 
            // SlabBox4
            // 
            this.SlabBox4.AutoSize = true;
            this.SlabBox4.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.SlabBox4.Location = new System.Drawing.Point(106, 190);
            this.SlabBox4.Name = "SlabBox4";
            this.SlabBox4.Size = new System.Drawing.Size(52, 15);
            this.SlabBox4.TabIndex = 23;
            this.SlabBox4.Text = "SLAB";
            this.SlabBox4.UseVisualStyleBackColor = true;
            // 
            // GrasBox5
            // 
            this.GrasBox5.AutoSize = true;
            this.GrasBox5.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.GrasBox5.Location = new System.Drawing.Point(107, 169);
            this.GrasBox5.Name = "GrasBox5";
            this.GrasBox5.Size = new System.Drawing.Size(55, 15);
            this.GrasBox5.TabIndex = 24;
            this.GrasBox5.Text = "GRAS";
            this.GrasBox5.UseVisualStyleBackColor = true;
            // 
            // SanatosBox6
            // 
            this.SanatosBox6.AutoSize = true;
            this.SanatosBox6.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.SanatosBox6.Location = new System.Drawing.Point(23, 190);
            this.SanatosBox6.Name = "SanatosBox6";
            this.SanatosBox6.Size = new System.Drawing.Size(77, 15);
            this.SanatosBox6.TabIndex = 25;
            this.SanatosBox6.Text = "SANATOS";
            this.SanatosBox6.UseVisualStyleBackColor = true;
            // 
            // BolnavBox7
            // 
            this.BolnavBox7.AutoSize = true;
            this.BolnavBox7.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.BolnavBox7.Location = new System.Drawing.Point(24, 169);
            this.BolnavBox7.Name = "BolnavBox7";
            this.BolnavBox7.Size = new System.Drawing.Size(70, 15);
            this.BolnavBox7.TabIndex = 26;
            this.BolnavBox7.Text = "BOLNAV";
            this.BolnavBox7.UseVisualStyleBackColor = true;
            // 
            // ADD_Individ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 237);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ADD_Individ";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.ADD_Individ_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroCheckBox ScundBox3;
        private MetroFramework.Controls.MetroCheckBox InaltBox2;
        private MetroFramework.Controls.MetroCheckBox NoneBox1;
        private MetroFramework.Controls.MetroCheckBox SlabBox4;
        private MetroFramework.Controls.MetroCheckBox BolnavBox7;
        private MetroFramework.Controls.MetroCheckBox SanatosBox6;
        private MetroFramework.Controls.MetroCheckBox GrasBox5;
    }
}