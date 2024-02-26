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
    public partial class frmMCliente : Form
    {
        public frmMCliente()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpCliente ocliente = new frmPopUpCliente();
            ocliente.Accion = "Nuevo";
            ocliente.ShowDialog();
            if (ocliente.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpCliente ocliente = new frmPopUpCliente();
            ocliente.Accion = "Modificar";
            ocliente.Id = dgvVistaM.CurrentRow.Cells[0].Value.ToString();
            ocliente.ShowDialog();
            if (ocliente.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void frmMCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvVistaM.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(1)).Select(
                p => new
                {
                    p.IDCLIENTE,
                    p.DNICLIENTE,
                    p.NOMBRE,
                    p.APPATERNO,
                    p.APMATERNO,
                    p.TELEFONOFIJO,
                    p.TELEFONOCELULAR
                }).ToList();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvVistaM.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.CLIENTE.Where(p => p.IDCLIENTE.Equals(id));
                foreach (CLIENTE cli in consulta)
                {
                    cli.BHABILITADO = false;
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

        private void Filtro(object sender, EventArgs e)
        {
            dgvVistaM.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(1)&&p.DNICLIENTE.Contains(txtRutM.Text)).Select(
               p => new
               {
                   p.IDCLIENTE,
                   p.DNICLIENTE,
                   p.NOMBRE,
                   p.APPATERNO,
                   p.APMATERNO,
                   p.TELEFONOFIJO,
                   p.TELEFONOCELULAR
               }).ToList();
        }
    }
}
