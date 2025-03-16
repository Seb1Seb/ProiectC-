using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModel;

namespace LibStocareDate
{
    public class AdministrareFisierIndivizi
    {
        private const int nr_max = 100;
        public string NumeFisier { get; set; }
        public AdministrareFisierIndivizi(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AddIndivid(Individ persoana)
        {
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(persoana.Conversie_la_sir_fisier());
            }
        }
        public Individ[] GetIndivizi(out int nrIndivizi)
        {
            Individ[] vect = new Individ[nr_max];
            nrIndivizi = 0;
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    vect[nrIndivizi++] = new Individ(line);
                }
            }
            return vect;
        }
    }
}
