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
using MetroFramework.Forms;

namespace Interface
{
    public partial class AtribuireObiecte: MetroForm
    {
        List<Aliment> listaAlimente;
        AdministrareFisierAlimente admin;
        private string numeFisier = FisiereTXT.NumeFisierAlimente();
        Individ individSelectat;
        public AtribuireObiecte(Individ individSelectat)
        {
            InitializeComponent();
            listaAlimente = new List<Aliment>();
            admin = new AdministrareFisierAlimente(numeFisier);
            listaAlimente = admin.GetAlimente(out int nrAlimente);
            afiseaza_alimente(listaAlimente);
            this.individSelectat = individSelectat;
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
                x.tipAliment
            }).ToList();
        }
        private void AtribuireObiecte_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Aliment alimentSelectat = listaAlimente[dataGridView1.CurrentRow.Index];
            alimentSelectat.ID_individ = individSelectat.ID_individ;
            admin.editAliment(alimentSelectat);
        }
    }
}
