using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
           {
               new Empleado { IdEmpleado = 1 , Nombre ="Pedro Flores" , IdModalidad = 1},
               new Empleado { IdEmpleado = 2 , Nombre ="Roberto Flores" , IdModalidad = 2},
               new Empleado { IdEmpleado = 3 , Nombre ="David Flores" , IdModalidad = 2}

           };

            //var consulta = listaEmpleado.Select(p => new { p.Nombre, p.IdModalidad }).OrderBy(x => x.Nombre);
            var consulta = listaEmpleado.OrderBy(p => p.Nombre).Select(x => new { nombre = x.Nombre, idmodalidad = x.IdModalidad });
            foreach (var item in consulta)
            {
                Console.WriteLine(item.nombre + " Tiene un id de modalidad : " + item.idmodalidad);
            }
            Console.Read();
        }
    }
}
