using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, c, i;

            Console.WriteLine("ingrese el tamaño que tendrá el triangulo");

            y = int.Parse(Console.ReadLine());

            for (i = 0; i < y; i++)
            {

                for (x = 0; x < y; x++) ;
                {
                    Console.Write("\n ");
                    for (c = 0; c < y - i; c++)
                    {
                        Console.Write(" ");
                    }
                    for (int e = 0; e <= i * 2; e++)
                    {
                        Console.Write("*");
                    }

                }

            }
            Console.ReadKey();
        }
    }

}