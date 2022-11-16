using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Dado un número introducido por teclado que debe ser
menor que 100, presentar todos los números impares que van
desde él hasta el 100.
 */
namespace n04.MenorQueCienACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número menor que 100");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                if (num1 < 100)
                {
                    if (num1 % 2 == 0)
                    {
                        num1++;
                    }
                    while (num1 < 100)
                    {
                        Console.WriteLine(num1);
                        num1 = num1 + 2;
                    }
                }
                else
                {
                    Console.WriteLine("Es 100 o mayor que 100");
                }
            }
            else
            {
                Console.WriteLine("El dato introducido no es válido");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}