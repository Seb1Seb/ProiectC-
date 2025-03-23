using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    public class Aliment
    {
        private const char separator_fisier = ';';

        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int DATA_EXP = 2;
        private const int CANTITATE = 3;
        private const int GRAMAJ = 4;
        private const int TIP_ALIMENT = 5;

        public int IDuser { get; set; }
        public string denumire { get; set; }
        public string data_exp { get; set; }
        public int cantitate { get; set; }
        public float gramaj { get; set; }
        public tipAliment tipAliment { get; set; }
        public string toStr()
        {
            string afisare = $"ID: {IDuser} denumire: {denumire} data_exp: {data_exp} cantitate: {cantitate} gramaj: {gramaj} tip_aliment: {tipAliment}";
            return afisare;
        }
        public Aliment()//constructor implicit
        {
            IDuser = 0;
            denumire = string.Empty;
            data_exp = string.Empty;
            cantitate = 0;
            gramaj = 0;
            tipAliment = tipAliment.none;
        }
        public Aliment(string denumire, string data_exp, int cantitate, float gramaj, int TipAliment)//constructor cu parametri
        {
            IDuser = 0;
            this.denumire = denumire;
            this.data_exp = data_exp;
            this.cantitate = cantitate;
            this.gramaj = gramaj;
            this.tipAliment = (tipAliment)TipAliment;
        }
        public Aliment(string linie)//constructor pentru linia din fisier
        {
            var dateFisier = linie.Split(separator_fisier);
            IDuser = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            data_exp = dateFisier[DATA_EXP];
            cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            gramaj = Convert.ToSingle(dateFisier[GRAMAJ]);
            tipAliment = (tipAliment)Convert.ToInt32(dateFisier[TIP_ALIMENT]);
        }
        public string Conversie_la_sir_fisier()
        {
            string ObiectFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                separator_fisier,
                IDuser,
                (denumire ?? "NECUNOSCUT"),
                (data_exp ?? "NECUNOSCUT"),
                cantitate,
                gramaj,
                (int)tipAliment
                );
            return ObiectFisier;
        }
        //tip: oua, fructe, legume, carne, lactate
    }
}
