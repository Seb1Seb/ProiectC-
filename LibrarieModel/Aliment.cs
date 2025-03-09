using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    public class Aliment
    {
        public string denumire { get; set; }
        public string data_exp { get; set; }
        public int cantitate { get; set; }
        public float gramaj { get; set; }
        public void citire_tastatura()
        {
            Console.WriteLine("Denumirea alimentului: ");
            denumire = Console.ReadLine();
            Console.WriteLine("Data de expirare: ");
            data_exp = Console.ReadLine();
            Console.WriteLine("Cantitate(int): ");
            bool valueCantitate = Int32.TryParse(Console.ReadLine(), out int cantitate);
            Console.WriteLine("Gramaj(float): ");
            bool valueGramaj = float.TryParse(Console.ReadLine(), out float gramaj);
        }
        public string toStr()
        {
            string afisare = $"denumire: {denumire} data_exp: {data_exp} cantitate: {cantitate} gramaj: {gramaj}";
            return afisare;
        }
        public Aliment()
        {
            denumire = string.Empty;
            data_exp = string.Empty;
            cantitate = 0;
            gramaj = 0;
        }
        public Aliment(string denumire, string data_exp, int cantitate, float gramaj)
        {
            this.denumire = denumire;
            this.data_exp = data_exp;
            this.cantitate = cantitate;
            this.gramaj = gramaj;
        }


    }
}
