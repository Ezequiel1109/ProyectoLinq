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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            dgvVista.DataSource = bd.Regions.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina el registro que esta en la bd
            if (MessageBox.Show("Desea Eliminar ?", "Aviso", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string idRegion = dgvVista.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.Regions.Where(p => p.RegionID.Equals(idRegion));

                foreach (Region reg in consulta)
                {
                    bd.Regions.DeleteOnSubmit(reg);
                }
                try
                {
                    bd.SubmitChanges();
                    Listar();
                    MessageBox.Show("Se elimino correctamente");
                }
                catch
                {
                    MessageBox.Show("Error en la solicitud");
                }
            }
        }
    }
}
