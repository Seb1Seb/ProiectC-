using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    public class Individ
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public void citire_tastatura()
        {
            Console.WriteLine("Introduceti numele: ");
            nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele: ");
            prenume = Console.ReadLine();
        }
        public string toStr()
        {
            string afisare = $"nume: {nume} prenume: {prenume}";
            return afisare;
        }
        public Individ()
        {
            nume = string.Empty;
            prenume = string.Empty;
        }
        public Individ(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

    }
}
