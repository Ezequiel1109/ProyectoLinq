using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profesor> listaProfesor = new List<Profesor>
            {
                new Profesor {idProfesor = 1 , nombre = "David" , edad = 24, IdCurso = 1 }
            };

            List<Curso> listaCurso = new List<Curso>
            {
                new Curso {IdCurso = 1 , nombreCurso = "Algebra" }
            };

            var consulta = from profesor in listaProfesor
                           join curso in listaCurso
                           on profesor.IdCurso equals curso.IdCurso
                           select new { profesor.nombre, curso.nombreCurso };


            foreach (var item in consulta)
            {
                Console.WriteLine("El curso " + item.nombreCurso + " es enseñado por " + item.nombre);

            }
            Console.Read();
        }
    }
}
