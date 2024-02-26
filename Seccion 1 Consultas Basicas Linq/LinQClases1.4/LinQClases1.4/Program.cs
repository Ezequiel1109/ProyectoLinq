using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQClases1._4
{
    class Program
    {
        static void Main(string[] args)
        {   //origen de datos
            List<Customers> listaCustomers = new List<Customers>
            {
                new Customers {nombre="David", apellido ="Robinet" , ciudad = "Santiago"},
                new Customers {nombre="Ezequiel", apellido ="Diaz" , ciudad = "Santiago"},
                new Customers {nombre="David", apellido ="Diaz" , ciudad = "Santiago"}
            };

            //seleciona la ciudad, item es un objeto 

            var consulta = from item in listaCustomers
                           where item.ciudad.Equals("Santiago")
                           select item;

            //ejecutar la consulta
            foreach (var item in consulta)
            {
                Console.WriteLine("Nombre : "+ item.nombre + " Apellido :"+ item.apellido + " Ciudad :" + item.ciudad );
            }
            Console.Read();
        }
    }
}
