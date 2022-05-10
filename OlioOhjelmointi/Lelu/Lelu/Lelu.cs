using System;
using System.Collections.Generic;
using System.Text;

namespace Lelu
{
    class Lelu
    {
        protected string nimi;
        public int paino;

        public Lelu()
        {
            nimi = "Barbie";
            paino = 110;
        }

        public Lelu(string nimi, int paino)
        {
            this.nimi = nimi;
            this.paino = paino;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine(nimi);
            Console.WriteLine(paino);
        }
    }
}
