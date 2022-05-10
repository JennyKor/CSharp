using System;
using System.Collections.Generic;
using System.Text;

namespace TVLuokka
{
    class Tv
    {
        private int kanava;
        public bool paalla;
        private int maxKanava;

        public Tv()
        {
            kanava = 1;
            paalla = true;
        }

        public Tv(int kanavaMaara)
        {
            maxKanava = kanavaMaara;
        }

        public void Sammuta()
        {
            paalla = false;
            Console.WriteLine("TV on pois päältä.");
        }

        public int VaihdaKanava(int vaihto)
        {
            paalla = true;
            kanava = vaihto;
            Console.WriteLine("Kanava on " + kanava);
            return kanava;
        }

        public void Toiminnot()
        {
            Console.WriteLine("Kaukosäätimen toiminnot");
            Console.WriteLine("Sammuta: 0");
            Console.WriteLine("Vaihda kanava: 1-9");
        }
    }
}
