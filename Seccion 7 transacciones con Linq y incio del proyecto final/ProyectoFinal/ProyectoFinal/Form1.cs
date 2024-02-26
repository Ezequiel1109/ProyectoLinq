using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMCliente ocliente = new frmMCliente();
            ocliente.ShowDialog();
        }

        private void cineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCineM ocine = new frmCineM();
            ocine.ShowDialog();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeliculaM opelicula = new frmPeliculaM();
            opelicula.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalaM osala = new frmSalaM();
            osala.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleadoM oempleado = new frmEmpleadoM();
            oempleado.ShowDialog();
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionM ofuncion = new frmFuncionM();
            ofuncion.ShowDialog();
        }
    }
}
