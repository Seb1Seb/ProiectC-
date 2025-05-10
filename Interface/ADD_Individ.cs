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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Interface
{
    public partial class ADD_Individ: MetroForm
    {
        AdministrareFisierIndivizi adminIndivid;
        private const string LocatieFisierIndivizi = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Indivizi.txt";
        public ADD_Individ()
        {
            InitializeComponent();
            textBox1.Text = "Nume";
            textBox2.Text = "Prenume";
            adminIndivid = new AdministrareFisierIndivizi(LocatieFisierIndivizi);
            int nrIndivizi = 0;
            List<Individ> indivizi = adminIndivid.GetIndivizi(out nrIndivizi);
        }

        private void ADD_Individ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxValid(textBox1))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBoxValid(textBox2))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBox1.Text != "Nume" && textBox2.Text != "Prenume")
            {
                int nrIndivizi = 0;
                List<Individ> indivizi = adminIndivid.GetIndivizi(out nrIndivizi);

                string numeBox = textBox1.Text;
                string prenumeBox = textBox2.Text;
                Individ individ = new Individ(numeBox, prenumeBox, 1, "Inalt");
                adminIndivid.AddIndivid(individ, ref nrIndivizi);

                textBox1.Text = "Nume";
                textBox1.ForeColor = System.Drawing.Color.Gray;
                textBox2.Text = "Prenume";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
            if (textBoxValid(textBox1))
            {
                textBox1.Text = "Nume";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
            if (textBoxValid(textBox2))
            {
                textBox2.Text = "Prenume";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private bool textBoxValid(MetroTextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^a-zA-Z]"))
            {
                return true;
            }
            if (textBox.Text.Length > 12)
            {
                return true;
            }
            return false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValid(textBox1))
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                if (textBox1.Text != "Nume")
                    textBox1.ForeColor = Color.Black;
                if (textBox1.Text == "Nume")
                    textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValid(textBox2))
            {
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                if (textBox2.Text != "Prenume")
                    textBox2.ForeColor = Color.Black;
                if (textBox2.Text == "Prenume")
                    textBox2.ForeColor = Color.Gray;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
            if (textBox1.Text == "Nume")
            {
                textBox1.Text = "";
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = System.Drawing.Color.Black;
            if (textBox2.Text == "Prenume")
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Nume";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "Prenume";
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
