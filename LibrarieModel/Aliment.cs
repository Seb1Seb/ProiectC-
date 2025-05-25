using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
        private const int ID_INDIVID = 6;

        public int ID_aliment { get; set; }
        public string denumire { get; set; }
        public string data_exp { get; set; }
        public int cantitate { get; set; }
        public float gramaj { get; set; }
        public tipAliment tipAliment { get; set; }
        public int ID_individ { get; set; }
        public string toStr()
        {
            string afisare = $"ID: {ID_aliment} denumire: {denumire} data_exp: {data_exp} cantitate: {cantitate} gramaj: {gramaj} tip_aliment: {tipAliment} ID_individ: {ID_individ}";
            return afisare;
        }
        public Aliment()//constructor implicit
        {
            ID_aliment = 0;
            denumire = string.Empty;
            data_exp = string.Empty;
            cantitate = 0;
            gramaj = 0;
            tipAliment = tipAliment.none;
            ID_individ = 0;
        }
        public Aliment(string denumire, string data_exp, int cantitate, float gramaj, int TipAliment)//constructor cu parametri
        {
            ID_aliment = 0;
            this.denumire = denumire;
            this.data_exp = data_exp;
            this.cantitate = cantitate;
            this.gramaj = gramaj;
            this.tipAliment = (tipAliment)TipAliment;
            this.ID_individ = -1;
        }
        public Aliment(string linie)//constructor pentru linia din fisier
        {
            var dateFisier = linie.Split(separator_fisier);
            ID_aliment = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            data_exp = dateFisier[DATA_EXP];
            cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            gramaj = Convert.ToSingle(dateFisier[GRAMAJ]);
            tipAliment = (tipAliment)Convert.ToInt32(dateFisier[TIP_ALIMENT]);
            ID_individ = Convert.ToInt32(dateFisier[ID_INDIVID]);
        }
        public string Conversie_la_sir_fisier()
        {
            string ObiectFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",
                separator_fisier,
                ID_aliment,
                (denumire ?? "NECUNOSCUT"),
                (data_exp ?? "NECUNOSCUT"),
                cantitate,
                gramaj,
                (int)tipAliment,
                ID_individ
                );
            return ObiectFisier;
        }
        //tip: oua, fructe, legume, carne, lactate
    }
}
