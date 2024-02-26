using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var consulta = from numero in numbers
                           where numero < 5
                           select numero;
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }
    }
}
