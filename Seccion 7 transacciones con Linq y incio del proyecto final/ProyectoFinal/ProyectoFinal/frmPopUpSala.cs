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
    public partial class frmPopUpSala : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUpSala()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPopUpSala_Load(object sender, EventArgs e)
        {
            cbCine.DataSource = bd.CINE.ToList();
            cbCine.DisplayMember = "NOMBRE";
            cbCine.ValueMember = "IDCINE";

            if (Accion.Equals("Modificar"))
            {
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(Id));
                foreach (SALA osala in consulta) 
                {
                    cbCine.SelectedValue = osala.IDCINE;
                    nupButacas.Value = decimal.Parse(osala.NUMBUTACAS.ToString());
                    nupColumnas.Value = decimal.Parse(osala.NUMEROCOLUMNAS.ToString());
                    nupFilas.Value = decimal.Parse(osala.NUMEROFILAS.ToString());
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int idcine = int.Parse(cbCine.SelectedValue.ToString());
            int nbutacas = int.Parse(nupButacas.Value.ToString());
            string nombre = txtNombre.Text;
            if (nombre.Equals(""))
            {
                errorPopUpSala.SetError(txtNombre, "Ingrese Nombre de la Sala");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpSala.SetError(txtNombre,"");
            }
            if (nbutacas <= 0)
            {
                errorPopUpSala.SetError(nupButacas, "El numero de butacas tiene que ser mayor a 0");
                DialogResult = DialogResult.None;
                return;
            }
            else 
            {
                errorPopUpSala.SetError(nupButacas, "");

            }
            int nfilas = int.Parse(nupFilas.Value.ToString());
            if (nfilas <= 0)
            {
                errorPopUpSala.SetError(nupFilas, "El numero de filas tiene que ser mayor a 0");
                DialogResult = DialogResult.None;
                return;
            }
            else 
            {
                errorPopUpSala.SetError(nupFilas, "");
            }
            int ncolumnas = int.Parse(nupColumnas.Value.ToString());
            if (ncolumnas <= 0)
            {
                errorPopUpSala.SetError(nupColumnas, "El numero de columnas tiene que ser mayor a 0");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpSala.SetError(nupColumnas, "");
            }
            if (Accion.Equals("Nuevo"))
            {
                SALA osala = new SALA
                {
                    IDCINE = idcine,
                    NOMBRE = nombre,
                    NUMBUTACAS = nbutacas,
                    NUMEROFILAS = nfilas,
                    NUMEROCOLUMNAS = ncolumnas,
                    BHABILITADO = true
                };
                bd.SALA.InsertOnSubmit(osala);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Agrego Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Agregar");
                }
            }
            else
            {
                var consulta = bd.SALA.Where(p => p.IDSALA.Equals(Id));
                foreach (SALA osala in consulta)
                {
                    osala.IDCINE = idcine;
                    osala.NUMBUTACAS = nbutacas;
                    osala.NUMEROFILAS = nfilas;
                    osala.NUMEROCOLUMNAS = ncolumnas;
                    osala.NOMBRE = nombre;
                }
                try 
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Edito correctamente");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Agregar ");
                }
            }
        }
    }
}
