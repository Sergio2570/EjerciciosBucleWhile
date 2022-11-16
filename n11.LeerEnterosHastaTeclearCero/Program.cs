using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Leer números enteros hasta teclear cero, y nos muestre el
máximo, el mínimo y la media de todos ellos.
 */
namespace n11.LeerEnterosHastaTeclearCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0, num = 1, max = 0, min = 2147483647, suma = 0;
            decimal media = 0;
            Console.WriteLine("Dame números a sumar (Pulsa 0 para salir)");
            while (num != 0)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    suma = suma + num;
                    count++;
                    if (num < min)
                    {
                        min = num;
                    }
                    else
                    {
                        if (max < num)
                        {
                            max = num;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dato inválido");
                }
            }
            media = suma / count;
            Console.WriteLine($"\nEl menor es {min}, el mayor es {max} y la media es {media}");
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
