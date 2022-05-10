using System;
using System.Collections.Generic;
using System.Text;

namespace StaticEsim
{
    class Auto
    {
        public string rekNro;
        public decimal nopeus;
        public static int autojenLkm;

        public Auto()
        {
            rekNro = "";
            nopeus = 0;
            autojenLkm++; // lisätään autojen lukumäärää yhdellä
        }

        public Auto(string rekNro, decimal nopeus)
        {
            this.rekNro = rekNro;
            this.nopeus = nopeus;
            autojenLkm++;
        }

        public static void TulostaAutojenLkm() // koko luokan metodi, ei yksittäisen olion -- voidaan käsitellä vain staattisia atrribuutteja
        {
            Console.WriteLine("Autojen lukumäärä: " + autojenLkm);
        }

        public void TulostaKaikkiTiedot()
        {
            Console.WriteLine("Rekisterinumero: " + rekNro);
            Console.WriteLine("Nopeus: " + nopeus);
            Console.WriteLine("Autojen lukumäärä: " + autojenLkm);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
