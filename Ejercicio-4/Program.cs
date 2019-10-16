using System;

//Diego Raúl Mera Palma
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, sueldo = 0;

            do
            {
                Console.WriteLine("///////////////////////////////");
                Console.WriteLine("Ingrese 1 para calcular el salario");
                Console.WriteLine("Ingrese 0 para salir");
                Console.WriteLine("////////////////////////////////");
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 0:
                        Console.WriteLine("Su sesión ha finalizado");
                        break;
                    case 1:
                        Console.WriteLine("Ingrese las horas que se ha trabajado");
                        int horas = Convert.ToInt32(Console.ReadLine());
                        if (horas > 35)
                        {
                            int extra = horas - 35;
                            sueldo = 525 + (extra * 22);
                        }
                        else
                        {
                            sueldo = horas * 15;

                        }
                        Console.WriteLine("Su salario es de: ${0}", sueldo);
                        break;
                    default:
                        Console.WriteLine("Ingrese un número válido");
                        break;
                }
            } while (numero != 0);
            Console.ReadKey();
        }
    }
}
