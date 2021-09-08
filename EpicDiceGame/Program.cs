using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat;
            //iga mängija viskab täringut (1-6);
            //programm kuvab nende visete tulemused ja kuvab ka, kes on võitja
            // - ehk kes viskab suuremat

            Random rnd = new Random();

            string esimängija = "Vladimir Putin";

            int plr1 = rnd.Next(1, 6);

            Random rnd2 = new Random();

            string teinemängija = "Donald Trump";

            int plr2 = rnd.Next(1, 6);

            Console.WriteLine(esimängija + " viskab taringuga numbri " + plr1);
            Console.WriteLine(teinemängija + " viskab taringuga numbri " + plr2);

            if (plr1 < plr2)
            {
                Console.WriteLine(esimängija + " on võitja");
            }
            else if (plr1 > plr2)
            {
                Console.WriteLine(teinemängija + " on võitja");
            }
            else
            {
                Console.WriteLine("viik");
            }
        }
    }
}
