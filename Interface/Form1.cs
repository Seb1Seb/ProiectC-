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

        private Label[] lblsNume;
        private Label[] lblsPrenume;

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

            adminAliment = new AdministrareFisierAlimente(LocatieFisierAlimente);
            int nrAlimente = 0;
            Aliment[] alimente = adminAliment.GetAlimente(out nrAlimente);

            lbldenumire = new Label();
            lbldenumire.Width = LATIME_CONTROL;
            lbldenumire.Text = "Denumire";
            lbldenumire.Left = 220;
            lbldenumire.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldenumire);

            lbldata_exp = new Label();
            lbldata_exp.Width = LATIME_CONTROL;
            lbldata_exp.Text = "Data_exp";
            lbldata_exp.Left = 320;
            lbldata_exp.ForeColor = Color.DarkBlue;
            this.Controls.Add(lbldata_exp);

            lblcantitate = new Label();
            lblcantitate.Width = LATIME_CONTROL;
            lblcantitate.Text = "Cantitate";
            lblcantitate.Left = 420;
            lblcantitate.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblcantitate);

            lblgramaj = new Label();
            lblgramaj.Width = LATIME_CONTROL;
            lblgramaj.Text = "Gramaj";
            lblgramaj.Left = 520;
            lblgramaj.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblgramaj);
        }
        private void AfiseazaIndivizi()
        {
            Individ[] indivizi = adminIndivid.GetIndivizi(out int nrIndivizi);

            lblsNume = new Label[nrIndivizi];
            lblsPrenume = new Label[nrIndivizi];

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

            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                lblsdenumire[i] = new Label();
                lblsdenumire[i].Width = LATIME_CONTROL;
                lblsdenumire[i].Text = aliment.denumire;
                lblsdenumire[i].Left = 220;
                lblsdenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdenumire[i]);
                lblsdata_exp[i] = new Label();
                lblsdata_exp[i].Width = LATIME_CONTROL;
                lblsdata_exp[i].Text = aliment.data_exp;
                lblsdata_exp[i].Left = 320;
                lblsdata_exp[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsdata_exp[i]);
                lblscantitate[i] = new Label();
                lblscantitate[i].Width = LATIME_CONTROL;
                lblscantitate[i].Text = aliment.cantitate.ToString();
                lblscantitate[i].Left = 420;
                lblscantitate[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblscantitate[i]);
                lblsgramaj[i] = new Label();
                lblsgramaj[i].Width = LATIME_CONTROL;
                lblsgramaj[i].Text = aliment.gramaj.ToString();
                lblsgramaj[i].Left = 520;
                lblsgramaj[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsgramaj[i]);
                i++;
            }
        }
    }
}
