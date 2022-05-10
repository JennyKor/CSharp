using System;
using System.IO;

namespace kayttajanNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostopolku = "c:/temp/nimet.txt";
            TextWriter tw = new StreamWriter(tiedostopolku);

            string nimi;
            string rivi;
            string vikarivi = "";

            do
            {
                Console.WriteLine("Anna nimi:");
                nimi = Console.ReadLine();
                if (nimi != "") // niin kauan kuin nimi ei ole tyhjä...
                {
                    tw.WriteLine(nimi); // ...tallenna nimi
                }

            } while (nimi != ""); // toistetaan niin kauan kuin nimi ei ole tyhjä

            Console.WriteLine("Nimet tallennettu.");
            tw.Close();

            TextReader tr = new StreamReader(tiedostopolku);

            while ((rivi = tr.ReadLine()) != null) // luetaan rivejä niin kauan kuin niitä on

            {
                Console.WriteLine(rivi); // kirjoittaa rivin konsoliin
                vikarivi = rivi; // korvaa vikarivi-muuttujan luetulla rivi-muuttujalla jokaisella kierroksella
            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(vikarivi); // kirjoittaa viimeisimmän annetun arvon muuttujalle
            Console.ResetColor();

            tr.Close();


        }
    }
}
