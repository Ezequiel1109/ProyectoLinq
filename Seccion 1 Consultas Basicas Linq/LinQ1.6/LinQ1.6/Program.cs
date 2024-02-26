using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado { nombre ="David", apellido = "Robinet", sueldo =1500},
                new Empleado { nombre ="Ezequiel", apellido = "Perez", sueldo =1800},
                new Empleado { nombre ="David", apellido = "Diaz", sueldo =2000}
            };

            //ganan mas de 1500 y ordenar por apellido

            var consulta = from empleado in listaEmpleado
                           where empleado.sueldo > 1500
                           orderby empleado.apellido ascending
                           select empleado;

            //ejecutar la consulta
            foreach (var item in consulta) {
                Console.WriteLine("Apellido : "+ item.apellido + " Sueldo : "+item.sueldo);
            }
            Console.Read();
        }
    }
}
