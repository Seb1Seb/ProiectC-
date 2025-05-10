using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using LibrarieModel;
using LibStocareDate;

namespace Interface
{
    public partial class Form1: MetroForm
    {
        AdministrareFisierAlimente adminAliment;
        AdministrareFisierIndivizi adminIndivid;

        private MetroLabel lblNume;
        private MetroLabel lblPrenume;
        private MetroLabel lblTipIndivid;

        private MetroLabel[] lblsNume;
        private MetroLabel[] lblsPrenume;
        private MetroLabel[] lblsTipIndivid;

        private MetroLabel lbldenumire;
        private MetroLabel lbldata_exp;
        private MetroLabel lblcantitate;
        private MetroLabel lblgramaj;
        private MetroLabel lbltipAliment;

        private MetroLabel[] lblsdenumire;
        private MetroLabel[] lblsdata_exp;
        private MetroLabel[] lblscantitate;
        private MetroLabel[] lblsgramaj;
        private MetroLabel[] lblstipAliment;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_X = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        
        private const string LocatieFisierIndivizi = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Indivizi.txt";
        private const string LocatieFisierAlimente = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Alimente.txt";

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(1680, 920);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii Generale";

            adminIndivid = new AdministrareFisierIndivizi(LocatieFisierIndivizi);
            int nrIndivizi = 0;
            List<Individ> indivizi = adminIndivid.GetIndivizi(out nrIndivizi);

            lblNume = new MetroLabel();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblNume);

            lblPrenume = new MetroLabel();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = 120;
            lblPrenume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblPrenume);

            lblTipIndivid = new MetroLabel();
            lblTipIndivid.Width = LATIME_CONTROL;
            lblTipIndivid.Text = "Tip Individ";
            lblTipIndivid.Left = 220;
            lblTipIndivid.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblTipIndivid);

            adminAliment = new AdministrareFisierAlimente(LocatieFisierAlimente);
            int nrAlimente = 0;
            List<Aliment> alimente = adminAliment.GetAlimente(out nrAlimente);

            lbldenumire = new MetroLabel();
            lbldenumire.Width = LATIME_CONTROL;
            lbldenumire.Text = "Denumire";
            lbldenumire.Left = 320;
            lbldenumire.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldenumire);

            lbldata_exp = new MetroLabel();
            lbldata_exp.Width = LATIME_CONTROL;
            lbldata_exp.Text = "Data_exp";
            lbldata_exp.Left = 420;
            lbldata_exp.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldata_exp);

            lblcantitate = new MetroLabel();
            lblcantitate.Width = LATIME_CONTROL;
            lblcantitate.Text = "Cantitate";
            lblcantitate.Left = 520;
            lblcantitate.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblcantitate);

            lblgramaj = new MetroLabel();
            lblgramaj.Width = LATIME_CONTROL;
            lblgramaj.Text = "Gramaj";
            lblgramaj.Left = 620;
            lblgramaj.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblgramaj);

            lbltipAliment = new MetroLabel();
            lbltipAliment.Width = LATIME_CONTROL;
            lbltipAliment.Text = "Tip Aliment";
            lbltipAliment.Left = 720;
            lbltipAliment.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbltipAliment);

            textBox1.Text = "Nume";
            textBox2.Text = "Prenume";
            textBox3.Text = "Denumire";
            textBox4.Text = "Data_exp";
            textBox5.Text = "Cantitate";
            textBox6.Text = "Gramaj";
        }
        private void AfiseazaIndivizi()
        {
            List<Individ> indivizi = adminIndivid.GetIndivizi(out int nrIndivizi);

            lblsNume = new MetroLabel[nrIndivizi];
            lblsPrenume = new MetroLabel[nrIndivizi];
            lblsTipIndivid = new MetroLabel[nrIndivizi];

            int i = 0;
            foreach (Individ individ in indivizi)
            {
                lblsNume[i] = new MetroLabel();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = individ.nume;
                lblsNume[i].Left = DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new MetroLabel();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = individ.prenume;
                lblsPrenume[i].Left = 120;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                lblsTipIndivid[i] = new MetroLabel();
                lblsTipIndivid[i].Width = LATIME_CONTROL;
                lblsTipIndivid[i].Text = individ.tipIndivid.ToString();
                lblsTipIndivid[i].Left = 220;
                lblsTipIndivid[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTipIndivid[i]);

                i++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaIndivizi();
            AfiseazaAlimente();
        }
        private void AfiseazaAlimente()
        {
            List<Aliment> alimente = adminAliment.GetAlimente(out int nrAlimente);

            lblsdenumire = new MetroLabel[nrAlimente];
            lblsdata_exp = new MetroLabel[nrAlimente];
            lblscantitate = new MetroLabel[nrAlimente];
            lblsgramaj = new MetroLabel[nrAlimente];
            lblstipAliment = new MetroLabel[nrAlimente];

            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                lblsdenumire[i] = new MetroLabel();
                lblsdenumire[i].Width = LATIME_CONTROL;
                lblsdenumire[i].Text = aliment.denumire;
                lblsdenumire[i].Left = 320;
                lblsdenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdenumire[i]);

                lblsdata_exp[i] = new MetroLabel();
                lblsdata_exp[i].Width = LATIME_CONTROL;
                lblsdata_exp[i].Text = aliment.data_exp;
                lblsdata_exp[i].Left = 420;
                lblsdata_exp[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdata_exp[i]);

                lblscantitate[i] = new MetroLabel();
                lblscantitate[i].Width = LATIME_CONTROL;
                lblscantitate[i].Text = aliment.cantitate.ToString();
                lblscantitate[i].Left = 520;
                lblscantitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblscantitate[i]);

                lblsgramaj[i] = new MetroLabel();
                lblsgramaj[i].Width = LATIME_CONTROL;
                lblsgramaj[i].Text = aliment.gramaj.ToString();
                lblsgramaj[i].Left = 620;
                lblsgramaj[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsgramaj[i]);

                lblstipAliment[i] = new MetroLabel();
                lblstipAliment[i].Width = LATIME_CONTROL;
                lblstipAliment[i].Text = aliment.tipAliment.ToString();
                lblstipAliment[i].Left = 720;
                lblstipAliment[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblstipAliment[i]);

                i++;
            }
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
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
                AfiseazaIndivizi();

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

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxValid(textBox3))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBox1.Text != "Denumire" && textBox2.Text != "Data_exp")
            {
                int nrAliment = 0;
                List<Aliment> alimente = adminAliment.GetAlimente(out nrAliment);

                string denumireBox = textBox3.Text;
                string data_expBox = textBox4.Text;
                int cantitateBox = Convert.ToInt32(textBox5.Text);
                float gramajBox = Convert.ToSingle(textBox6.Text);
                Aliment aliment = new Aliment(denumireBox, data_expBox, cantitateBox, gramajBox, 1);
                adminAliment.AddAliment(aliment, ref nrAliment);
                AfiseazaAlimente();

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValid(textBox3))
            {
                textBox3.ForeColor = Color.Red;
            }
            else
            {
                if (textBox3.Text != "Denumire")
                    textBox3.ForeColor = Color.Black;
                if (textBox3.Text == "Denumire")
                    textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
