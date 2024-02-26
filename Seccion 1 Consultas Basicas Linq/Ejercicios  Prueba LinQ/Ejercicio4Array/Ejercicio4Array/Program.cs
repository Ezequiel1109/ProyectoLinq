using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            var consulta = from score in scores
                           select score;

            Console.WriteLine("El numero maximo es: "+consulta.Max());
            Console.Read();
        }
        
    }
}
