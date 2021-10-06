using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");

            string eesnimi = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonna nimi");

            string perekonnanimi = Console.ReadLine();

            Console.WriteLine($"Tere {eesnimi[0]}.{perekonnanimi[0]}.");

        }
    }
}
