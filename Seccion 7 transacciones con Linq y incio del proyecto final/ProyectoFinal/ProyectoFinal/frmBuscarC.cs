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
    public partial class frmBuscarC : Form
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public frmBuscarC()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();

        private void frmBuscarC_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)).
             Select(
             x => new
             {
                 x.IDCLIENTE,
                 x.DNICLIENTE,
                 x.NOMBRE,
                 x.APPATERNO,
                 x.APMATERNO,
                 x.TELEFONOCELULAR
             }


             ).ToList();
        }

        private void filtrarDNI(object sender, EventArgs e)
        {
            string dni = txtdni.Text;
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
            && p.DNICLIENTE.Contains(dni)).
                Select(
                x => new
                {
                    x.IDCLIENTE,
                    x.DNICLIENTE,
                    x.NOMBRE,
                    x.APPATERNO,
                    x.APMATERNO,
                    x.TELEFONOCELULAR
                }


                ).ToList();
        }

        private void filtrarApellido(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            dgvCliente.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
            && (p.APPATERNO.Contains(apellido) || p.APMATERNO.Contains(apellido)))
               .Select(
               x => new
               {
                   x.IDCLIENTE,
                   x.DNICLIENTE,
                   x.NOMBRE,
                   x.APPATERNO,
                   x.APMATERNO,
                   x.TELEFONOCELULAR
               }

               ).ToList();
        }

        private void mostrarDatos(object sender, EventArgs e)
        {
            Id = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            NombreCompleto = dgvCliente.CurrentRow.Cells[2].Value.ToString() + " " +
                dgvCliente.CurrentRow.Cells[3].Value.ToString() + " " +
                dgvCliente.CurrentRow.Cells[4].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
