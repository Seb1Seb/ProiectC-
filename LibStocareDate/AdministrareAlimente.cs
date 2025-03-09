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
        public AdministrareAlimente()
        {
            aliment = new Aliment[nr_max];
            nr_alimente = 0;
        }
        public void AddAliment(Aliment produs)
        {
            aliment[nr_alimente++] = produs;
        }
        public void AfisareAlimente()
        {
            for (int i = 0; i < nr_alimente; i++)
                Console.WriteLine(aliment[i].toStr());
        }
    }
}
