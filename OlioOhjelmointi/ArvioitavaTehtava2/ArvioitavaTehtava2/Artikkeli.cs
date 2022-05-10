using System;
using System.Collections.Generic;
using System.Text;

namespace ArvioitavaTehtava2
{
    class Artikkeli
    {
        public string otsikko;

        public Artikkeli()
        {
            otsikko = "";
        }

        public Artikkeli(string otsikko)
        {
            this.otsikko = otsikko;
        }

        public virtual void TulostaTiedot()
        {
            Console.WriteLine(otsikko);
        }
    }
}
