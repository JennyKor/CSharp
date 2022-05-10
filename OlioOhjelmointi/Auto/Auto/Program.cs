using System;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto auto1 = new Auto();
            //auto1.Auton1Tiedot();
            //auto1.TulostaTiedot();

            //Console.WriteLine("Kirjoita K kiihdyttääksesi tai J jarruuttaaksesi.");
            //auto1.Kiihdyta();
            //auto1.Tankkaa();

            Auto auto2 = new Auto("Reliant Regal", "Supervan III", 5);
            auto2.TulostaTiedot();
            auto2.Kiihdyta();
            auto2.Kiihdyta();
            auto2.Tankkaa();
            
        }
    } 
}
