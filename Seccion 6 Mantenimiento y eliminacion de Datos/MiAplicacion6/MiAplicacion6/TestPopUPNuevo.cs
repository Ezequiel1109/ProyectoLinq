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
    public partial class TestPopUPNuevo : Form
    {
        public string Accion { get; set; }
        public string id { get; set; }
        public TestPopUPNuevo()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void TestPopUPNuevo_Load(object sender, EventArgs e)
        {
            if (Accion.Equals("Nuevo"))
            {
                this.Text = "Ingresar Producto";
            }
            else
            {
                this.Text = "Editar Producto";
                var consulta = bd.Products.Where(p => p.ProductID.Equals(id));
                foreach (Product pro in consulta)
                {
                    txtId.Text = pro.ProductID.ToString();
                    txtNombre.Text = pro.ProductName;
                    cbCategoria.SelectedValue = pro.CategoryID;
                    cbProveedor.SelectedValue = pro.SupplierID;
                }
            }
            cbCategoria.DataSource = bd.Categories.ToList();
            cbCategoria.DisplayMember = "CategoryName";
            cbCategoria.ValueMember = "CategoryID";


            cbProveedor.DataSource = bd.Suppliers.ToList();
            cbProveedor.DisplayMember = "CompanyName";
            cbProveedor.ValueMember = "SupplierID";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorPopUp.SetError(txtNombre, "Ingrese Nombre");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtNombre, "");
            }

            if (cbCategoria.Text.Equals(""))
            {
                errorPopUp.SetError(cbCategoria, "Seleccione una categoria");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(cbCategoria, "");
            }
            if (cbProveedor.Text.Equals(""))
            {
                errorPopUp.SetError(cbProveedor, "Seleccione un proveedor");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(cbProveedor, "");
            }
            if (Accion.Equals("Nuevo"))
            {
                string nombre = txtNombre.Text;
                int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
                int idProveedor = int.Parse(cbProveedor.SelectedValue.ToString());

                int nVeces = (bd.Products.Where(p => p.ProductName.Equals(nombre))).Count();
                if (nVeces == 1)
                {
                    MessageBox.Show("Existe el nombre del producto en la base de datos");
                    this.DialogResult = DialogResult.None;
                    return;
                }

                //Insertar datos
                
                Product pro = new Product()
                {
                    ProductName= nombre,
                    CategoryID = idCategoria,
                    SupplierID = idProveedor,
                    BHabilitado = true
                };

                bd.Products.InsertOnSubmit(pro);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Agrego Correctamente ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                //Editar los valores
                var consulta = bd.Products.Where(p => p.ProductID.Equals(id));

                foreach (Product pro in consulta)
                {
                    pro.ProductName = txtNombre.Text;
                    pro.CategoryID = int.Parse(cbCategoria.SelectedValue.ToString());
                    pro.SupplierID = int.Parse(cbProveedor.SelectedValue.ToString());
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se actualizo orrectamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
    }
}
