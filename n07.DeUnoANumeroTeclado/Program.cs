using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Presentar por pantalla los números que hay desde el 1
hasta un número solicitado por teclado.
 */
namespace n07.DeUnoANumeroTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, count = 1;
            Console.WriteLine("Dame un número");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num > 0)
                {
                    Console.WriteLine();
                    while (count <= num)
                    {
                        Console.WriteLine(count);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine();
                    while (count >= num)
                    {
                        Console.WriteLine(count);
                        count--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Dato introducido no válido");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
