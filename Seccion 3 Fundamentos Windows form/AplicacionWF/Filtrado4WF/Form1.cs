using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrado4WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Categoria> listaCategoria;
        List<Producto> listaProducto;
        private void Form1_Load(object sender, EventArgs e)
        {
            listaCategoria = new List<Categoria>()
            {
                new Categoria { IdCategoria = 1 , NombreCategoria = "Frutas"},
                new Categoria { IdCategoria = 2 , NombreCategoria = "Verduras"},
                new Categoria { IdCategoria = 3 , NombreCategoria = "Medicinas"},
                new Categoria { IdCategoria = 4 , NombreCategoria = "Lapiceros"},
                new Categoria { IdCategoria = 5 , NombreCategoria = "Celulares"}
            };
            cbSeleccionar.DataSource = listaCategoria;
            cbSeleccionar.DisplayMember = "NombreCategoria";
            cbSeleccionar.ValueMember = "IdCategoria";

            listaProducto = new List<Producto>()
            {
                new Producto { IdProducto = 1 , Nombre = "Papaya" , IdCategoria = 1},
                new Producto { IdProducto = 2 , Nombre = "Paracetamol" , IdCategoria = 3},
                new Producto { IdProducto = 3 , Nombre = "Platano" , IdCategoria = 1},
                new Producto { IdProducto = 4 , Nombre = "Lechuga" , IdCategoria = 2},
                new Producto { IdProducto = 5 , Nombre = "Lapiz Pasta" , IdCategoria = 4},
                new Producto { IdProducto = 6 , Nombre = "Iphone" , IdCategoria = 5},
            };

            DataGrid.DataSource = listaProducto;

        }

        private void Filtrar(object sender, EventArgs e)
        {
            int id = int.Parse(cbSeleccionar.SelectedValue.ToString());

            var consulta = (from producto in listaProducto
                            where producto.IdCategoria.Equals(id)
                            select producto).ToList();

            DataGrid.DataSource = consulta;
        }

        private void cbSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
