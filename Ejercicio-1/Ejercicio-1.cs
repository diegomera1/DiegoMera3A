using System;
//Diego Raúl Mera Palma
namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de número que quiere comparar para saber cual es el mayor");
            int cant = Convert.ToInt16(Console.ReadLine()), mayor = 0;
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese uno de los números que desea comparar");
                int num = Convert.ToInt16(Console.ReadLine());
                if (num > mayor)
                { mayor = num; }
            }
            Console.WriteLine("El número mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}