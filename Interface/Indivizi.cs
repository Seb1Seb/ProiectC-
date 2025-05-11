using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibStocareDate;
using LibrarieModel;

namespace Interface
{
    public partial class Indivizi: UserControl
    {
        List<Individ> listaIndivizi;
        AdministrareFisierIndivizi Xfisier;
        private string numeFisier = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Indivizi.txt";
        public Indivizi()
        {
            InitializeComponent();
            Xfisier = new AdministrareFisierIndivizi(numeFisier);
            listaIndivizi = new List<Individ>();
            listaIndivizi=Xfisier.GetIndivizi(out int nrIndivizi);
            afiseaza_indivizi(listaIndivizi);
        }
        private void afiseaza_indivizi(List<Individ> miculCioban)
        {
            GridIndivizi.DataSource = miculCioban.Select(x => new
            {
                x.IDuser,
                x.nume,
                x.prenume
            }).ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ADD_Individ adaugaIndivid = new ADD_Individ();
            adaugaIndivid.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            listaIndivizi = Xfisier.GetIndivizi(out int nrIndivizi);
            afiseaza_indivizi(listaIndivizi);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            SEARCH search = new SEARCH();
            search.ShowDialog();
        }
    }
}
