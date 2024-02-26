using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 18, 25, 19, 16, 21, 80 };

            var consulta = from score in scores
                           where score > 20
                           select score;

            foreach (var item in consulta ) {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
