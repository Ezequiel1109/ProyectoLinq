using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio0._8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Categoria> listaCategoria = new List<Categoria>
            {
                new Categoria { IdCategoria = 1, NombreCategoria ="Fruta"},
                new Categoria { IdCategoria = 2, NombreCategoria ="verdura"},
                new Categoria { IdCategoria = 3, NombreCategoria ="Automovil"},
                new Categoria { IdCategoria = 4, NombreCategoria ="Moto"}
            };

            List<Proveedor> listaProveedor = new List<Proveedor>
            {
                new Proveedor { IdProveedor = 1, Nombre="La vega" },
                new Proveedor { IdProveedor = 2, Nombre="Lo valledor" },
            };

            List<Producto> listaProducto = new List<Producto>
            {
                new Producto { IdProducto = 1, Nombre="Piña", IdCategoria=1, IdProveedor=1},
                new Producto { IdProducto = 2, Nombre="Frutillas", IdCategoria=2, IdProveedor=2},
                new Producto { IdProducto = 3, Nombre="Mercedes", IdCategoria=3, IdProveedor=1},
                new Producto { IdProducto = 4, Nombre="Ferrari", IdCategoria=4, IdProveedor=2},
            };

            var consulta = from categoria in listaCategoria
                           join producto in listaProducto
                           on categoria.IdCategoria equals producto.IdCategoria
                           join proveedor in listaProveedor
                           on producto.IdProveedor equals proveedor.IdProveedor
                           select new { producto.Nombre, categoria.NombreCategoria, nombreProveedor = proveedor.Nombre };
            foreach (var item in consulta) {
                Console.WriteLine("El Producto es :"+item.Nombre+" Su Categoria es : " +item.NombreCategoria+" Su Proveedor es : "+item.nombreProveedor);
            }
            Console.Read();
        }

    }
}
