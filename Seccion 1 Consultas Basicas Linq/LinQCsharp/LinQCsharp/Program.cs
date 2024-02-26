using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Origen de Datos 
            // Array de datos
            int[] scores = new int[] { 97, 92, 81, 60 };
            //Consulta
            var consulta = from score in scores
                           where score > 80
                           select score;
            //Definicion de la consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
