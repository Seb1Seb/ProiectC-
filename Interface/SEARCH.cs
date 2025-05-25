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

    public partial class SEARCH: MetroForm
    {
        AdministrareFisierIndivizi adminIndivid;
        private string LocatieFisierIndivizi = FisiereTXT.NumeFisierIndivid();
        public SEARCH()
        {
            InitializeComponent();
            textBox1.Text = "Nume";
            textBox2.Text = "Prenume";
            adminIndivid = new AdministrareFisierIndivizi(LocatieFisierIndivizi);
            int nrIndivizi = 0;
            List<Individ> indivizi = adminIndivid.GetIndivizi(out nrIndivizi);
        }

        private void SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
            if (textBox1.Text == "Nume")
            {
                textBox1.Text = "";
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = System.Drawing.Color.Black;
            if (textBox2.Text == "Prenume")
            {
                textBox2.Text = "";
            }
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Nume";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void metroTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "Prenume";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nume")
            {
                textBox1.Text = "";
            }
            if (textBox2.Text == "Prenume")
            {
                textBox2.Text = "";
            }
            List<Individ> individFound = adminIndivid.search(textBox1.Text, textBox2.Text);
            if (individFound != null)
            {
                dataGridView1.DataSource = individFound.Select(x => new
                {
                    x.ID_individ,
                    x.nume,
                    x.prenume
                }).ToList();
            }
            else
            {
                MessageBox.Show("Individ not found.");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
