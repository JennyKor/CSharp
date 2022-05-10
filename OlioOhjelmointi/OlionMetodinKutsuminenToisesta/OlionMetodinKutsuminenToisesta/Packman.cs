using System;
using System.Collections.Generic;
using System.Text;

namespace OlionMetodinKutsuminenToisesta
{
    class Packman
    {
        public int pisteet;
        public int elamat;

        public Packman()
        {
            pisteet = 0;
            elamat = 3;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine(pisteet);
        }

        public void Syo(Hedelma fruit) //2. otetaan vastaan Hedelma-luokan olioita(vastaanotetun olion nimen ei tarvitse olla sama kuin lähetetty!)
        {
            Console.WriteLine("Hedelmä syöty");
            fruit.Katoa(); // 3. olion lähettämisen metodiin jälkeen voidaan kutsua olion omia metodeja
        }

        public void VahennaElama()
        {
            elamat = elamat - 1;
            Console.WriteLine("Packman syöty. Elämiä jäljellä " + elamat);
        }
    }
}
