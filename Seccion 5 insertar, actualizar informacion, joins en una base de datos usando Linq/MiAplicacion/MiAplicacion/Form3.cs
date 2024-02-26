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

namespace MiAplicacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Listar()
        {
            dgvVista.DataSource = bd.Regions.OrderBy(p => p.RegionID).ToList();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
  
            int id = int.Parse(txtId.Text);
            int nveces = (bd.Regions.Where(p => p.RegionID.Equals(id))).Count();

            if (nveces == 1)
            {
                MessageBox.Show("Ya Existe ese ID");
                return;
            }
            string nombre = txtNombre.Text;
            Region reg = new Region
            {
                RegionID = id,
                RegionDescription = nombre
            };
            bd.Regions.InsertOnSubmit(reg);
            //en caso de que se caiga la aplicacion, esta pueda mostrar un mensaje
            try
            {
                bd.SubmitChanges();
                Listar();
                Limpiar();
                MessageBox.Show("Se Agrego Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error");
            }
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
        } 
    }
}
