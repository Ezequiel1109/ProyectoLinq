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
    public partial class frmPopUpCine : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }

        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        public frmPopUpCine()
        {
            InitializeComponent();
        }

        private void frmPopUpCine_Load(object sender, EventArgs e)
        {
            cbTipo.DataSource = bd.TIPOCINE.ToList();
            cbTipo.DisplayMember = "NOMBRE";
            cbTipo.ValueMember = "IDTIPOCINE";

            if (Accion.Equals("Modificar"))
            {
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(Id));
                foreach (CINE ocine  in consulta) 
                {
                    txtId.ReadOnly = true;
                    txtNombre.Text = ocine.NOMBRE;
                    txtDireccion.Text = ocine.DIRECCION;
                    dtpFA.Value = DateTime.Parse(ocine.FECHAAPERTURA.ToString());
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorPopUpCine.SetError(txtNombre, "Ingrese Nombre");
                DialogResult = DialogResult.None;
                return;
            }
            else 
            {
                errorPopUpCine.SetError(txtNombre,"");
            }

            if (cbTipo.Text.Equals(""))
            {
                errorPopUpCine.SetError(cbTipo, "Seleccione un tipo");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCine.SetError(cbTipo, "");
            }

            if (txtDireccion.Text.Equals(""))
            {
                errorPopUpCine.SetError(txtDireccion, "Ingrese Direccion ");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpCine.SetError(txtDireccion, "");
            }

            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int idtipocine = int.Parse(cbTipo.SelectedValue.ToString());
            DateTime fecha = dtpFA.Value;
            if (Accion.Equals("Nuevo"))
            {
                int nveces = bd.CINE.Where(p => p.NOMBRE.Equals(txtNombre.Text)).Count();
                if (nveces > 0)
                {
                    MessageBox.Show("Ya existe en la base de datos");
                    return;
                }
                CINE ocine = new CINE()
                {
                    NOMBRE = nombre,
                    IDTIPOCINE = idtipocine,
                    DIRECCION = direccion,
                    FECHAAPERTURA = fecha,
                    BHABILITADO = 1
                };
                bd.CINE.InsertOnSubmit(ocine);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Ingreso Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error");
                }
            }
            else 
            {
                var consulta = bd.CINE.Where(p => p.IDCINE.Equals(Id));
                foreach (CINE cin in consulta)
                {
                    
                    cin.NOMBRE = nombre;
                    cin.IDTIPOCINE = idtipocine;
                    cin.DIRECCION = direccion;
                    cin.FECHAAPERTURA = fecha;
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
