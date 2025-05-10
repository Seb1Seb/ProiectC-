using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibStocareDate;
using MetroFramework.Forms;

namespace Interface
{
    public partial class Meniu: MetroForm
    {
        Menu meniu;
        Alimente aliment;
        Indivizi individ;
        public Meniu()
        {
            InitializeComponent();
            meniu = new Menu();
            DASHBOARD.Controls.Clear();
            DASHBOARD.Controls.Add(meniu);
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            meniu = new Menu();
            DASHBOARD.Controls.Clear();
            DASHBOARD.Controls.Add(meniu);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            individ = new Indivizi();
            DASHBOARD.Controls.Clear();
            DASHBOARD.Controls.Add(individ);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            aliment = new Alimente();
            DASHBOARD.Controls.Clear();
            DASHBOARD.Controls.Add(aliment);
        }
    }
}
