using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Imprimir y contar el número de múltiplos de tres que
existen desde el 1 a un número solicitado por teclado. 
 */
namespace n08.MultiplosTresHastaTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, count = 0, aux = 0;
            Console.WriteLine("Introduce un número");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine();
                while (aux < num)
                {
                    if (aux % 3 == 0)
                    {
                        Console.WriteLine(aux);
                        count++;
                    }
                    aux++;
                }
            }
            else
            {
                Console.WriteLine("Dato no válido");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
