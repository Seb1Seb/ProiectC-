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
        private const int TIP = 3;
        private const int ATRIBUTE = 4;
        public int ID_individ { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public tipIndivizi tipIndivid { get; set; }
        public atributeIndivizi atributeIndivid { get; set; }
        public string toStr()
        {
            string afisare = $"ID: {ID_individ} nume: {nume} prenume: {prenume} gen: {tipIndivid} atribute_indivizi {atributeIndivid}";
            return afisare;
        }
        public Individ()//constructor implicit
        {
            ID_individ = 0;
            nume = string.Empty;
            prenume = string.Empty;
            tipIndivid = tipIndivizi.none;
            atributeIndivid = atributeIndivizi.none;
        }
        public Individ(string nume, string prenume, int TipIndivid, string atribute)//constructor cu parametri
        {
            ID_individ = 0;
            this.nume = nume;
            this.prenume = prenume;
            this.tipIndivid = (tipIndivizi)TipIndivid;
            if (!string.IsNullOrEmpty(atribute))
            {
                atributeIndivid = atributeIndivizi.none;
                foreach (var value in atribute.Split(','))
                {
                    if (Enum.TryParse(value, out atributeIndivizi parsedValue))
                    {
                        atributeIndivid |= parsedValue;
                    }
                }
            }
            else
            {
                atributeIndivid = atributeIndivizi.none;
            }
        }
        public Individ(string linie)//constructor pentru linia din fisier
        {
            var dateFisier = linie.Split(separator_fisier);
            ID_individ = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            tipIndivid = (tipIndivizi)Convert.ToInt32(dateFisier[TIP]);
            atributeIndivid = string.IsNullOrEmpty(dateFisier[ATRIBUTE])
                ? atributeIndivizi.none
                : (atributeIndivizi)Convert.ToInt32(dateFisier[ATRIBUTE]);
        }
        public string Conversie_la_sir_fisier()
        {
            string ObiectFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                separator_fisier,
                ID_individ,
                (nume ?? "NECUNOSCUT"),
                (prenume ?? "NECUNOSCUT"),
                (int)tipIndivid,
                (int)atributeIndivid
                );
            return ObiectFisier;
        }
        //gen: masculin, feminin
    }
    //atribute: inalt(a), scund(a), slab(a), gras(a), sanatos, bolnav
}
