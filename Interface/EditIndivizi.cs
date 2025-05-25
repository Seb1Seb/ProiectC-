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
    public partial class EditIndivizi: MetroForm
    {
        AdministrareFisierIndivizi adminIndivizi;
        Individ userNou;
        public EditIndivizi(Individ individ)
        {
            InitializeComponent();
            adminIndivizi = new AdministrareFisierIndivizi(FisiereTXT.NumeFisierIndivid());
            userNou = individ;
            initializeaza();
        }
        private void initializeaza()
        {
            textBox1.Text = userNou.nume;
            textBox2.Text = userNou.prenume;
            if (userNou.tipIndivid == tipIndivizi.masculin)
            {
                metroRadioButton1.Checked = true;
            }
            else
                if (userNou.tipIndivid == tipIndivizi.feminin)
            {
                metroRadioButton2.Checked = true;
            }
            else
            {
                metroRadioButton3.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.none))
            {
                NoneBox1.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Inalt))
            {
                InaltBox2.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Scund))
            {
                ScundBox3.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Gras))
            {
                GrasBox5.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Slab))
            {
                SlabBox4.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Bolnav))
            {
                BolnavBox7.Checked = true;
            }
            if (userNou.atributeIndivid.HasFlag(atributeIndivizi.Sanatos))
            {
                SanatosBox6.Checked = true;
            }
        }

        private void EditIndivizi_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gen;
            if (metroRadioButton1.Checked)
            {
                gen = 1;
            }
            else
                if (metroRadioButton2.Checked)
            {
                gen = 2;
            }
            else
            {
                gen = 3;
            }
            if (textBoxValid(textBox1))
            {
                MessageBox.Show("Invalid data.");
            }
            atributeIndivizi atribute = atributeIndivizi.none;
            if (NoneBox1.Checked)
            {
                atribute |= atributeIndivizi.none;
            }
            if (InaltBox2.Checked)
            {
                atribute |= atributeIndivizi.Inalt;
            }
            else
            if (ScundBox3.Checked)
            {
                atribute |= atributeIndivizi.Scund;
            }
            if (SlabBox4.Checked)
            {
                atribute |= atributeIndivizi.Slab;
            }
            else
            if (GrasBox5.Checked)
            {
                atribute |= atributeIndivizi.Gras;
            }
            if (SanatosBox6.Checked)
            {
                atribute |= atributeIndivizi.Sanatos;
            }
            else
            if (BolnavBox7.Checked)
            {
                atribute |= atributeIndivizi.Bolnav;
            }
            if (textBoxValid(textBox2))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBox1.Text != "Nume" && textBox2.Text != "Prenume")
            {
                string numeBox = textBox1.Text;
                string prenumeBox = textBox2.Text;
                //Individ individ = new Individ(numeBox, prenumeBox, gen, atribute.ToString());
                userNou.nume = numeBox;
                userNou.prenume = prenumeBox;
                userNou.tipIndivid = (tipIndivizi)gen;
                if (!string.IsNullOrEmpty(atribute.ToString()))
                {
                    userNou.atributeIndivid = atributeIndivizi.none;
                    foreach (var value in atribute.ToString().Split(','))
                    {
                        if (Enum.TryParse(value, out atributeIndivizi parsedValue))
                        {
                            userNou.atributeIndivid |= parsedValue;
                        }
                    }
                }
                else
                {
                    userNou.atributeIndivid = atributeIndivizi.none;
                }
                adminIndivizi.editIndivid(userNou);
                this.Close();


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
            adminIndivizi.editIndivid(userNou);
            this.Close();
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

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
