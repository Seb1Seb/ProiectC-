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
        private const string LocatieFisierAlimente = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Alimente.txt";
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
            Aliment alimentFound = adminAliment.search(textBox1.Text);
            if (alimentFound != null)
            {
                
                dataGridView1.DataSource = new List<Aliment> { alimentFound }.Select(x => new
                {
                    x.IDuser,
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
