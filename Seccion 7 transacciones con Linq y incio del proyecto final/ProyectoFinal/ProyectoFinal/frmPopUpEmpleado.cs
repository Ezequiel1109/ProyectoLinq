using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmPopUpEmpleado : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUpEmpleado()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmPopUpEmpleado_Load(object sender, EventArgs e)
        {
            cbEmpleado.DataSource = bd.TIPOEMPLEADO.ToList();
            cbEmpleado.DisplayMember = "NOMBRE";
            cbEmpleado.ValueMember = "IDTIPOEMPLEADO";

            cbModalidad.DataSource = bd.TIPOMODALIDAD.ToList();
            cbModalidad.DisplayMember = "NOMBRE";
            cbModalidad.ValueMember = "IDTIPOMODALIDAD";

            if (Accion.Equals("Nuevo"))
            {
                Text = "Ingrese Empleado";
            }
            else 
            {
                Text = "Actualice Empleado";

                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(Id));
                foreach (EMPLEADO emp in consulta)
                {
                    txtNombre.Text = emp.NOMBREEMPLEADO;
                    txtApaterno.Text = emp.APPATERNO;
                    txtAmaterno.Text = emp.APMATERNO;
                    txtSueldo.Text = emp.SUELDO.ToString();
                    dtpFI.Value = DateTime.Parse(emp.FECHAINICIO.ToString());
                    cbEmpleado.SelectedValue = emp.IDTIPOEMPLEADO;
                    cbModalidad.SelectedValue = emp.IDTIPOMODALIDAD;
                    txtUsuario.Text = emp.USUARIO;
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(txtNombre, "Ingrese Nombre");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(txtNombre, "");
            }

            if (txtApaterno.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(txtApaterno, "Ingrese Apellido Paterno");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(txtApaterno, "");
            }
            if (txtAmaterno.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(txtAmaterno, "Ingrese Apellido Materno");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(txtAmaterno, "");
            }
            if (txtSueldo.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(txtSueldo, "Ingrese Sueldo");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(txtSueldo, "");
            }
            if (dtpFI.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(dtpFI, "Ingrese Fecha de Inicio");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(dtpFI, "");
            }
            if (cbModalidad.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(cbModalidad, "Ingrese Modalidad");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(cbModalidad, "");
            }
            if (cbEmpleado.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(cbEmpleado, "Ingrese Empleado");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(cbEmpleado, "");
            }
            if (txtUsuario.Text.Equals(""))
            {
                errorPopUpEmpleado.SetError(txtUsuario, "Ingrese Nombre de Usuario");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpEmpleado.SetError(txtUsuario, "");
            }
           
            string nombre = txtNombre.Text;
            string apaterno = txtApaterno.Text;
            string amaterno = txtAmaterno.Text;
            decimal sueldo = decimal.Parse(txtSueldo.Text);
            DateTime fecha = dtpFI.Value;
            int idtipo = int.Parse(cbModalidad.SelectedValue.ToString());
            int idempleado = int.Parse(cbEmpleado.SelectedValue.ToString());
            string usuario = txtUsuario.Text;
            //Cifrado de la contraseña
            string clave = txtContraseña.Text;
            SHA256Managed oshacontraseña = new SHA256Managed();
            byte[] buffercadena = Encoding.Default.GetBytes(clave);
            byte[] buffercadenacifrado = oshacontraseña.ComputeHash(buffercadena);
            //Esta variable se guarda en la base de datos 
            string datacifrada = BitConverter.ToString(buffercadenacifrado).Replace("-","");

            if (Accion.Equals("Nuevo"))
            {

                var consulta = bd.EMPLEADO.Where(p => p.USUARIO.ToUpper().Equals(usuario.ToUpper()));
                int nveces = consulta.Count();
                if (nveces > 0)
                {
                    MessageBox.Show("Ya existe en la Base de datos");
                    DialogResult = DialogResult.None;
                    return;
                }
                if (txtContraseña.Text.Equals(""))
                {
                    errorPopUpEmpleado.SetError(txtContraseña, "Ingrese Contraseña");
                    DialogResult = DialogResult.None;
                    return;
                }
                else
                {
                    errorPopUpEmpleado.SetError(txtContraseña, "");
                }
                EMPLEADO emp = new EMPLEADO
                {
                    NOMBREEMPLEADO = nombre,
                    APPATERNO = apaterno,
                    APMATERNO = amaterno,
                    SUELDO = sueldo,
                    FECHAINICIO = fecha,
                    IDTIPOMODALIDAD = idtipo,
                    IDTIPOEMPLEADO = idempleado,
                    USUARIO = usuario,
                    CONTRA = datacifrada,
                    BHABILITADO = true
                };
                bd.EMPLEADO.InsertOnSubmit(emp);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Ingresado corretamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Ingresar");
                }
            }
            else 
            {
                var consulta = bd.EMPLEADO.Where(p => p.IDEMPLEADO.Equals(Id));
                foreach (EMPLEADO emp in consulta)
                {
                    emp.NOMBREEMPLEADO = nombre;
                    emp.APPATERNO = apaterno;
                    emp.APMATERNO = amaterno;
                    emp.SUELDO = sueldo;
                    emp.FECHAINICIO = fecha;
                    emp.USUARIO = usuario;
                    emp.IDTIPOEMPLEADO = idempleado;
                    emp.IDTIPOMODALIDAD = idtipo;
                }
                try 
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Editado Correctamente");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
        }
    }
}
