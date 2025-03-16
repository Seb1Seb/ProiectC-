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
        public static int IDstatic { get; set; } = 0;
        public int IDuser { get; set; }
        public string denumire { get; set; }
        public string data_exp { get; set; }
        public int cantitate { get; set; }
        public float gramaj { get; set; }
        public string toStr()
        {
            string afisare = $"ID: {IDuser} denumire: {denumire} data_exp: {data_exp} cantitate: {cantitate} gramaj: {gramaj}";
            return afisare;
        }
        public Aliment()
        {
            IDuser = IDstatic++;
            denumire = string.Empty;
            data_exp = string.Empty;
            cantitate = 0;
            gramaj = 0;
        }
        public Aliment(string denumire, string data_exp, int cantitate, float gramaj)
        {
            IDuser = IDstatic++;
            this.denumire = denumire;
            this.data_exp = data_exp;
            this.cantitate = cantitate;
            this.gramaj = gramaj;
        }
        public Aliment(string linie)
        {
            var dateFisier = linie.Split(separator_fisier);
            IDuser = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            data_exp = dateFisier[DATA_EXP];
            cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            gramaj = Convert.ToSingle(dateFisier[GRAMAJ]);
        }
        public string Conversie_la_sir_fisier()
        {
            string ObiectFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                separator_fisier,
                IDuser,
                (denumire ?? "NECUNOSCUT"),
                (data_exp ?? "NECUNOSCUT"),
                cantitate,
                gramaj
                );
            return ObiectFisier;
        }
    }
}
