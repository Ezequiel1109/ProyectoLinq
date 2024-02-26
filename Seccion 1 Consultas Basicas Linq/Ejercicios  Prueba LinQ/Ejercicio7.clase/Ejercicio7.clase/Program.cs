using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.clase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {

                new Student {First="Svetlana", Last="Omelchenko", ID=111},
                new Student {First="Claire", Last="O'Donnell", ID=112},
                new Student {First="Sven", Last="Mortensen", ID=113},
                new Student {First="Cesar", Last="Garcia", ID=114},
                new Student {First="Debra", Last="Garcia", ID=115}

            };
            var consulta = from estudiante in students
                           orderby estudiante.Last ascending
                           select estudiante;
            foreach (var item in consulta)
            {
                Console.WriteLine("Mi Nombre : " + item.First + " Mi Apellido es : " + item.Last);
            }
            Console.Read();

        }
    }
}
