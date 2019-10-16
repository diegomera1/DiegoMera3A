using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, y, i;

            Console.WriteLine("Medida de un lado del rombo");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (x = 0; x < n; x++) ;
                {
                    Console.Write("\n ");
                    for (y = 0; y < n - i; y++)
                    {
                        Console.Write(" ");
                    }
                    for (int e = 0; e <= i * 2; e++)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
            int lactual, esp, ast;
            for (lactual = 2; lactual <= n; lactual++)
            {
                Console.Write("  ");
                for (esp = 1; esp < lactual; esp++)
                {
                    Console.Write(" ");
                }
                for (ast = 0; ast < ((n - lactual + 1) * 2) - 1; ast++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
