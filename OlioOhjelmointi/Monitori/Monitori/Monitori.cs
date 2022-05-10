using System;
using System.Collections.Generic;
using System.Text;

namespace Monitori
{
    class Monitori //luokka
    {
        public bool paalla; // attribuutti
        public string merkki;

        public Monitori() //oletusmuodostin-- muodostin, jolle annettu kaikki oletusarvot -- ei voidia!
        {
            merkki = "";
            paalla = false;
        }

        public Monitori(string monitorinMerkki)
        {
            merkki = monitorinMerkki;
            paalla = false;
        }

        public Monitori(string merkki, bool paalla)
        {
            this.merkki = merkki; // tämän olion merkki-attribuutti saa arvokseen samsung
            this.paalla = paalla;
        }

        public void TulostaTiedot() //metodi
        {
            Console.WriteLine("MONITORIN TIEDOT");
            Console.WriteLine("Merkki: " + merkki);
            if (paalla)
            {
                Console.WriteLine("Monitori on päällä.");
            }
            else
            {
                Console.WriteLine("Monitori ei ole päällä.");
            }
        }

        public void Kaynnista() //metodi
        {
            paalla = true;
        }

        public void Sammuta()
        {
            paalla = false;
        }
    }
}
