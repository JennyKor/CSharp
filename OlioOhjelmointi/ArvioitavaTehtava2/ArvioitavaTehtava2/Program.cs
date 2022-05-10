using System;

namespace ArvioitavaTehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            TapahtumaArtikkeli tapahtuma1 = new TapahtumaArtikkeli("Stamina", 20.90);
            TapahtumaArtikkeli tapahtuma2 = new TapahtumaArtikkeli("JVG", 30.00);

            tapahtuma1.TulostaTiedot();
            tapahtuma2.TulostaTiedot();
            Console.WriteLine("Luotujen tapahtumien lukumäärä: " + TapahtumaArtikkeli.tapahtumienLkm);
        }
    }
}
