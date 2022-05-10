using System;

namespace TVLuokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv(9);
            int vaihto;
            
            
            tv.Toiminnot();
            do
            {   
                vaihto = int.Parse(Console.ReadLine());
                
                if (vaihto >=1 && vaihto <=9)
                {
                    tv.VaihdaKanava(vaihto);
                    tv.Toiminnot();   
                }

                if (vaihto == 0)
                {
                    tv.Sammuta();
                }
                if ( vaihto >= 10)
                {
                    Console.WriteLine("Ei tuommosta kanavaa tässä telkassa. Yritä uudelleen.");
                }

            } while (tv.paalla == true);
        }
    }
}
