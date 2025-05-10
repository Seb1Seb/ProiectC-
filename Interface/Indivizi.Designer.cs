namespace Interface
{
    partial class Indivizi
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
            this.GridIndivizi = new System.Windows.Forms.DataGridView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.GridIndivizi)).BeginInit();
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
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Lista Indivizi";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // GridIndivizi
            // 
            this.GridIndivizi.BackgroundColor = System.Drawing.Color.White;
            this.GridIndivizi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIndivizi.Location = new System.Drawing.Point(13, 86);
            this.GridIndivizi.Name = "GridIndivizi";
            this.GridIndivizi.Size = new System.Drawing.Size(660, 489);
            this.GridIndivizi.TabIndex = 3;
            this.GridIndivizi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile2.CustomBackground = true;
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.Location = new System.Drawing.Point(679, 86);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 23);
            this.metroTile2.TabIndex = 4;
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
            this.metroTile3.TabIndex = 5;
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
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "DELETE";
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
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
            // Indivizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.GridIndivizi);
            this.Controls.Add(this.metroTile1);
            this.Name = "Indivizi";
            this.Size = new System.Drawing.Size(757, 590);
            ((System.ComponentModel.ISupportInitialize)(this.GridIndivizi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView GridIndivizi;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}
