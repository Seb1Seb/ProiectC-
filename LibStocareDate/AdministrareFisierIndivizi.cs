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
            persoana.IDuser = ++nrIndivizi;
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(persoana.Conversie_la_sir_fisier());
            }
        }
        public Individ[] GetIndivizi(out int nrIndivizi)//out - trimite parametrul nrIndivizi ca referinta
        {
            Individ[] vect = new Individ[nr_max];
            nrIndivizi = 0;
            using (StreamReader sr = new StreamReader(NumeFisier))//citire din fisier
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    vect[nrIndivizi++] = new Individ(line);
                }
            }
            Array.Resize(ref vect, nrIndivizi);
            return vect;
        }
        public Individ search(string nume, string prenume)//cautare dupa nume si prenume
        {
            Individ individ;
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    individ = new Individ(line);
                    if (individ.nume == nume && individ.prenume == prenume)
                    {
                        return individ;
                    }
                }
            }
            return null;
        }
    }
}