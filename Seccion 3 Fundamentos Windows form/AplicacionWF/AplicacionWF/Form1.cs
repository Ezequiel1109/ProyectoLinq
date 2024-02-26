using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWF
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
            //Load cuando carga un formulario

            listaCategoria = new List<Categoria>
            {
                new Categoria { IdCategoria = 1, NombreCategoria = "terror" },
                new Categoria { IdCategoria = 2, NombreCategoria = "accion" }
            };

            IdData.DataSource = listaCategoria;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion
                if (txtCategoria.Text.Equals(""))
                {
                    errorFormulario.SetError(txtCategoria, "Ingrese el id de la categoria");
                    return;
                }
                else
                {
                    errorFormulario.SetError(txtCategoria,"");

                }

                if (txtNombre.Text.Equals(""))
                {
                    errorFormulario.SetError(txtNombre, "Ingrese nombre");
                    return;
                }
                else
                {
                    errorFormulario.SetError(txtNombre, "");

                }
                //Capturar valores
                int idCategoria = int.Parse(txtCategoria.Text);
                string nombre = txtNombre.Text;

                Categoria cat = new Categoria();
                cat.IdCategoria = idCategoria;
                cat.NombreCategoria = nombre;
                listaCategoria.Add(cat);
                //DataSource = null limpia el DataGridView
                IdData.DataSource = null;
                IdData.DataSource = listaCategoria;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error!!");
            }
        }

        private void Limpiar()
        {
            txtCategoria.Text = "";
            txtNombre.Text = "";
        }
    }
}
