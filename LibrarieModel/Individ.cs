using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    public class Individ
    {
        private const char separator_fisier = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;

        public static int IDstatic { get; set; } = 0;
        public int IDuser { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string toStr()
        {
            string afisare = $"ID: {IDuser} nume: {nume} prenume: {prenume}";
            return afisare;
        }
        public Individ()
        {
            IDuser = IDstatic++;
            nume = string.Empty;
            prenume = string.Empty;
        }
        public Individ(string nume, string prenume)
        {
            IDuser = IDstatic++;
            this.nume = nume;
            this.prenume = prenume;
        }
        public Individ(string linie)
        {
            var dateFisier = linie.Split(separator_fisier);
            IDuser = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
        }
        public string Conversie_la_sir_fisier()
        {
            string ObiectFisier = string.Format("{1}{0}{2}{0}",
                separator_fisier,
                IDuser,
                (nume ?? "NECUNOSCUT"),
                (prenume ?? "NECUNOSCUT")
                );
            return ObiectFisier;
        }
    }
}
