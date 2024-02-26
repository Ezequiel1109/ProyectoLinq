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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Test_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            dgvVista.DataSource = from proveedor in bd.Suppliers
                                  join producto in bd.Products
                                  on proveedor.SupplierID equals producto.SupplierID
                                  join categoria in bd.Categories
                                  on producto.CategoryID equals categoria.CategoryID
                                  where producto.BHabilitado.Equals(true)
                                  select new
                                  {
                                      producto.ProductID,
                                      producto.ProductName,
                                      categoria.CategoryName,
                                      proveedor.CompanyName
                                  };
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            TestPopUPNuevo popup = new TestPopUPNuevo();
            popup.Accion = "Nuevo";
            popup.ShowDialog();

            if (popup.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            TestPopUPNuevo popup = new TestPopUPNuevo();
            popup.Accion = "Editar";
            popup.id = dgvVista.CurrentRow.Cells[0].Value.ToString();
            popup.ShowDialog();

            if (popup.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void Filtro(object sender, EventArgs e)
        {
            dgvVista.DataSource = from proveedor in bd.Suppliers
                                  join producto in bd.Products
                                  on proveedor.SupplierID equals producto.SupplierID
                                  join categoria in bd.Categories
                                  on producto.CategoryID equals categoria.CategoryID
                                  where producto.BHabilitado.Equals(true)
                                  select new
                                  {
                                      producto.ProductID,
                                      producto.ProductName,
                                      categoria.CategoryName,
                                      proveedor.CompanyName
                                  };
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = dgvVista.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.Products.Where(p => p.ProductID.Equals(id));
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
