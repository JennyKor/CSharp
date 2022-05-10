using System;

namespace kuumeRajatKertaus
{
    class Program
    {
        // Olio-ohjelmointikurssilta, mutta ei sisällä olioita
        static void Main(string[] args)
        {
            TulostaKuumerajat();

            Console.WriteLine("Valitse kohde: kirjoita ihminen, hevonen, tai koira.");
            string kohde = Console.ReadLine().ToLower();
            Console.WriteLine("Anna lämpötila:");
            int lampo = int.Parse(Console.ReadLine());
            if (OnkoKuumetta(kohde, lampo) == true)
            {
                Console.WriteLine("Kohteella on kuumetta.");
            }
            else
            {
                Console.WriteLine("Kohteella ei ole kuumetta.");
            }
            
        }

        public static void TulostaKuumerajat()
        {
            Console.WriteLine("Kuumerajat:");
            Console.WriteLine("Ihminen 37");
            Console.WriteLine("Koira 39");
            Console.WriteLine("Hevonen 38");
        }

        public static bool OnkoKuumetta(string kohde, int lampo)
        {
            bool kuumettaOn = false; // kohteella ei ole kuumetta
            
            if (kohde == "ihminen" && lampo >= 37)
            {
                kuumettaOn = true;
            }

            if (kohde == "koira" && lampo >= 39)
            {
                kuumettaOn = true;
            }

            if (kohde == "hevonen" && lampo >= 38)
            {
               kuumettaOn = true;
            }

            return kuumettaOn;
        }

    }
}
