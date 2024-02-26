using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> listaAlumno = new List<Alumno>
            {
                new Alumno { IdAlumno = 1 , Nombre="David"},
                new Alumno { IdAlumno = 2 , Nombre="Robinet"},
                new Alumno { IdAlumno = 3 , Nombre="Ezequiel"},
                new Alumno { IdAlumno = 4 , Nombre="Diaz"}
            };
            //expresiones lamdlan
            var consulta = listaAlumno.Select(p => p.Nombre);
            foreach (var item in consulta)
            {
                Console.WriteLine("El curso favorito del alumno es : "+ item );
            }
            Console.Read();
        }
    }
}
