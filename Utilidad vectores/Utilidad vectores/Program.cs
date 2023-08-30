using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Utilidad_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de utilidad de los vectores");

            int n;
            int[] Edad = new int[10];

            do
            {
                Console.WriteLine("¿Cuantas edades desea guardar en el vector? Max = 10 ");
                n = int.Parse(Console.ReadLine());
                if (n < 0 && n > 10)
                {
                    Console.WriteLine("Tamaño inválido. Debe estar entre 1 y 10.");
                }
            } while (n<0 || n>10);


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inngre la edad para la casilla " + "[ "+ (i+1) + " ]");
                Edad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elementos ingresados:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Elemento {i}: {Edad[i]}");
            }
            Console.WriteLine("\nPulse una tecla para salir..."); Console.ReadKey();
        }
    }
}
