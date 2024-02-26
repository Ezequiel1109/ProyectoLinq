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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Form4_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvEmpleado.DataSource = bd.Empleados;
        }

        private void Filtro(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var consulta = bd.Empleados.Where(p => p.NOMBRE.Contains(nombre));
            dgvEmpleado.DataSource = consulta;
        }
    }
}
