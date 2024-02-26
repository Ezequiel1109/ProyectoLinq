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
    public partial class frmBuscarE : Form
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public frmBuscarE()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmBuscarE_Load(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(true))
               .Select(
               x => new
               {
                   x.IDEMPLEADO,
                   x.NOMBREEMPLEADO,
                   x.APPATERNO,
                   x.APMATERNO,
                   x.FECHAINICIO
               }

               ).ToList();
        }

        private void Filtro(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            dgvEmpleado.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(true)
            && (p.APPATERNO.Contains(apellido) || p.APMATERNO.Contains(apellido)))
               .Select(
               x => new
               {
                   x.IDEMPLEADO,
                   x.NOMBREEMPLEADO,
                   x.APPATERNO,
                   x.APMATERNO,
                   x.FECHAINICIO
               }

               ).ToList();
        }

        private void ObtenerDatos(object sender, EventArgs e)
        {
            Id = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            NombreCompleto = dgvEmpleado.CurrentRow.Cells[1].Value.ToString() +
               " " + dgvEmpleado.CurrentRow.Cells[2].Value.ToString() + " " +
                dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
