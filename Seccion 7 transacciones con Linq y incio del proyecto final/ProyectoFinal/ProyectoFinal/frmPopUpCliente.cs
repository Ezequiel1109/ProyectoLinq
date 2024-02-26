using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmPopUpCliente : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUpCliente()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmPopUpCliente_Load(object sender, EventArgs e)
        {
            cbSexo.DataSource = bd.SEXO.ToList();
            cbSexo.DisplayMember = "NOMBRE";
            cbSexo.ValueMember = "IDSEXO";
            if (Accion.Equals("Nuevo"))
            {
                Text = "Ingrese Nuevo Cliente";
            }
            else 
            {
                Text = "Actualizar Cliente";

                var consulta = bd.CLIENTE.Where(p => p.IDCLIENTE.Equals(Id));
                foreach (CLIENTE cli in consulta) 
                {
                    txtRut.Text = cli.DNICLIENTE.ToString();
                    txtNombre.Text = cli.NOMBRE;
                    txtApaterno.Text = cli.APPATERNO;
                    txtAmaterno.Text = cli.APMATERNO;
                    txtDireccion.Text = cli.DIRECCION;
                    dtpFN.Value = DateTime.Parse(cli.FECHANAC.ToString());
                    txtTFijo.Text = cli.TELEFONOFIJO.ToString();
                    txtTCelular.Text = cli.TELEFONOCELULAR.ToString();
                    cbSexo.SelectedValue = cli.IDSEXO;

                }
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text.Equals(""))
            {
                errorPopUpCliente.SetError(txtRut, "Ingrese Rut");
                DialogResult = DialogResult.None;
                return;
            }
            else 
            {
                errorPopUpCliente.SetError(txtRut,"");
            }

            if (txtNombre.Text.Equals(""))
            {
                errorPopUpCliente.SetError(txtNombre, "Ingrese Nombre");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCliente.SetError(txtNombre, "");
            }

            if (txtApaterno.Text.Equals(""))
            {
                errorPopUpCliente.SetError(txtApaterno, "Ingrese Apellido Paterno");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCliente.SetError(txtApaterno, "");
            }

            if (txtAmaterno.Text.Equals(""))
            {
                errorPopUpCliente.SetError(txtAmaterno, "Ingrese Apellido Materno");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCliente.SetError(txtAmaterno, "");
            }


            if (txtDireccion.Text.Equals(""))
            {
                errorPopUpCliente.SetError(txtDireccion, "Ingrese una Direccion");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCliente.SetError(txtDireccion, "");
            }

            if (dtpFN.Text.Equals(""))
            {
                errorPopUpCliente.SetError(dtpFN, "Ingrese La fecha de Nacimineto");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCliente.SetError(dtpFN, "");
            }



            string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string apellidop = txtApaterno.Text;
            string apellidom = txtAmaterno.Text;
            string direccion = txtDireccion.Text;
            DateTime fecha = dtpFN.Value;
            string telefonof = txtTFijo.Text;
            string telefonoc = txtTCelular.Text;
            int idsexo = int.Parse(cbSexo.SelectedValue.ToString());

            int nveces = bd.CLIENTE.Where(p => p.DNICLIENTE.Equals(rut)).Count();
            if (nveces > 0) 
            {
                MessageBox.Show("Ya existe en la base de datos");
                return;
            }

            if (Accion.Equals("Nuevo"))
            {
                CLIENTE cli = new CLIENTE()
                {
                    DNICLIENTE = rut,
                    NOMBRE = nombre,
                    APPATERNO = apellidop,
                    APMATERNO = apellidom,
                    DIRECCION = direccion,
                    FECHANAC = fecha,
                    TELEFONOFIJO = telefonof,
                    TELEFONOCELULAR = telefonoc,
                    IDSEXO = idsexo,
                    BHABILITADO = true
                    
                };
                bd.CLIENTE.InsertOnSubmit(cli);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Agrego Correctamente");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
            else
            {
                var consulta = bd.CLIENTE.Where(p => p.IDCLIENTE.Equals(Id));
                foreach (CLIENTE cli in consulta) 
                {
                    cli.DNICLIENTE = rut;
                    cli.NOMBRE = nombre;
                    cli.APPATERNO = apellidop;
                    cli.APMATERNO = apellidom;
                    cli.DIRECCION = direccion;
                    cli.FECHANAC = fecha;
                    cli.TELEFONOFIJO = telefonof;
                    cli.TELEFONOCELULAR = telefonoc;
                    cli.IDSEXO = idsexo;
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Edito Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
        }
    }
}
