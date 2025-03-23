using LibrarieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStocareDate
{
    public class AdministrareAlimente
    {
        private const int nr_max = 100;
        private int nr_alimente;
        private Aliment[] aliment;
        public AdministrareAlimente()//constructor
        {
            aliment = new Aliment[nr_max];
            nr_alimente = 0;
        }
        public void AddAliment(Aliment produs)//adaugare aliment in vector
        {
            aliment[nr_alimente++] = produs;
        }
        public Aliment search(string denumire)//cautare dupa denumire
        {
            for (int i = 0; i < nr_alimente; i++)
                if (aliment[i].denumire == denumire)
                {
                    return aliment[i];
                }
            return null;
        }
    }
}
