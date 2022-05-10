using System;

namespace Monitori
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitori monitori1 = new Monitori(); // Olion luonti


            monitori1.Kaynnista(); // olio kutsuu Kaynnista-metodia
            monitori1.merkki = "Dell";
            monitori1.TulostaTiedot();
            // Console.WriteLine(monitori1.paalla);

            Monitori monitori2 = new Monitori("Samsung", false);
            monitori2.TulostaTiedot();

            Monitori monitori3 = new Monitori("Sony");
            monitori3.Kaynnista();
            monitori3.TulostaTiedot();
        }   
    }
}
