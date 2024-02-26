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
    public partial class frmEmpleadoM : Form
    {
        public frmEmpleadoM()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpEmpleado oempleado = new frmPopUpEmpleado();
            oempleado.Accion = "Nuevo";
            oempleado.ShowDialog();
            if (oempleado.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpEmpleado oempleado = new frmPopUpEmpleado();
            oempleado.Accion = "Modificar";
            oempleado.Id = dgvVistaE.CurrentRow.Cells[0].Value.ToString();
            oempleado.lblContraseña.Visible = false;
            oempleado.txtContraseña.Visible = false;
            oempleado.ShowDialog();
            if (oempleado.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }

        }
        private void Listar() 
        {
            dgvVistaE.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(1)).Select(
                p => new 
                { 
                    p.IDEMPLEADO,
                    p.NOMBREEMPLEADO,
                    p.APPATERNO,
                    p.APMATERNO,
                    p.FECHAINICIO
                }).ToList();
        }

        private void frmEmpleadoM_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Filtrar(object sender, EventArgs e)
        {
            dgvVistaE.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(1)&& p.NOMBREEMPLEADO.Contains(txtNombreM.Text)).Select(
               p => new
               {
                   p.IDEMPLEADO,
                   p.NOMBREEMPLEADO,
                   p.APPATERNO,
                   p.APMATERNO,
                   p.FECHAINICIO
               }).ToList();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvVistaE.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(id));
                foreach (EMPLEADO emp in consulta)
                {
                    emp.BHABILITADO = false;
                }
                try
                {
                    bd.SubmitChanges();
                    Listar();
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
        }
    }
}
