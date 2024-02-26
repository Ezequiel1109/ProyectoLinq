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
    public partial class frmCineM : Form
    {
        public frmCineM()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpCine ocine = new frmPopUpCine();
            ocine.Accion = "Nuevo";
            ocine.ShowDialog();
            if (ocine.DialogResult.Equals(DialogResult.OK)) 
            {
                Listar();
            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpCine ocine = new frmPopUpCine();
            ocine.Accion = "Modificar";
            ocine.Id = dgvVistaC.CurrentRow.Cells[0].Value.ToString();
            ocine.ShowDialog();
            if (ocine.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }

        }

        private void frmCineM_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar() 
        {
            dgvVistaC.DataSource = bd.CINE.Where(x => x.BHABILITADO.Equals(1)).Select(p => new
            {
                p.IDCINE,
                p.NOMBRE,
                p.DIRECCION
            }).ToList();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvVistaC.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(id));
                foreach (CINE cli in consulta)
                {
                    cli.BHABILITADO = 0;
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
            dgvVistaC.DataSource = bd.CINE.Where(x => x.BHABILITADO.Equals(1) && x.NOMBRE.Contains(txtNombreM.Text)).Select(p => new
            {
                p.IDCINE,
                p.NOMBRE,
                p.DIRECCION
            }).ToList();
        }
    }
}
