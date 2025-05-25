using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class FisiereTXT
    {
        public static string NumeFisierAlimente()
        {
            return numeFisierAliemente;
        }
        public static string NumeFisierIndivid()
        {
            return numeFisierIndivid;
        }
        public FisiereTXT()
        {
            
        }
        static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        static string numeFisierAliemente = Path.Combine(locatieFisierSolutie, "Alimente.txt");
        static string numeFisierIndivid = Path.Combine(locatieFisierSolutie, "Individ.txt");
    }
}
