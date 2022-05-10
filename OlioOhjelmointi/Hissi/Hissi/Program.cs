using System;

namespace Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(5);
            hissi.kerrosYlosAlas("Ylös");
            hissi.kerrosYlosAlas("Ylös");
            hissi.Kerros = 10; //koska kerros on private, asetetaan arvo get setterillä
            //hissi.kerrosYlosAlas("Ylös");
            //hissi.tulostaTiedot();
            Console.WriteLine("Tämän hetkinen kerros on " + hissi.Kerros);
        }
    }
}
