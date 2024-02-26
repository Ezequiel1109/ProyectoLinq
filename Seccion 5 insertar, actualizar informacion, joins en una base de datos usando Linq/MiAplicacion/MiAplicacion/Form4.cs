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
            dgvVista.DataSource = bd.Suppliers.Select(
                p=> new
                {
                    p.CompanyName,
                    p.ContactName,
                    p.ContactTitle,
                    p.Address,
                    p.City
                }
                ).ToList();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string empresa = txtCompañia.Text;
            string nombre = txtNombre.Text;
            string titulo = txtTitulo.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            int nveces = (bd.Suppliers.Where(p => p.CompanyName.Equals(empresa)).Count());
            if (nveces == 1)
            {
                MessageBox.Show("Ya se encuentra el dato ingresado");
                return;
            }

            Supplier su = new Supplier
            {
                CompanyName = empresa,
                ContactName = nombre,
                ContactTitle = titulo,
                Address = direccion,
                City = ciudad
            };
            bd.Suppliers.InsertOnSubmit(su);

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
            txtCompañia.Text = "";
            txtNombre.Text = "";
            txtTitulo.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
        }
    }
}
