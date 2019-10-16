using System;
//Diego Raúl Mera Palma
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 15; x++)
            {
                Console.WriteLine("///////////////////////////////////////");
                for (int b = 1; b <= 12; b++)
                {
                    Console.WriteLine("{0}*{1}={2}", x, b, b * x);
                }
                Console.WriteLine("///////////////////////////////////////");
            }
            Console.ReadKey();
        }
    }
}
