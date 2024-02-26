using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sexo> listaSexo = new List<Sexo>
            {
                new Sexo { IdSexo = 1, NombreS = "Masculino"},
                new Sexo { IdSexo = 2, NombreS = "Femenino"}
            };
            List<ModalidadContrato> listaContrato = new List<ModalidadContrato>
            {
                new ModalidadContrato { IdModalidad = 1, nombreM = "Express"},
                new ModalidadContrato { IdModalidad = 2, nombreM = "Ligero"}
            };
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado { Nombre="Andrea" ,IdSexo=2 ,IdModalidad=2},
                new Empleado { Nombre="Jorge" ,IdSexo=1 ,IdModalidad=1}
            };

            var consulta = from sexo in listaSexo
                           join empleado in listaEmpleado
                           on sexo.IdSexo equals empleado.IdSexo
                           join modalidad in listaContrato
                           on empleado.IdModalidad equals modalidad.IdModalidad
                           select new { empleado.Nombre, sexo.NombreS, modalidad.nombreM };

            foreach (var item in consulta)
            {
                Console.WriteLine(item.Nombre+ " " + item.NombreS + " " + item.nombreM);
            }
            Console.Read();
        }
    }
}
