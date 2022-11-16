using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Presenta por pantalla los números del 1 al 100.
namespace n01.CeroACien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            while (num1 <= 100)
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
