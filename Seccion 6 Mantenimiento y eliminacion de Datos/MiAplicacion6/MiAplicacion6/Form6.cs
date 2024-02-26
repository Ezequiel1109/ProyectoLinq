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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form6_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvVista.DataSource = bd.Employees.Where(p => p.BHabilitado.Equals(1)).ToList();
        }

        private void Filtro(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            dgvVista.DataSource = bd.Employees.Where(x => x.BHabilitado.Equals(1)).Where(y => y.FirstName.Contains(nombre)).ToList();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?","Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            { 
                string id = dgvVista.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.Employees.Where(x => x.EmployeeID.Equals(id));

                foreach (Employee emp in consulta)
                {
                    emp.BHabilitado = false;
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmPopUp popup = new frmPopUp();
            popup.Accion = "Nuevo";
            popup.ShowDialog();

            if (popup.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmPopUp popup = new frmPopUp();
            popup.Accion = "Editar";
            popup.Id = dgvVista.CurrentRow.Cells[0].Value.ToString();
            popup.txtCodigo.ReadOnly = true;
            popup.ShowDialog();

            if (popup.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }
    }
}
