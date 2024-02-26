using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customers> listaCustomers = new List<Customers>
            {
                new Customers { Nombre = "David" , Apellido = "Robinet" , Cuidad = "Suiza"},
                new Customers { Nombre = "Rafa" , Apellido = "Robinet" , Cuidad = "Alemania"},
                new Customers { Nombre = "Deborah" , Apellido = "Robinet" , Cuidad = "Brasil"},
                new Customers { Nombre = "Carolina" , Apellido = "Robinet" , Cuidad = "Jamaica"},
            };
            //lambdam
            var consulta = listaCustomers.Select(p => p.Nombre);
            //ejecutar
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
