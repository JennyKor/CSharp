using System;

namespace Funktio_harjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            TulostaOtsikko();

            string palautuva = "";
            Console.WriteLine(SananLasku(palautuva));

            Console.WriteLine($"Anna ensimmäinen numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Anna toinen numero:");
            int numero2 = int.Parse(Console.ReadLine());
            KerroIsoin(numero1, numero2);

            Console.WriteLine(KerroIsoin2(numero1, numero2));

            Console.WriteLine("Anna nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("Anna pituus:");
            int pituus = int.Parse(Console.ReadLine());
            MuotoileLause(nimi, pituus);

            Console.WriteLine("Anna syntymävuotesi:");
            int sv = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kuluva vuosi:");
            int kv = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikäsi on " + LaskeIka(kv, sv));
        }

        public static void TulostaOtsikko()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*  Funktio-harjoituksia  *");
            Console.WriteLine("**************************");
        }

        public static string SananLasku(string palautuva)
        {
            Random random = new Random();
            string[] sananlasku = new string[4];
            sananlasku[0] = "Etiäpäin, sanoi mummo lumessa";
            sananlasku[1] = "Niin metsä vastaa kuin sinne huudetaan.";
            sananlasku[2] = "Ahneella on paskanen loppu.";
            sananlasku[3] = "Odottavan aika on pitkä";

            int arvottu = random.Next(0, 4);
            palautuva = sananlasku[arvottu];
            return palautuva;
        }

        public static void KerroIsoin(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine($"Isompi numero on {numero1}");
            }

            else
            {
                Console.WriteLine($"Isompi numero on {numero2}");
            }
          
        }

        public static string KerroIsoin2(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return numero1 + " on suurempi.";
            }

            else
            {
                return numero2 + "on suurempi";
            }
        }

        public static void MuotoileLause(string nimi, int pituus)
        {
            Console.WriteLine($"{nimi} on {pituus} cm pitkä.");
        }

        public static int LaskeIka(int kv, int sv)
        {
            int ika = kv - sv;
            return ika;
        }  
    }
}
