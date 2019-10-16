using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}    {1}", i, x);
                x=x - 1;
            }
            Console.ReadKey();
        }
    }
}
