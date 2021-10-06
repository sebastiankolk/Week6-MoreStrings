using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string world = "Hello world!";
            for (int i = world.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(world[i]);
            } 
           
        }
    }
}
