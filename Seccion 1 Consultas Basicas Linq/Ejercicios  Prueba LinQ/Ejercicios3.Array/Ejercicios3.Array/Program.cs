using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =  { "cherry", "apple", "blueberry" };

            var consulta = from frutas in fruits
                           orderby frutas ascending
                           select frutas;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
