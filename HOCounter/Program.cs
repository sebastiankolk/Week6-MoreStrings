using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string world = $"Hello, world!".ToLower();
            int Counter = 0;
            int Counter1 = 0;
            int Counter2 = 0;
            for (int i = 0; i < world.Length; i++)
            {
                if (world[i] == 'h')
                {
                    Counter++;
                }
                if (world[i] == 'l')
                {
                    Counter1++;
                }
                if (world[i] == 'o')
                {
                    Counter2++;
                }
            }
            Console.WriteLine($"Hello worldis on {Counter} h {Counter1} l ja {Counter2} o tähte. ");
        }   
    }
}
