using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[7] { 1 ,2, 3, 4, 5, 6, 7 };
            var consulta = from nota in notas
                           where nota > 1
                           select nota;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
