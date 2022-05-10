using System;
using System.Threading;

namespace Muistipeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näet seitsemän numeroa viiden sekunnin ajan. Paina ne mieleesi.");
            Console.WriteLine("Paina mitä tahansa näppäintä kun olet valmis aloittamaan");
            Console.WriteLine();
            Console.ReadKey();


            Random random = new Random();
            int[] luku = new int[7];

            for (int i = 0; i < luku.Length; i++)
            {
                luku[i] = random.Next(1,6);
                Console.Write(luku[i] + " ");
            }

            Thread.Sleep(5000);
            Console.Clear();

            int[] arvaus = new int[7];
            //int kerta;
            //int kierros = 1;
            //for (kerta = 0; kerta < arvaus.Length; kerta++)
            //{
            //    Console.WriteLine("Syötä " + kierros + ". numero:");
            //    arvaus[kerta] = int.Parse(Console.ReadLine());
            //    kierros++;
            //}         //tämäkin toimii

            int kerta = 0;
            int kierros = 1;
            do
            {

                Console.WriteLine("Syötä " + kierros + ". numero:");
                arvaus[kerta] = int.Parse(Console.ReadLine());
                kerta++;
                kierros++;

            } while (kierros <= 7);


            Console.Write("Syöttämäsi numerot ovat: ");

            for (kerta = 0; kerta < arvaus.Length; kerta++)
            {
                Console.Write(arvaus[kerta] + " ");
            }

            Console.WriteLine();

            Console.Write("Oikeat numerot ovat: ");

            for (int i = 0; i < luku.Length; i++)
            {
                Console.Write(luku[i] + " ");
            }

            int oikein = 0;
            for (int i = 0; i < luku.Length; i++)
            {
                if (luku[i] == arvaus[i])
                {
                    oikein++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sait " + oikein + " numeroa oikein.");
           
            Console.WriteLine($"Sait {100/7*oikein} prosenttia oikein.");
        }
        
    }
}
