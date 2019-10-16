using System;
//Diego Raúl Mera Palma
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, cantidad = 0;
            float precio, preciofinal, acumulador = 0;
            do
            {
                Console.WriteLine("//////////////////////////////////");
                Console.WriteLine("Ingrese 1 para añadir un producto.");
                Console.WriteLine("Ingrese 0 para finalizar su compra.");
                Console.WriteLine("/////////////////////////////////");
                numero = Convert.ToInt16(Console.ReadLine());
                switch (numero)
                {
                    case 0:
                        Console.WriteLine("Su compra ha finalizado.");
                        Console.WriteLine("El total de su compra es: ${0}", acumulador);
                        Console.WriteLine("///////////////////////////////");
                        break;
                    case 1:
                        Console.WriteLine("Introduzca la cantidad vendida.");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduzca el precio.");
                        precio = Convert.ToSingle(Console.ReadLine());
                        preciofinal = cantidad * precio;
                        acumulador = acumulador + preciofinal;
                        break;
                    default:
                        Console.WriteLine("Ingrese un número que sea válido");
                        break;
                }
            } while (numero != 0);
            Console.ReadKey();
        }
    }
}
