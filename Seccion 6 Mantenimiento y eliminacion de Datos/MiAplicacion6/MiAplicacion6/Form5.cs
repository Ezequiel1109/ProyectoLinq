using NorthwindContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiAplicacion6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            PopUP rPopUp = new PopUP();
            rPopUp.Accion = "Nuevo";
            rPopUp.ShowDialog();

            if (rPopUp.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvVista.DataSource = bd.Territories.Where(y => y.BHabilitado.Equals(1)).Select(p => new { p.TerritoryID,p.TerritoryDescription});
        }

        private void Filtro(object sender, EventArgs e)
        {
            string valor = txtNombre.Text;
            dgvVista.DataSource = bd.Territories.Where(p=>p.TerritoryDescription.Contains(valor)).ToList();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            PopUP frmPopUp = new PopUP();
            frmPopUp.Accion = "Editar";
            frmPopUp.id = id;
            frmPopUp.txtId.ReadOnly = true;
            frmPopUp.ShowDialog();
            if (frmPopUp.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }
        string id;
        private void ObtenerDato(object sender, DataGridViewCellEventArgs e)
        {
          id = dgvVista.CurrentRow.Cells[0].Value.ToString();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) {
                var consulta = bd.Territories.Where(p => p.TerritoryID.Equals(id));

                foreach (Territory ter in consulta)
                {
                    ter.BHabilitado = false;
                }
                try
                {
                    bd.SubmitChanges();
                    Listar();
                    MessageBox.Show("Se elimino correctamente");
                } catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
