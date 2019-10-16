using System;
//Diego Raúl Mera Palma
namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                int RSuma = 0;
                long RespuestaFactorial = 1;
                Console.WriteLine("/////////////////////////////////////////////////////////");
                Console.WriteLine("Ingrese el número 1 para salir");
                Console.WriteLine("Ingrese el número 2 para realizar la sumatoria de un número");
                Console.WriteLine("Ingrese el número 3 para realizar el factorial de un número");
                Console.WriteLine("-------------------------------------------------------------");
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Sesión terminada");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un número para realizar el sumatorio");
                        int sumatoria = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= sumatoria; i++)
                        {
                            if (i != sumatoria)
                            {
                                Console.Write("{0}+", i);
                                RSuma = RSuma + i;
                            }
                            else
                            {
                                Console.Write("{0}=", i);
                                RSuma = RSuma + i;
                            }
                        }
                        Console.WriteLine("{0}", RSuma);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el número que desea saber su factorial");
                        int factorial = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0}!=", factorial);
                        for (int i = 1; i <= factorial; i++)

                        {
                            if (i != factorial)

                            {
                                Console.Write("{0}x", i);
                                RespuestaFactorial = RespuestaFactorial * i;
                            }
                            else
                            {
                                Console.Write("{0}=", i);
                                RespuestaFactorial = RespuestaFactorial * i;

                            }
                        }
                        Console.WriteLine("{0}", RespuestaFactorial);

                        break;
                    default:
                        Console.WriteLine("El número es incorrecto");
                        break;
                }
            } while (numero != 1);
            Console.ReadKey();
        }
    }
}
