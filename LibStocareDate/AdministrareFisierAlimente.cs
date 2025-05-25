using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieModel;

namespace LibStocareDate
{
    public class AdministrareFisierAlimente
    {
        private const int nr_max = 100;
        public string NumeFisier { get; set; }
        public AdministrareFisierAlimente(string numeFisier)//constructor
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AddAliment(Aliment aliment, ref int nrAlimente)//adaugare aliment in fisier
        {
            aliment.ID_aliment = ++nrAlimente;
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(aliment.Conversie_la_sir_fisier());
            }
        }
        public List<Aliment> GetAlimente(out int nrAlimente) // citire alimente din fisier
        {
            List<Aliment> lista = new List<Aliment>();
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lista.Add(new Aliment(line));
                }
            }
            nrAlimente = lista.Count;
            return lista;
        }
        public List<Aliment> search(string denumire)//cautare dupa denumire
        {
            Aliment aliment;
            List<Aliment> rezultatSearch = new List<Aliment>();
            using (StreamReader sr = new StreamReader(NumeFisier))//citire din fisier
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    aliment = new Aliment(line);
                    if (aliment.denumire == denumire)
                    {
                        rezultatSearch.Add(aliment);
                    }
                }
            }
            return rezultatSearch;
        }
        public void editAliment(Aliment aliment)
        {
            List<Aliment> lista = GetAlimente(out int nrAlimente);
            for (int i = 0; i < nrAlimente; i++)
            {
                if (lista[i].ID_aliment == aliment.ID_aliment)
                {
                    lista[i].denumire = aliment.denumire;
                    lista[i].data_exp = aliment.data_exp;
                    lista[i].cantitate = aliment.cantitate;
                    lista[i].gramaj = aliment.gramaj;
                    lista[i].ID_individ = aliment.ID_individ;
                }
            }
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
            {
                foreach (var item in lista)
                {
                    swFisierText.WriteLine(item.Conversie_la_sir_fisier());
                }
            }
        }
    }
}