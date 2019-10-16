using System;
//Diego Raúl Mera Palma
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de un lado de su cuadrado.");
            int espacio = Convert.ToInt16(Console.ReadLine());
            for (int a = 0; a < espacio; a++)
            {
                if (a == 0 || a == espacio - 1)
                {
                    for (int b = 0; b < espacio; b++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int c = 0; c < espacio; c++)
                    {
                        if (c == 0 || c == espacio - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}