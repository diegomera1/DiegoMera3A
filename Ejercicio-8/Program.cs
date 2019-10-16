using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3;
            Console.WriteLine("Escriba un número positivo  ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("//////////////////////////");
            if (numero > 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    Console.Write("{0}    ", i);
                    if (x <= numero)
                    {
                        Console.Write("{0}     ", x);
                        x = x + 2;
                    }
                    if (y <= numero)
                    {
                        Console.Write("{0}", y);
                        y = y + 3;
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no es correcto");
            }
            Console.ReadKey();
        }
    }
}