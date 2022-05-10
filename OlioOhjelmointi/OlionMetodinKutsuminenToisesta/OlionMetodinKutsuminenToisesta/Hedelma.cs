using System;
using System.Collections.Generic;
using System.Text;

namespace OlionMetodinKutsuminenToisesta
{
    class Hedelma
    {
        public bool nakyvissa;

        public Hedelma()
        {
            nakyvissa = true;
        }

        public void Katoa()
        {
            nakyvissa = false;
            Console.WriteLine("Hedelmä piilotettu");
        }
    }
}
