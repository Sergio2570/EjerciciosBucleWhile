using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Dados dos números introducidos por teclado, mostrar los
números naturales que hay entre ambos.
 */
namespace n10.NumerosEntre2Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, count;
            Console.WriteLine("Dame 2 números");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine(); //Espacio entre datos solicitados y datos impresos por pantalla
                    if (num1 < num2)
                    {
                        count = num1;
                        while (count <= num2)
                        {
                            Console.WriteLine(count);
                            count++;
                        }
                    }
                    else
                    {
                        count = num2;
                        while (count <= num1)
                        {
                            Console.WriteLine(count);
                            count++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Dato inválido");
                }
            }
            else
            {
                Console.WriteLine("Dato inválido");
            }
            Console.WriteLine("\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
