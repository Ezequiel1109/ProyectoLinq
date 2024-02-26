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

namespace MiAplicacion
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form7_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = bd.Categories.ToList();
            cbCategoria.DisplayMember = "CategoryName";
            cbCategoria.ValueMember = "CategoryId";

            cbProveedor.DataSource = bd.Suppliers.ToList();
            cbProveedor.DisplayMember = "CompanyName";
            cbProveedor.ValueMember = "SupplierID";
            Listar();
        }

        private void Listar()
        {
            dgvVista.DataSource = (from categoria in bd.Categories
                                   join producto in bd.Products
                                   on categoria.CategoryID equals producto.CategoryID
                                   join proveedor in bd.Suppliers
                                   on producto.SupplierID equals proveedor.SupplierID
                                   select new
                                   {
                                       producto.ProductID,
                                       producto.ProductName,
                                       categoria.CategoryName,
                                       proveedor.CompanyName,
                                       producto.UnitPrice,
                                       producto.UnitsInStock
                                   }).ToList();
        }

        private void ObtenerDatos(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvVista.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvVista.CurrentRow.Cells[1].Value.ToString();
            cbCategoria.Text = dgvVista.CurrentRow.Cells[2].Value.ToString();
            cbProveedor.Text = dgvVista.CurrentRow.Cells[3].Value.ToString();
            NupPrecio.Value = (decimal)dgvVista.CurrentRow.Cells[4].Value;
            NupStock.Value = (short)dgvVista.CurrentRow.Cells[5].Value;



        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorCategoria.SetError(txtNombre, "Ingrese Nombre");
                return;
            }
            else
            {
                errorCategoria.SetError(txtNombre, "");
            }
            var consulta = bd.Products.Where(p => p.ProductID.Equals(txtId));
            foreach (Product item in consulta)
            {
                item.ProductName = txtNombre.Text;
                item.UnitsInStock = short.Parse(NupStock.Value.ToString());
                item.UnitPrice = NupPrecio.Value;
                item.CategoryID = int.Parse(cbCategoria.SelectedValue.ToString());
                item.SupplierID = int.Parse(cbProveedor.SelectedValue.ToString());
            }
            try
            {
                bd.SubmitChanges();
                Listar();
                MessageBox.Show("Se actualizo correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un ERROR");
            }
        }
    }

}
