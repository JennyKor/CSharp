using System;

namespace arvioitavaTehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tahdet = false;
            TulostaOtsikko(tahdet);

            Console.WriteLine("Anna lämpötila (celsius):");
            int lampo = int.Parse(Console.ReadLine());
            Console.WriteLine("Lämpötila on fahrenheiteina " + (MuunnaLampotila(lampo)));
           
        }

        public static void TulostaOtsikko(bool tahdet)
        {
            Console.WriteLine("Celsius Fahrenheiteiksi");

            if (tahdet == true)
            {
                Console.WriteLine("***********************");
            }

            else
            {
                Console.WriteLine();
            }


        }

        public static int MuunnaLampotila(int lampo)
        {
            int fahrenheit = lampo * 9 / 5 + 32;
            return fahrenheit;
        }
    }
}
