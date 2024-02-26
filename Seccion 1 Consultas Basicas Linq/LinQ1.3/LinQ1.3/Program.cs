using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 10, 11, 12, 13 };

            var consulta = from numero in numeros
                           where numero % 2 == 0
                           select numero;

            Console.WriteLine("Numero de elementos del array" + consulta.Count());
            Console.WriteLine("El numero maximo es" + consulta.Max());
            Console.WriteLine("Promedio" + consulta.Average());
            Console.WriteLine("Primer resultado"+consulta.First());
            Console.Read();
        }
    }
}
