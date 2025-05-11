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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface
{
    public partial class ADD_Aliment: MetroForm
    {
        AdministrareFisierAlimente adminAliment;
        public ADD_Aliment()
        {
            InitializeComponent();
            textBox3.Text = "Denumire";
            textBox4.Text = "Data_exp";
            textBox5.Text = "Cantitate";
            textBox6.Text = "Gramaj";
        }

        private void ADD_Aliment_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = System.Drawing.Color.Black;
            if (textBox3.Text == "Denumire")
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.ForeColor = System.Drawing.Color.Black;
            if (textBox4.Text == "Data_exp")
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.ForeColor = System.Drawing.Color.Black;
            if (textBox5.Text == "Cantitate")
            {
                textBox5.Text = "";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.ForeColor = System.Drawing.Color.Black;
            if (textBox6.Text == "Gramaj")
            {
                textBox6.Text = "";
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxValid(textBox3))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBox3.Text != "Denumire" && textBox4.Text != "Data_exp")
            {
                int nrAliment = 0;
                List<Aliment> alimente = adminAliment.GetAlimente(out nrAliment);

                string denumireBox = textBox3.Text;
                string data_expBox = textBox4.Text;
                int cantitateBox = Convert.ToInt32(textBox5.Text);
                float gramajBox = Convert.ToSingle(textBox6.Text);
                Aliment aliment = new Aliment(denumireBox, data_expBox, cantitateBox, gramajBox, 1);
                adminAliment.AddAliment(aliment, ref nrAliment);

                textBox3.Text = "Denumire";
                textBox3.ForeColor = System.Drawing.Color.Gray;
                textBox4.Text = "Data_exp";
                textBox4.ForeColor = System.Drawing.Color.Gray;
            }
            if (textBoxValid(textBox3))
            {
                textBox3.Text = "Denumire";
                textBox3.ForeColor = System.Drawing.Color.Gray;
            }
            if (textBoxValid(textBox4))
            {
                textBox4.Text = "Data_exp";
                textBox4.ForeColor = System.Drawing.Color.Gray;
            }

            textBox5.Text = "Cantitate";
            textBox5.ForeColor = System.Drawing.Color.Gray;
            textBox6.Text = "Gramaj";
            textBox6.ForeColor = System.Drawing.Color.Gray;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "Denumire";
                textBox3.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = "Data_exp";
                textBox4.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Text = "Cantitate";
                textBox5.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Text = "Gramaj";
                textBox6.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
