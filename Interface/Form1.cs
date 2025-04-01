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
using LibrarieModel;
using LibStocareDate;

namespace Interface
{
    public partial class Form1: Form
    {
        AdministrareFisierAlimente adminAliment;
        AdministrareFisierIndivizi adminIndivid;

        private Label lblNume;
        private Label lblPrenume;
        private Label lblTipIndivid;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsTipIndivid;

        private Label lbldenumire;
        private Label lbldata_exp;
        private Label lblcantitate;
        private Label lblgramaj;
        private Label lbltipAliment;

        private Label[] lblsdenumire;
        private Label[] lblsdata_exp;
        private Label[] lblscantitate;
        private Label[] lblsgramaj;
        private Label[] lblstipAliment;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_X = 20;
        private const int DIMENSIUNE_PAS_Y = 30;

        private const string LocatieFisierIndivizi = "C:\\Users\\arhei\\source\\repos\\ProiectC#\\ProiectC#\\bin\\Debug\\Indivizi.txt";
        private const string LocatieFisierAlimente = "C:\\Users\\arhei\\source\\repos\\ProiectC#\\ProiectC#\\bin\\Debug\\Alimente.txt";

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
            Individ[] indivizi = adminIndivid.GetIndivizi(out nrIndivizi);

            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            lblNume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblNume);

            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = 120;
            lblPrenume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblPrenume);

            lblTipIndivid = new Label();
            lblTipIndivid.Width = LATIME_CONTROL;
            lblTipIndivid.Text = "Tip Individ";
            lblTipIndivid.Left = 220;
            lblTipIndivid.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblTipIndivid);

            adminAliment = new AdministrareFisierAlimente(LocatieFisierAlimente);
            int nrAlimente = 0;
            Aliment[] alimente = adminAliment.GetAlimente(out nrAlimente);

            lbldenumire = new Label();
            lbldenumire.Width = LATIME_CONTROL;
            lbldenumire.Text = "Denumire";
            lbldenumire.Left = 320;
            lbldenumire.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldenumire);

            lbldata_exp = new Label();
            lbldata_exp.Width = LATIME_CONTROL;
            lbldata_exp.Text = "Data_exp";
            lbldata_exp.Left = 420;
            lbldata_exp.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldata_exp);

            lblcantitate = new Label();
            lblcantitate.Width = LATIME_CONTROL;
            lblcantitate.Text = "Cantitate";
            lblcantitate.Left = 520;
            lblcantitate.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblcantitate);

            lblgramaj = new Label();
            lblgramaj.Width = LATIME_CONTROL;
            lblgramaj.Text = "Gramaj";
            lblgramaj.Left = 620;
            lblgramaj.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblgramaj);

            lbltipAliment = new Label();
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
            Individ[] indivizi = adminIndivid.GetIndivizi(out int nrIndivizi);

            lblsNume = new Label[nrIndivizi];
            lblsPrenume = new Label[nrIndivizi];
            lblsTipIndivid = new Label[nrIndivizi];

            int i = 0;
            foreach (Individ individ in indivizi)
            {
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = individ.nume;
                lblsNume[i].Left = DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = individ.prenume;
                lblsPrenume[i].Left = 120;
                lblsPrenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                lblsTipIndivid[i] = new Label();
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
            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);

            lblsdenumire = new Label[nrAlimente];
            lblsdata_exp = new Label[nrAlimente];
            lblscantitate = new Label[nrAlimente];
            lblsgramaj = new Label[nrAlimente];
            lblstipAliment = new Label[nrAlimente];

            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                lblsdenumire[i] = new Label();
                lblsdenumire[i].Width = LATIME_CONTROL;
                lblsdenumire[i].Text = aliment.denumire;
                lblsdenumire[i].Left = 320;
                lblsdenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdenumire[i]);

                lblsdata_exp[i] = new Label();
                lblsdata_exp[i].Width = LATIME_CONTROL;
                lblsdata_exp[i].Text = aliment.data_exp;
                lblsdata_exp[i].Left = 420;
                lblsdata_exp[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdata_exp[i]);

                lblscantitate[i] = new Label();
                lblscantitate[i].Width = LATIME_CONTROL;
                lblscantitate[i].Text = aliment.cantitate.ToString();
                lblscantitate[i].Left = 520;
                lblscantitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblscantitate[i]);

                lblsgramaj[i] = new Label();
                lblsgramaj[i].Width = LATIME_CONTROL;
                lblsgramaj[i].Text = aliment.gramaj.ToString();
                lblsgramaj[i].Left = 620;
                lblsgramaj[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsgramaj[i]);

                lblstipAliment[i] = new Label();
                lblstipAliment[i].Width = LATIME_CONTROL;
                lblstipAliment[i].Text = aliment.tipAliment.ToString();
                lblstipAliment[i].Left = 720;
                lblstipAliment[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblstipAliment[i]);

                i++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                Individ[] indivizi = adminIndivid.GetIndivizi(out nrIndivizi);

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
            if (textBoxValid(textBox4))
            {
                MessageBox.Show("Invalid data.");
            }
            else
            if (textBox1.Text != "Denumire" && textBox2.Text != "Data_exp")
            {
                int nrAliment = 0;
                Aliment[] alimente = adminAliment.GetAlimente(out nrAliment);

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
        private bool textBoxValid(TextBox textBox)
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
            // Only clear the text when the user starts typing
            if (textBox1.Text == "Nume")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = System.Drawing.Color.Black;
            // Only clear the text when the user starts typing
            if (textBox2.Text == "Prenume")
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.ForeColor = System.Drawing.Color.Black;
            // Only clear the text when the user starts typing
            if (textBox3.Text == "Denumire")
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.ForeColor = System.Drawing.Color.Black;
            // Only clear the text when the user starts typing
            if (textBox4.Text == "Data_exp")
            {
                textBox4.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.ForeColor = System.Drawing.Color.Black;
            // Only clear the text when the user starts typing
            if (textBox5.Text == "Cantitate")
            {
                textBox5.Text = "";
            }
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.ForeColor = System.Drawing.Color.Black;
            // Only clear the text when the user starts typing
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
    }
}
