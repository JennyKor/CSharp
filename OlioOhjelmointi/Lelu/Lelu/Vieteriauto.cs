using System;
using System.Collections.Generic;
using System.Text;

namespace Lelu
{
    class Vieteriauto : Lelu
    {
        public int nopeus;
        public int kiihdyta;

        public Vieteriauto() : base()
        {
            nopeus = 1;
            kiihdyta = nopeus + 1;
        }

        public Vieteriauto(string nimi, int paino, int nopeus, int kiihdyta) : base(nimi, paino)
        {
            this.nopeus = nopeus;
            this.kiihdyta = nopeus + kiihdyta;

        }
        public void TulostaVieteriautonTiedot()
        {
            Console.WriteLine("Vieteriauto on " + nimi);
            Console.WriteLine("Paino on " + paino);
            Console.WriteLine("Nopeus on " + nopeus);
            Console.WriteLine("Auto kiihdytti! Nopeus on nyt " + kiihdyta);
        }
    }
}
