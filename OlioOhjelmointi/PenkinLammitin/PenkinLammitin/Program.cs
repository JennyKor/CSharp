using System;

namespace PenkinLammitin
{
    class Program
    {
        static void Main(string[] args)
        {
            string syote;
            PenkinLammitin penkinlammitin = new PenkinLammitin();
            Console.WriteLine(penkinlammitin.Teho);
            penkinlammitin.MuutaTehoa();
            penkinlammitin.MuutaTehoa();
            penkinlammitin.MuutaTehoa();
            penkinlammitin.MuutaTehoa();
            penkinlammitin.MuutaTehoa();

            do
            {
                Console.WriteLine("Paina x-painiketta. Jos haluat poistua, kirjoita poistu.");
                syote = Console.ReadLine();

                if (syote == "x")
                {
                    penkinlammitin.MuutaTehoa();
                }

                if (syote == "poistu")
                {
                    break;
                }

            } while (syote == "x");    
        }
    }
}
