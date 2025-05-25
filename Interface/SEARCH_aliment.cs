using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModel;
using LibStocareDate;
using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class SEARCH_aliment: MetroForm
    {
        AdministrareFisierAlimente adminAliment;
        private string LocatieFisierAlimente = FisiereTXT.NumeFisierAlimente();
        public SEARCH_aliment()
        {
            InitializeComponent();
            textBox1.Text = "Denumire";
            adminAliment = new AdministrareFisierAlimente(LocatieFisierAlimente);
            int nrAlimente = 0;
            List<Aliment> alimente = adminAliment.GetAlimente(out nrAlimente);
        }

        private void SEARCH_aliment_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
            if (textBox1.Text == "Denumire")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Denumire";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            List<Aliment> alimentFound = adminAliment.search(textBox1.Text);
            if (alimentFound != null)
            {
                
                dataGridView1.DataSource = alimentFound.Select(x => new
                {
                    x.ID_aliment,
                    x.denumire,
                    x.data_exp,
                    x.cantitate,
                    x.gramaj,
                    x.tipAliment
                }).ToList();
            }
            else
            {
                MessageBox.Show("Aliment not found.");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
