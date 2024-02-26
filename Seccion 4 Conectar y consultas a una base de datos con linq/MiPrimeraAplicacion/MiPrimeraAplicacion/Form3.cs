using CursoLinQ1Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //captura el nombre 
            string nombre = txtNombre.Text;

            dgvEmpleado.DataSource = bd.Empleados.Where(p => p.NOMBRE.Equals(nombre));
        }

        private void Listar()
        {
            dgvEmpleado.DataSource = bd.Empleados;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            txtNombre.Text = "";
        }
    }
}
