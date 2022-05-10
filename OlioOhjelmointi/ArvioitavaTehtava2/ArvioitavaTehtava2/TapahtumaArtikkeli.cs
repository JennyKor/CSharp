using System;
using System.Collections.Generic;
using System.Text;

namespace ArvioitavaTehtava2
{
    class TapahtumaArtikkeli : Artikkeli
    {
        public double lipunHinta;
        public static int tapahtumienLkm;

        public TapahtumaArtikkeli()
        {
            lipunHinta = 0;
            tapahtumienLkm++;
        }

        public TapahtumaArtikkeli(string otsikko, double lipunHinta) : base(otsikko)
        {
            this.lipunHinta = lipunHinta;
            tapahtumienLkm++;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine(otsikko);
            Console.WriteLine("Lipun hinta " + lipunHinta);
        }
    }
}
