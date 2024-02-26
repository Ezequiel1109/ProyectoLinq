using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado { Nombre = "Andres" , Sexo = "Masculino" , Sueldo = 630000},
                new Empleado { Nombre = "David" , Sexo = "Masculino" , Sueldo = 1630000},
                new Empleado { Nombre = "Carolina" , Sexo = "Femenino" , Sueldo = 2630000},
                new Empleado { Nombre = "Deborah" , Sexo = "Femenino" , Sueldo = 3630000}
            };

            var consulta = listaEmpleado.Where(x => x.Sueldo > 630000 && x.Sexo.Equals("Femenino")).Select(p => new { p.Nombre , sueldoAnual = p.Sueldo * 12 });

            foreach (var item in consulta)
            {
                Console.WriteLine(item.Nombre + " Gana " + item.sueldoAnual);
            }
            Console.Read();
        }
    }
}
