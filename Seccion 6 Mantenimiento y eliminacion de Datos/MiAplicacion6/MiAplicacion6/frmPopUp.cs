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
    public partial class frmPopUp : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUp()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void frmPopUp_Load(object sender, EventArgs e)
        {
            if (!Accion.Equals("Nuevo"))
            {
                var consulta = bd.Employees.Where(x => x.EmployeeID.Equals(Id));

                foreach (Employee emp in consulta)
                {
                    txtCodigo.Text = emp.EmployeeID.ToString();
                    txtDireccion.Text = emp.Address.ToString();
                    txtPrimerN.Text = emp.FirstName.ToString();
                    txtSegundoN.Text = emp.LastName.ToString();
                    txtTitulo.Text = emp.Title.ToString();
                    dtpNacimiento.Value = DateTime.Parse(emp.BirthDate.ToString());

                }
                //try
                //{
                //    bd.SubmitChanges();
                //    MessageBox.Show("Se registro correctamente");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Ocurrio un Problema en la insercion de los datos");
                //}
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                errorPopUp.SetError(txtCodigo, "Ingrese codigo");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtCodigo, "");
            }

            if (txtPrimerN.Text.Equals(""))
            {
                errorPopUp.SetError(txtPrimerN, "Ingrese Nombre");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtPrimerN, "");
            }

            if (txtSegundoN.Text.Equals(""))
            {
                errorPopUp.SetError(txtSegundoN, "Ingrese Apellido");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtSegundoN, "");
            }

            if (txtTitulo.Text.Equals(""))
            {
                errorPopUp.SetError(txtTitulo, "Ingrese Titulo");
                this.DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtTitulo, "");
            }

            
            string primern = txtPrimerN.Text;
            string segundon = txtSegundoN.Text;
            string direccion = txtDireccion.Text;
            string titulo = txtTitulo.Text;
            DateTime fecha = dtpNacimiento.Value;
            if (Accion.Equals("Nuevo"))
            {
               int codigo = int.Parse(txtCodigo.Text);

                Employee emp = new Employee()
                {
                    EmployeeID = codigo,
                    FirstName = primern,
                    LastName = segundon,
                    Address = direccion,
                    Title = titulo,
                    BirthDate = fecha,
                    BHabilitado = true
                };
                bd.Employees.InsertOnSubmit(emp);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se agrego correctamente");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en la insercion");
                }
            }
            else
            {
                var consulta = bd.Employees.Where(p => p.EmployeeID.Equals(Id));
                foreach (Employee emp in consulta)
                {
                    emp.FirstName = primern;
                    emp.LastName = segundon;
                    emp.Address = direccion;
                    emp.Title = titulo;
                    emp.BirthDate = fecha;
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Edito correctamente");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en la edicion");
                }
            }
        }
    }
}
