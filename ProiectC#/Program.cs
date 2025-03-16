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
            Individ Pers1 = new Individ();
            Console.WriteLine("Nume: "+Pers1.nume);
            Aliment Fruct1 = new Aliment("DragonFruit","11.05.25",14,1250.45f);



            AdministrareIndivizi Xindivizi = new AdministrareIndivizi();
            AdministrareAlimente Xalimente = new AdministrareAlimente();
            Xindivizi.AddIndivid(Pers1);
            Xalimente.AddAliment(Fruct1);
            Individ Pers2 = Xindivizi.search("Ion", "Ion");
            if(Pers2!=null)
                Console.WriteLine(Pers2.toStr());
            Aliment Fruct2 = Xalimente.search("DragonFruit");
            if (Fruct2!=null)
                Console.WriteLine(Fruct2.toStr());

            AdministrareFisierIndivizi Xfisier = new AdministrareFisierIndivizi("Indivizi.txt");
            Xfisier.AddIndivid(Pers1);
            int nrIndivizi = 0;
            Individ[] vect = Xfisier.GetIndivizi(out nrIndivizi);
            for (int i = 0; i < nrIndivizi; i++)
                Console.WriteLine(vect[i].toStr());
            AdministrareFisierAlimente XfisierAlimente = new AdministrareFisierAlimente("Alimente.txt");
            XfisierAlimente.AddAliment(Fruct1);
            int nrAlimente = 0;
            Aliment[] vectAlimente = XfisierAlimente.GetAlimente(out nrAlimente);
            for (int i = 0; i < nrAlimente; i++)
                Console.WriteLine(vectAlimente[i].toStr());

        }
    }
}
