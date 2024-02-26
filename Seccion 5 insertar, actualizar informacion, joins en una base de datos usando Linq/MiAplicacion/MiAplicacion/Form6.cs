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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form6_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dgvVista.DataSource = bd.Regions.ToList();
        }

        private void ObtenerDatos(object sender, DataGridViewCellEventArgs e)
        {
            //devuelve la fila selecionada con el currentrow

            string id = dgvVista.CurrentRow.Cells[0].Value.ToString();
            string nombre = dgvVista.CurrentRow.Cells[1].Value.ToString();

            txtId.Text = id;
            txtNombre.Text = nombre;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals(""))
            {
                errorRegion.SetError(txtNombre, "Ingrese Nombre");
                return;
            }
            else
            {
                errorRegion.SetError(txtNombre, "");
            }
            //obtoner la data desde la bd
            var consulta = bd.Regions.Where(p => p.RegionID.Equals(txtId.Text));

            //Editar(leemos la informacion que mos trae desde la base de datos)
            foreach (Region oRegion in consulta)
            {
                oRegion.RegionID = int.Parse(txtId.Text);
                oRegion.RegionDescription = txtNombre.Text;
            }
            try
            {
                //Recien comienza a editar
                bd.SubmitChanges();
                Listar();

                MessageBox.Show("Se edito correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
