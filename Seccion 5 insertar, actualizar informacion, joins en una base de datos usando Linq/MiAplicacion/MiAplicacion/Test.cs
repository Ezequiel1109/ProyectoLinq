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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
//        //Ejercicio 1
//        NorthwindDataContext bd = new NorthwindDataContext();
//        dgvVista.DataSource = (from producto in bd.Products
//                               join categoria in bd.Categories
//                               on categoria.CategoryID equals producto.CategoryID
//                               select new
//                                   {

//                                       producto.ProductName,
//                                       producto.UnitPrice,
//                                       categoria.CategoryName


//    }).ToList();


//    //Ejercicio 2
//    NorthwindDataContext bd = new NorthwindDataContext();
//    private void Test_Load(object sender, EventArgs e)
//    {
//        cbCategoria.DataSource = bd.Categories;
//        cbCategoria.DisplayMember = "CategoryName";
//        cbCategoria.ValueMember = "CategoryID";
//        Listar();
//    }
//    private void Listar()
//    {
//        dgvVista.DataSource = from producto in bd.Products
//                              join categoria in bd.Categories
//                              on producto.CategoryID equals categoria.CategoryID
//                              select new
//                              {
//                                  producto.ProductName,
//                                  categoria.CategoryName,
//                                  producto.UnitsInStock
//                              };

//    }

//    private void BtnBuscar_Click(object sender, EventArgs e)
//    {
//        int id = int.Parse(cbCategoria.SelectedValue.ToString());

//        dgvVista.DataSource = (from categoria in bd.Categories
//                               join producto in bd.Products
//                               on categoria.CategoryID equals producto.CategoryID
//                               where categoria.CategoryID.Equals(id)
//                               select new
//                               {
//                                   producto.ProductName,
//                                   categoria.CategoryName,
//                                   producto.UnitsInStock

//                               }).ToList();
//    }


//    //Ejercicio 3
//    NorthwindDataContext bd = new NorthwindDataContext();
//    private void Test_Load(object sender, EventArgs e)
//    {
//        Listar();
//        cbRegion.DataSource = bd.Regions.ToList();
//        cbRegion.DisplayMember = "RegionDescription";
//        cbRegion.ValueMember = "RegionID";

//    }

//    private void Listar()
//    {
//        dgvVista.DataSource = from territorio in bd.Territories
//                              join region in bd.Regions
//                              on territorio.RegionID equals region.RegionID
//                              select new
//                              {
//                                  territorio.TerritoryDescription,
//                                  region.RegionDescription
//                              };
//    }

//    private void BtnIngresar_Click(object sender, EventArgs e)
//    {
//        string id = txtId.Text;
//        string nombre = txtNombre.Text;
//        int idRegion = int.Parse(cbRegion.SelectedValue.ToString());


//        if (txtId.Text.Equals(""))
//        {
//            errorTest.SetError(txtId, "Debe ingresar un ID");
//            return;
//        }
//        else
//        {
//            errorTest.SetError(txtId, "");
//        }

//        if (txtNombre.Text.Equals(""))
//        {
//            errorTest.SetError(txtNombre, "Debe ingresar un Nombre");
//            return;
//        }
//        else
//        {
//            errorTest.SetError(txtNombre, "");
//        }
//        if (cbRegion.Text.Equals(""))
//        {
//            errorTest.SetError(cbRegion, "Seleccione una Region ");
//            return;
//        }
//        else
//        {
//            errorTest.SetError(cbRegion, "");
//        }

//        int nveces = (from territorio in bd.Territories
//                      where territorio.TerritoryID.Equals(id)
//                      select territorio).Count();

//        if (nveces == 1)
//        {
//            MessageBox.Show("Ya Existe ese ID");
//            return;
//        }


//        int nvNombre = (from territorio in bd.Territories
//                        where territorio.TerritoryDescription.Equals(nombre)
//                        select territorio).Count();

//        if (nvNombre == 1)
//        {
//            MessageBox.Show("Ya Existe ese Nombre");
//            return;
//        }


//        Territory ter = new Territory
//        {
//            TerritoryID = id,
//            TerritoryDescription = nombre,
//            RegionID = idRegion
//        };
//        bd.Territories.InsertOnSubmit(ter);
//        //en caso de que se caiga la aplicacion, esta pueda mostrar un mensaje
//        try
//        {
//            bd.SubmitChanges();
//            Listar();
//            Limpiar();
//            MessageBox.Show("Se Agrego Correctamente");
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Ocurrio un Error");
//        }
//    }
//    private void Limpiar()
//    {
//        txtId.Text = "";
//        txtNombre.Text = "";
//        cbRegion.Text = "";
//    }
//}


////Ejercicio 4
//NorthwindDataContext bd = new NorthwindDataContext();
//private void Test_Load(object sender, EventArgs e)
//{
//    Listar();
//    cbRegion.DataSource = bd.Regions.ToList();
//    cbRegion.DisplayMember = "RegionDescription";
//    cbRegion.ValueMember = "RegionID";

//}

//private void Listar()
//{
//    dgvVista.DataSource = from territorio in bd.Territories
//                          select new
//                          {
//                              territorio.TerritoryID,
//                              territorio.TerritoryDescription,
//                              territorio.RegionID
//                          };
//}

//private void ObtenerDatos(object sender, DataGridViewCellEventArgs e)
//{
//    string id = dgvVista.CurrentRow.Cells[0].Value.ToString();
//    string nombre = dgvVista.CurrentRow.Cells[1].Value.ToString();
//    int idRegion = (int)dgvVista.CurrentRow.Cells[2].Value;


//    txtId.Text = id;
//    txtNombre.Text = nombre;
//    cbRegion.SelectedValue = idRegion;
//}

//private void BtnIngresar_Click(object sender, EventArgs e)
//{
//    var consulta = bd.Territories.Where(p => p.TerritoryID.Equals(txtId));

//    if (txtNombre.Text.Equals(""))
//    {
//        errorTest.SetError(txtNombre, "Ingrese un nombre");
//        return;
//    }
//    else
//    {
//        errorTest.SetError(txtNombre, "");
//    }

//    foreach (Territory territorio in consulta)
//    {
//        territorio.TerritoryID = txtId.Text;
//        territorio.TerritoryDescription = txtNombre.Text;
//        territorio.RegionID = (int)cbRegion.SelectedValue;
//    }
//    try
//    {
//        bd.SubmitChanges();
//        Listar();
//        Limpiar();
//        MessageBox.Show("Se Actualizo Correctamente");
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show("Ocurrio un Error");
//    }
//}
//private void Limpiar()
//{
//    txtId.Text = "";
//    txtNombre.Text = "";
//    cbRegion.Text = "";
//}
    }
}
