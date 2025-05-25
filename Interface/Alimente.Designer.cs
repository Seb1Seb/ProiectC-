namespace Interface
{
    partial class Alimente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.CustomBackground = true;
            this.metroTile1.CustomForeColor = true;
            this.metroTile1.ForeColor = System.Drawing.Color.Brown;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(751, 77);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Lista Alimente";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 489);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile2.CustomBackground = true;
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.Location = new System.Drawing.Point(679, 86);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 23);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "ADD";
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile3.CustomBackground = true;
            this.metroTile3.CustomForeColor = true;
            this.metroTile3.Location = new System.Drawing.Point(679, 144);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(75, 23);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "EDIT";
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroTile4
            // 
            this.metroTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile4.CustomBackground = true;
            this.metroTile4.CustomForeColor = true;
            this.metroTile4.Location = new System.Drawing.Point(679, 202);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 23);
            this.metroTile4.TabIndex = 5;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile5.CustomBackground = true;
            this.metroTile5.CustomForeColor = true;
            this.metroTile5.Location = new System.Drawing.Point(679, 260);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(75, 23);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "REFRESH";
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile7.CustomBackground = true;
            this.metroTile7.CustomForeColor = true;
            this.metroTile7.Location = new System.Drawing.Point(679, 318);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(75, 23);
            this.metroTile7.TabIndex = 9;
            this.metroTile7.Text = "SEARCH";
            this.metroTile7.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // Alimente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Alimente";
            this.Size = new System.Drawing.Size(757, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile7;
    }
}
