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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cbOpcion.SelectedIndex = 0;
            Listar();
        }
        private void Listar()
        {
            dgvVista.DataSource = bd.Empleados;
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = cbOpcion.Text;
            string valor = txtValor.Text;
            if (nombre.Equals("Id"))
            {
              dgvVista.DataSource =  bd.Empleados.Where(p => p.CODIGO.Equals(valor));
            }
            else if (nombre.Equals("Nombre"))
            {
              dgvVista.DataSource = bd.Empleados.Where(p => p.NOMBRE.Equals(valor));
            }
            else if (nombre.Equals("ApPaterno"))
            {
              dgvVista.DataSource = bd.Empleados.Where(p => p.APPATERNO.Equals(valor));
            }
            else
            {
              dgvVista.DataSource = bd.Empleados.Where(p => p.APMATERNO.Equals(valor));
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void cbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
