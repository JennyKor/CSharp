using System;

namespace OlionMetodinKutsuminenToisesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Packman packman = new Packman();
            //packman.TulostaTiedot();

            Hedelma fruit1 = new Hedelma();
            Hedelma fruit2 = new Hedelma();
            Hedelma fruit3 = new Hedelma();

            // Console.WriteLine(fruit1.nakyvissa);

            packman.Syo(fruit1); // 1. syödään hedelmä-olio, lähetetään parametrina
            Console.WriteLine("Mitkä hedelmät näkyvät");
            Console.WriteLine(fruit1.nakyvissa);
            Console.WriteLine(fruit2.nakyvissa);
            Console.WriteLine(fruit3.nakyvissa);

            Ghost ghost = new Ghost();
            ghost.SyoPackman(packman);   
        }
    }
}
