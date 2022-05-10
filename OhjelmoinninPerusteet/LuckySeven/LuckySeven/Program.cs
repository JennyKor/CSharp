using System;

namespace LuckySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int silmaluku1;
            int silmaluku2;
            int silmaluku3;
            string retry;

            Console.Write("Jokainen nopan heitto maksaa euron. ");

            do
            {
                Console.WriteLine("Anna rahamäärä, jonka haluat pelata:");
                int raha = int.Parse(Console.ReadLine());
                Console.WriteLine("Aloita peli painamalla mitä tahansa näppäintä.");
                Console.ReadKey();

                do
                {
                    raha--;
                    silmaluku1 = random.Next(1, 11);
                    silmaluku2 = random.Next(1, 11);
                    silmaluku3 = random.Next(1, 11);
                    Console.WriteLine("Silmäluvut ovat " + silmaluku1 + ", " + silmaluku2 + " ja " + silmaluku3);

                    {
                        if (silmaluku1 == 7 && silmaluku2 == 7 && silmaluku3 == 7)
                        {
                            raha += 3;
                            Console.WriteLine("Planeetat osuivat kohdilleen ja heitit silmäluvun 7 kolmesti! Voitit 3 euroa!");
                            Console.WriteLine("Sinulla on nyt " + raha + " euroa.");
                        }

                        if (silmaluku1 == 7 && silmaluku2 == 7 || silmaluku1 == 7 && silmaluku3 == 7 || silmaluku2 == 7 && silmaluku3 == 7)
                        {
                            raha += 2;
                            Console.WriteLine("Heitit silmäluvun 7 kahdesti! Voitit 2 euroa!");
                            Console.WriteLine("Sinulla on nyt " + raha + " euroa.");
                        }

                        else if (silmaluku1 == 7 || silmaluku2 == 7 || silmaluku3 == 7)
                        {
                            raha++;
                            Console.WriteLine("Heitit silmäluvun 7! Voitit 1 euron!");
                            Console.WriteLine("Sinulla on nyt " + raha + " euroa.");

                        }

                        else
                        {
                            Console.WriteLine("Ei onnistanut. Sinulla on jäljellä " + raha + " euroa.");
                        }

                        Console.WriteLine("Heitä noppaa painamalla Enter.");

                        }

                        Console.ReadKey();

                    } while (raha > 1);

                Console.WriteLine("Hävisit kaikki rahasi kankkulan kaivoon.");
                Console.WriteLine("Peli loppu. Haluatko pelata uudestaan (k/e)");
                retry = Console.ReadLine();

            } while (retry == "k");

            Console.WriteLine("Sulje ikkuna painamalla mitä tahansa näppäintä.");
        }
    }
}
