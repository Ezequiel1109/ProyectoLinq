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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form4_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dgvVista.DataSource = bd.Territories.Where(p =>p.BHabilitado.Equals(1)).ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string idTerritorio = dgvVista.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.Territories.Where(p => p.TerritoryID.Equals(idTerritorio));

                foreach (var item in consulta)
                {
                    item.BHabilitado = false;
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
