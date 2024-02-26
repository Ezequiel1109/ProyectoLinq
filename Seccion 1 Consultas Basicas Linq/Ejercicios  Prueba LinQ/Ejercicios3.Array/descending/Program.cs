using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descending
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "cherry", "apple", "blueberry" };

            var consulta = from frutas in fruits
                           orderby frutas descending
                           select frutas;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
