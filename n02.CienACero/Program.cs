using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Presenta por pantalla los números del 100 al 0.
namespace n02.CienACero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            while (num1 >= 0)
            {
                Console.WriteLine(num1);
                num1--;
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
