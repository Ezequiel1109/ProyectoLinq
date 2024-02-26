using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltroWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Categoria> listaCategoria;
        private void Form1_Load(object sender, EventArgs e)
        {
            listaCategoria = new List<Categoria>()
            {
                new Categoria { IdCategoria = 1 , NombreCategoria = "Terror"},
                new Categoria { IdCategoria = 2 , NombreCategoria = "Infantil"},
                new Categoria { IdCategoria = 3 , NombreCategoria = "Accion"},
            };

            DataGrid.DataSource = listaCategoria;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var consulta = (from categoria in listaCategoria
                           where categoria.NombreCategoria.Equals(nombre)
                           select categoria).ToList();

            DataGrid.DataSource = consulta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            DataGrid.DataSource = listaCategoria;
        }
    }
}
