using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");

            string eesnimi = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonna nimi");

            string perekonnanimi = Console.ReadLine();

            string kokku = $"{eesnimi}{perekonnanimi}".ToLower();
            int Counter = 0;
           /* foreach (char c in kokku)
            {
                if (c == 'a')
                {
                    Counter++;
                }
            }
            int a = Counter;
            Console.WriteLine("Sul on {a} 'a' täht/e"); */
           for(int i = 0; i < kokku.Length; i++)
            {
                if (kokku[i] == 'a')
                {
                    Counter++;
                }
            }
           if(Counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {Counter} 'a' täht");
            }
           else
            {
                Console.WriteLine($"Sinu nimes on {Counter} 'a' tähte");
            }
        }
    }
}
