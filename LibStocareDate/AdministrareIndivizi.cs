using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModel;

namespace LibStocareDate
{
    public class AdministrareIndivizi
    {
        private const int nr_max = 100;
        private int nr_indivizi;
        private Individ[] indivizi;
        public AdministrareIndivizi()
        {
            indivizi = new Individ[nr_max];
            nr_indivizi = 0;
        }
        public void AddIndivid(Individ persoana)
        {
            indivizi[nr_indivizi++] = persoana;
        }
        public void AfisareIndivizi()
        {
            for (int i=0; i < nr_indivizi; i++)
                Console.WriteLine(indivizi[i].toStr());
        }
    }
}
