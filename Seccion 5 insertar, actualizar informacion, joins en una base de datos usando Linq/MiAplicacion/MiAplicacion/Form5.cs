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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form5_Load(object sender, EventArgs e)
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
                                       producto.ProductName,
                                       categoria.CategoryName,
                                       proveedor.CompanyName,
                                       producto.QuantityPerUnit,
                                       producto.UnitPrice,
                                       producto.UnitsInStock
                                   }).ToList();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorProducto.SetError(txtNombre, "Ingrese Nombre");
            }
            else
            {
                errorProducto.SetError(txtNombre, "");
            }

            if (cbCategoria.Text.Equals(""))
            {
                errorProducto.SetError(cbCategoria, "Seleccione una Categoria ");
            }
            else
            {
                errorProducto.SetError(cbCategoria, "");
            }
            if (cbProveedor.Text.Equals(""))
            {
                errorProducto.SetError(cbProveedor, "Seleccione un proveedor");
            }
            else
            {
                errorProducto.SetError(cbProveedor, "");
            }
            if (txtDescripcion.Text.Equals(""))
            {
                errorProducto.SetError(txtDescripcion, "Ingrese Descripcion");
            }
            else
            {
                errorProducto.SetError(txtDescripcion, "");
            }
            if (NupPrecio.Value.Equals(""))
            {
                errorProducto.SetError(NupPrecio, "Ingrese Precio");
            }
            else
            {
                errorProducto.SetError(NupPrecio, "");
            }
            if (NupStock.Text.Equals(""))
            {
                errorProducto.SetError(NupStock, "Ingrese Stock");
            }
            else
            {
                errorProducto.SetError(NupStock, "");
            }


            string nombre = txtNombre.Text;
            int idcategoria = int.Parse(cbCategoria.SelectedValue.ToString());
            int idproveedor = int.Parse(cbProveedor.SelectedValue.ToString());
            string descripcion = txtDescripcion.Text;
            decimal precio = NupPrecio.Value;
            short stock = short.Parse(NupStock.Value.ToString());
            //objeto producto
            Product pro = new Product
            {
                ProductName = nombre,
                CategoryID = idcategoria,
                SupplierID = idproveedor,
                QuantityPerUnit = descripcion,
                UnitPrice = precio,
                UnitsOnOrder = stock
            };
            bd.Products.InsertOnSubmit(pro);
            try
            {
                bd.SubmitChanges();
                Listar();
                Limpiar();
                MessageBox.Show("Se agrego correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error");
            }
           
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            NupPrecio.Value = 0;
            NupStock.Value = 0;
        }
    }
}
