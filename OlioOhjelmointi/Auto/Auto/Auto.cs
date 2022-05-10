using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
{
    class Auto
    {
        public string merkki;
        public string malli;
        public int bensanMaara;

        public Auto(string merkki, string malli, int bensanMaara)
        {
            this.merkki = merkki;
            this.malli = malli;
            this.bensanMaara = bensanMaara;
        }

        //public void Auton1Tiedot()
        //{
        //    merkki = "Citroën";
        //    malli = "2CV";
        //    bensanMaara = 5;
        //}

        public void TulostaTiedot()
        {
            Console.WriteLine("Auton merkki on " + merkki);
            Console.WriteLine("Auton malli on " + malli);
            Console.WriteLine("Bensan määrä on " + bensanMaara + " litraa.");
        }

        public void Jarruta()
        {
            Console.WriteLine("Auto jarruttaa.");
        }

        public void Kiihdyta()
        {
            if (bensanMaara == 0)
            {
                Console.WriteLine("Bensa loppui. Auto pysähtyy.");
            }

            else
            {
                Console.WriteLine("Auto kiihdyttää.");
                bensanMaara = (bensanMaara - 1);
                Console.WriteLine("Bensan määrä on " + bensanMaara + " litraa.");
            }
        }

        public void Tankkaa()
        {
            while (bensanMaara < 5)
            {
                bensanMaara++;
            }
            Console.WriteLine("Auto on tankattu. Bensaa on " + bensanMaara + " litraa.");
        }
    }
}
