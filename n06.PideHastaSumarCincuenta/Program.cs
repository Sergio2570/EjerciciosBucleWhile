using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 Pide números por teclado, hasta que sumen 50 o más.
 */
namespace n06.PideHastaSumarCincuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, total = 0;
            Console.WriteLine("Dame números hasta sumar 50");
            while (total < 50)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Introducido = {num}");
                    total = total + num;
                    Console.WriteLine($"Total = {total}");
                }
                else
                {
                    Console.WriteLine("Dato no válido");
                    Console.WriteLine($"Total = {total}");
                }
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
