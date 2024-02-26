using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumno = new List<Alumno>
            {
                new Alumno { IdAlumno = 1 , Nombre = "Algebra"},
                new Alumno { IdAlumno = 2 , Nombre = "Aritmetica"},
                new Alumno { IdAlumno = 3 , Nombre = "Geometria"}
            };

            var consulta = listaAlumno.Select(p => p.Nombre);

            foreach (var item in consulta)
            {
                Console.WriteLine("La asignatura es : " +item);
            }
            Console.Read();
        }
    }
}
