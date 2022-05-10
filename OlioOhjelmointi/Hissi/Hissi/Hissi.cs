using System;
using System.Collections.Generic;
using System.Text;

namespace Hissi
{
    class Hissi
    {
        int kerros; //jos ei määritellä näkyvyyttä, oletuksena private
        private int maxKerros;

        public int Kerros
        {
            set
            {
                if (value <= maxKerros)
                {
                    kerros = value;
                }

                else
                {
                    kerros = maxKerros;
                }
            }

            get
            {
                return kerros;
            }
        }

        public Hissi()
        {
            kerros = 0;
            maxKerros = 1;
        }
        public Hissi(int kerrostenLkm)
        {
            kerros = 0;
            maxKerros = kerrostenLkm; //asetetaan maksimi kerrosmääräksi 5
        }


        private void tulostaTiedot()
        {
            Console.WriteLine("Hissi-olion tiedot: ");
            Console.WriteLine("Kerros: " + kerros);
        }

        public void kerrosYlosAlas(string suunta)
        {
            if (suunta == "alas")
            {
                kerros--;
            }
            else
            {
                kerros++;
            }

            tulostaTiedot();
        }
    }
}
