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
using Region = NorthwindContext.Region;

namespace MiAplicacion6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvVista.DataSource = bd.Regions.Where(p => p.Bhabilitado.Equals(1));
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                //para seleccionar toda un fila
                string idRegion = dgvVista.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.Regions.Where(p => p.RegionID.Equals(idRegion));

                foreach (Region reg in consulta)
                {
                    reg.Bhabilitado = false;
                }
                try
                {
                    bd.SubmitChanges();
                    Listar();
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
        }
    }
}
