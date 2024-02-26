using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ModalidadContrato> listaContrato = new List<ModalidadContrato>
            {
                new ModalidadContrato {idModalidad= 1, NombreModalidad="CAS" },
                new ModalidadContrato {idModalidad= 2, NombreModalidad="Temporal" }
            };
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado { idEmpleado = 1, nombre="David", idModalidad =1},
                new Empleado { idEmpleado = 2, nombre="Caro", idModalidad =2},
                new Empleado { idEmpleado = 3, nombre="Rafa", idModalidad =1},
                new Empleado { idEmpleado = 4, nombre="Deborah", idModalidad =2}
            };

            var consulta = from modalidad in listaContrato
                           join empleado in listaEmpleado on
                           modalidad.idModalidad equals empleado.idModalidad
                           select new { nombreEmpleado = empleado.nombre, nombreModalidad = modalidad.NombreModalidad};
            foreach (var item in consulta)
            {
                Console.WriteLine(item.nombreEmpleado + " es " + item.nombreModalidad);
            }
            Console.Read();

            

        }
    }
}
