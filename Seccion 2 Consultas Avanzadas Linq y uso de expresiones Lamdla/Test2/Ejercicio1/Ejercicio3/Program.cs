using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            var consulta = numbers.Where(p => p > 5);

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

