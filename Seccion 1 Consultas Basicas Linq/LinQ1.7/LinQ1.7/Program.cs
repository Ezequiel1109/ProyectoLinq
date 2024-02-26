using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado  { nombreCompleto = "Carolina", ciudad = "Santiago" , sueldo = 600000 },
                new Empleado  { nombreCompleto = "Deborah", ciudad = "Puente Alto" , sueldo = 500000 },
                new Empleado  { nombreCompleto = "Adriana", ciudad = "Maria Pinto" , sueldo = 700000 }
            };
            var consulta = from empleado in listaEmpleado
                           select empleado.nombreCompleto + " Gana : " + empleado.sueldo;

            foreach (var item in consulta) {
                Console.WriteLine(item);
            }
            Console.Read();
        }


        
    }
}
