using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtrado2WF
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
                new Categoria { IdCategoria = 3 , NombreCategoria = "Accion"}
            };

            DataGrid.DataSource = listaCategoria;
        }

        private void Filtrar(object sender, EventArgs e)
        {
            var consulta = (from categoria in listaCategoria
                            where categoria.NombreCategoria.Contains(txtNombre.Text)
                            select categoria).ToList();

            DataGrid.DataSource = consulta;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
