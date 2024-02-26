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
    public partial class frmSalaM : Form
    {
        public frmSalaM()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();

        private void frmSalaM_Load(object sender, EventArgs e)
        {
            Listar();
            cbCine.DataSource = bd.CINE.ToList();
            cbCine.DisplayMember = "NOMBRE";
            cbCine.ValueMember = "IDCINE";


        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpSala frmsala = new frmPopUpSala();
            frmsala.Accion = "Nuevo";
            frmsala.ShowDialog();
            if (frmsala.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }

        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpSala frmsala = new frmPopUpSala();
            frmsala.Accion = "Modificar";
            frmsala.Id = dgvSala.CurrentRow.Cells[0].Value.ToString();
            frmsala.ShowDialog();
            if (frmsala.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void Listar() 
        {
            dgvSala.DataSource = (from sala in bd.SALA
                                  join cine in bd.CINE
                                  on sala.IDCINE equals cine.IDCINE
                                  where sala.BHABILITADO.Equals(1)
                                  select new
                                  {
                                      sala.IDSALA,
                                      cine.NOMBRE,
                                      sala.NUMBUTACAS,
                                      sala.NUMEROCOLUMNAS,
                                      sala.NUMEROFILAS
                                  }).ToList();

        }

        private void Filtro(object sender, EventArgs e)
        {
            int idcine = int.Parse(cbCine.SelectedValue.ToString());
            dgvSala.DataSource = (from sala in bd.SALA
                                  join cine in bd.CINE
                                  on sala.IDCINE equals cine.IDCINE
                                  where sala.BHABILITADO.Equals(1) && sala.IDCINE.Equals(idcine)
                                  select new
                                  {
                                      sala.IDSALA,
                                      cine.NOMBRE,
                                      sala.NUMBUTACAS,
                                      sala.NUMEROCOLUMNAS,
                                      sala.NUMEROFILAS
                                  }).ToList();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvSala.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(id));
                foreach (SALA sal in consulta)
                {
                    sal.BHABILITADO = false;
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
