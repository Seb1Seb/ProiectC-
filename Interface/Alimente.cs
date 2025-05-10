using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModel;
using LibStocareDate;

namespace Interface
{
    public partial class Alimente: UserControl
    {
        List<Aliment> listaAlimente;
        AdministrareFisierAlimente Xfisier;
        private string numeFisier = "C:\\Users\\arhei\\Source\\Repos\\ProiectC-\\ProiectC#\\bin\\Debug\\Alimente.txt";
        public Alimente()
        {
            InitializeComponent();
            listaAlimente = new List<Aliment>();
            Xfisier = new AdministrareFisierAlimente(numeFisier);
            listaAlimente=Xfisier.GetAlimente(out int nrAlimente);
            afiseaza_alimente(listaAlimente);
        }
        private void afiseaza_alimente(List<Aliment> micuCioban)
        {
            dataGridView1.DataSource = micuCioban.Select(x => new
            {
                x.IDuser,
                x.denumire,
                x.data_exp,
                x.cantitate,
                x.gramaj,
                x.tipAliment
            }).ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ADD_Aliment adaugaIndivid = new ADD_Aliment();
            adaugaIndivid.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            listaAlimente = Xfisier.GetAlimente(out int nrAlimente);
            afiseaza_alimente(listaAlimente);
        }
    }
}
