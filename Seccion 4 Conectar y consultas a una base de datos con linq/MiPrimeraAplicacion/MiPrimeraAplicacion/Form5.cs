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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Form5_Load(object sender, EventArgs e)
        {
            Listar();

        }
        private void Listar()
        {
            dgvEmpleado.DataSource = bd.Empleados;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            decimal numero1 = txtRango1.Value;
            decimal numero2 = txtRango2.Value;

            var consulta = bd.Empleados.Where(p => p.EDAD > numero1 && p.EDAD < numero2);
            dgvEmpleado.DataSource = consulta;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            txtRango1.Value = 0;
            txtRango2.Value = 0;
        }
    }
}
    