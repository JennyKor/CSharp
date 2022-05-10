using System;
using System.Collections.Generic;
using System.Text;

namespace PenkinLammitin
{
    class PenkinLammitin
    {
        private int teho;

        public int Teho
        {
            get
            {
                return teho;
            }

        }
        public PenkinLammitin()
        {
            teho = 0;
        }

        public void MuutaTehoa()
        {
            teho = teho + 1;

            if (teho == 4)
            {
                teho = 0;
            }

            naytaLedit();
        }

        private void naytaLedit()
        {
            if (teho == 1)
            {
                Console.WriteLine("*");
            }

            if (teho == 2)
            {
                Console.WriteLine("**");
            }
            if (teho == 3)
            {
                Console.WriteLine("***");
            }
            if (teho == 0)
            {
                Console.WriteLine("Sammutettu");
            }
        }
    }
}
