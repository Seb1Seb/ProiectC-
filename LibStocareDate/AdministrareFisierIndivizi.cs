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
        public AdministrareFisierIndivizi(string numeFisier)//constructor
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AddIndivid(Individ persoana, ref int nrIndivizi)//apelam metoda de conversie la sir a obiectului de tip Individ
        {
            persoana.ID_individ = ++nrIndivizi;
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(persoana.Conversie_la_sir_fisier());
            }
        }
        public List<Individ> GetIndivizi(out int nrIndivizi)
        {
            List<Individ> lista = new List<Individ>();
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lista.Add(new Individ(line));
                }
            }
            nrIndivizi = lista.Count;
            return lista;
        }
        public List<Individ> search(string nume, string prenume)
        {
            Individ individ;
            List<Individ> rezultatSearch = new List<Individ>();
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    individ = new Individ(line);
                    if ((individ.nume == nume && individ.prenume == prenume) || (nume == "" && prenume == individ.prenume) ||(nume==individ.nume&&prenume==""))
                    {
                        rezultatSearch.Add(individ);
                    }
                }
            }
            return rezultatSearch;
        }
        public void editIndivid(Individ individ)
        {
            List<Individ> lista = GetIndivizi(out int nrIndivizi);
            for (int i = 0; i < nrIndivizi; i++)
            {
                if (lista[i].ID_individ == individ.ID_individ)
                {
                    lista[i].nume = individ.nume;
                    lista[i].prenume = individ.prenume;
                    lista[i].tipIndivid = individ.tipIndivid;
                    lista[i].atributeIndivid = individ.atributeIndivid;
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