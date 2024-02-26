using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ModalidadContrato> listaModalidad = new List<ModalidadContrato>
            {
                new ModalidadContrato { IdModalidad = 1, NombreModalidad = "CAS"},
                new ModalidadContrato { IdModalidad = 2, NombreModalidad = "Temporal"}
            };
            //elaborar la consulta fuente de datos 
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado { IdEmpleado = 1 , Nombre = "David" , IdModalidad = 1 },
                new Empleado { IdEmpleado = 1 , Nombre = "Carolina" , IdModalidad = 1 },
                new Empleado { IdEmpleado = 2 , Nombre = "Deborah" , IdModalidad = 2 },
                new Empleado { IdEmpleado = 2 , Nombre = "Rafael" , IdModalidad = 2 }
            };

            //consulta lamdla
            var consulta = listaEmpleado.Where(p => p.IdModalidad.Equals(2));
            //ejecucion
            foreach (var item in consulta)
            {
                Console.WriteLine("El nombre es : "+ item.Nombre);
            }
            Console.Read();

        }
    }
}
