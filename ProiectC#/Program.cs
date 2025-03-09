using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModel;
using LibStocareDate;

namespace ProiectC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aliment[] V_Aliment = new Aliment[100];
            Individ[] V_Individ = new Individ[100];
            Aliment a = new Aliment("Banana","12.04.25",3,240.5f);
            Individ Pers1 = new Individ("Nume","Prenume");
            Console.WriteLine("Nume: "+Pers1.nume);
            Aliment Fruct1 = new Aliment("DragonFruit","11.05.25",14,1250.45f);
            Console.WriteLine(Fruct1.toStr());



            AdministrareIndivizi Xindivizi = new AdministrareIndivizi();
            AdministrareAlimente Xalimente = new AdministrareAlimente();
            Xindivizi.AddIndivid(Pers1);
            Xalimente.AddAliment(Fruct1);
            Xindivizi.AfisareIndivizi();
            Xalimente.AfisareAlimente();
        }
    }
}
