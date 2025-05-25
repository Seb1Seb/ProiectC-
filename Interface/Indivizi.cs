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
        AdministrareFisierIndivizi admin;
        private string numeFisier = FisiereTXT.NumeFisierIndivid();
        public Indivizi()
        {
            InitializeComponent();
            admin = new AdministrareFisierIndivizi(numeFisier);
            listaIndivizi = new List<Individ>();
            listaIndivizi=admin.GetIndivizi(out int nrIndivizi);
            afiseaza_indivizi(listaIndivizi);
        }
        private void afiseaza_indivizi(List<Individ> miculCioban)
        {
            GridIndivizi.DataSource = miculCioban.Select(x => new
            {
                x.ID_individ,
                x.nume,
                x.prenume,
                x.tipIndivid,
                x.atributeIndivid
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
            listaIndivizi = admin.GetIndivizi(out int nrIndivizi);
            afiseaza_indivizi(listaIndivizi);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            SEARCH search = new SEARCH();
            search.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            EditIndivizi edit = new EditIndivizi(listaIndivizi[GridIndivizi.CurrentRow.Index]);
            edit.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            AtribuireObiecte atribuire = new AtribuireObiecte(listaIndivizi[GridIndivizi.CurrentRow.Index]);
            atribuire.ShowDialog();
        }
    }
}
