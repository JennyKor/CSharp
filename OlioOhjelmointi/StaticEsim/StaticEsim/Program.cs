using System;

namespace StaticEsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("IAB-553", 0);
            Auto auto2 = new Auto("SDF-121", 50);

            auto1.TulostaKaikkiTiedot();
            auto2.TulostaKaikkiTiedot();

            Console.WriteLine(auto1.rekNro);
            Console.WriteLine(Auto.autojenLkm);

            Auto.TulostaAutojenLkm(); // staattista metodia kutsutaan luokan kautta

            //Laskurit laskuri = new Laskurit();
            Console.WriteLine(Laskurit.LaskePintaAla(50, 50));
        }
    }
}
