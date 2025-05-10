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
            Aliment a = new Aliment("Banana", "12.04.25", 3, 240.5f, 3);
            Individ Pers1 = new Individ("Gigel","Ion", 1, "2,8,32");
            Console.WriteLine(Pers1.toStr());
            Aliment Fruct1 = new Aliment("DragonFruit","11.05.25", 14, 1250.45f, 3);

            AdministrareIndivizi Xindivizi = new AdministrareIndivizi();
            AdministrareAlimente Xalimente = new AdministrareAlimente();

            
            AdministrareFisierIndivizi Xfisier = new AdministrareFisierIndivizi("Indivizi.txt");//creare fisier
            AdministrareFisierAlimente XfisierAlimente = new AdministrareFisierAlimente("Alimente.txt");//creare fisier
            
            
            int nrAlimente = 0;
            int nrIndivizi = 0;

            Xfisier.GetIndivizi(out nrIndivizi);
            XfisierAlimente.GetAlimente(out nrAlimente);

            Xindivizi.AddIndivid(Pers1);
            Xalimente.AddAliment(Fruct1);

            Individ Pers2 = Xindivizi.search("Ion", "Ion");//cautare dupa nume si prenume
            if (Pers2!=null)
                Console.WriteLine(Pers2.toStr());
            Console.WriteLine("\n");

            Aliment Fruct2 = Xalimente.search("DragonFruit");//cautare dupa denumire
            if (Fruct2!=null)
                Console.WriteLine(Fruct2.toStr());
            Console.WriteLine("\n");

            Xfisier.AddIndivid(Pers1, ref nrIndivizi);
            Individ Pers3 = new Individ("Ion", "Ion", 1, "2");//adaugare individ in fisier
            Xfisier.AddIndivid(Pers3, ref nrIndivizi);
            List<Individ> vect = Xfisier.GetIndivizi(out nrIndivizi);//citire individ din fisier

            for (int i = 0; i < nrIndivizi; i++)//afisare vectori indivizi
                Console.WriteLine(vect[i].toStr());
            Console.WriteLine("\n");

            XfisierAlimente.AddAliment(Fruct1, ref nrAlimente);
            List<Aliment> vectAlimente = XfisierAlimente.GetAlimente(out nrAlimente);//citire alimente din fisier

            for (int i = 0; i < nrAlimente; i++)//afisare vectori alimente
                Console.WriteLine(vectAlimente[i].toStr());
            Console.WriteLine("\n");

            Individ Pers4 = Xfisier.search("Ion", "Ion");//cautare dupa nume si prenume
            if (Pers4 != null)
                Console.WriteLine(Pers4.toStr());
            else
                Console.WriteLine("Nu exista");

        }
    }
}
