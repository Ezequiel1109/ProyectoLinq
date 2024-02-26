using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnoNotas = new List<Alumno>
            {
                new Alumno { NombreCompleto = "Carolina Robinet", Notas = new List<int> {60,65,70,55 } },
                new Alumno { NombreCompleto = "Deborah Robinet", Notas = new List<int> {65,68,70,50 } },
                new Alumno { NombreCompleto = "Adrana Diaz", Notas = new List<int> {62,70,70,65 } },
            };
            var consulta = from alumno in alumnoNotas
                           select new { nombre = alumno.NombreCompleto, primeranota = alumno.Notas[0] };

            foreach (var item in consulta)
            {
                Console.WriteLine("Nombre del Alumno: "+item.nombre+" Primera Nota : "+item.primeranota );
            }
            Console.Read();

        }
    }
}
