using System;
using System.Linq;

namespace arvioitavaTehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tulos = new int[3];

            int kerta = 1;
            for (int i = 0; i < tulos.Length; i++)
            {          
                Console.WriteLine("Kirjoita " + kerta + ". hypyn pituus (cm):");
                tulos[i] = int.Parse(Console.ReadLine());
                kerta++;
            }

            Console.WriteLine("Hyppyjen pituudet pienimmästä suurimpaan: ");
            Array.Sort(tulos);

            for (int i = 0; i<tulos.Length; i++)
            {
                Console.WriteLine(tulos[i]);
            }

            
            Console.WriteLine("Hyppyjen keskiarvo on " + tulos.Average());

        }
    }
}
