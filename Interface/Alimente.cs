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
        AdministrareFisierAlimente admin;
        private string numeFisier = FisiereTXT.NumeFisierAlimente();
        public Alimente()
        {
            InitializeComponent();
            listaAlimente = new List<Aliment>();
            admin = new AdministrareFisierAlimente(numeFisier);
            listaAlimente=admin.GetAlimente(out int nrAlimente);
            afiseaza_alimente(listaAlimente);
        }
        private void afiseaza_alimente(List<Aliment> micuCioban)
        {
            dataGridView1.DataSource = micuCioban.Select(x => new
            {
                x.ID_aliment,
                x.denumire,
                x.data_exp,
                x.cantitate,
                x.gramaj,
                x.tipAliment,
                x.ID_individ
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
            listaAlimente = admin.GetAlimente(out int nrAlimente);
            afiseaza_alimente(listaAlimente);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            SEARCH_aliment search = new SEARCH_aliment();
            search.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            List<String> CitateMotivationale = new List<String> {"Timpul trece, banul merge","Cine se trezeste devreme, se trezeste devreme","Sapa multa, industria calului","Turul 2 inapoi","Georgel scaunel n-a iesit presedinte"};
            Random random = new Random();
            int index = random.Next(CitateMotivationale.Count);
            MessageBox.Show(CitateMotivationale[index], "Citat Motivational", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
