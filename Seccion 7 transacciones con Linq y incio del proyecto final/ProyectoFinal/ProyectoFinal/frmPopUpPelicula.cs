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
    public partial class frmPopUpPelicula : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUpPelicula()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmPopUpPelicula_Load(object sender, EventArgs e)
        {
            cbGenero.DataSource = bd.GENERO.ToList();
            cbGenero.DisplayMember = "NOMBRE";
            cbGenero.ValueMember = "IDGENERO";

            cbPais.DataSource = bd.PAIS.ToList();
            cbPais.DisplayMember = "NOMBRE";
            cbPais.ValueMember = "IDPAIS";

            cbTCensura.DataSource = bd.TIPOCENSURA.ToList();
            cbTCensura.DisplayMember = "NOMBRE";
            cbTCensura.ValueMember = "IDTIPOCENSURA";

            if (Accion.Equals("Nuevo"))
            {
                Text = "Ingrese Pelicula";
            }
            else
            {
                Text = "Actualice Pelicula";
                var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(Id));
                foreach (PELICULA pel  in consulta)
                {
                    txtIdP.Text = pel.IDPELICULA.ToString();
                    txtTitulo.Text = pel.TITULO;
                    dtpFE.Value = DateTime.Parse(pel.FECHAESTRENO.ToString());
                    cbGenero.SelectedValue = pel.IDGENERO;
                    cbPais.SelectedValue = pel.IDPAIS;
                    txtSinopsis.Text = pel.SINOPSIS;
                    txtDuracion.Text = pel.DURACION.ToString();
                    cbTCensura.SelectedValue = pel.IDTIPOCENSURA;

                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            if (titulo.Equals(""))
            {
                errorPopUpPelicula.SetError(txtTitulo, "Ingrese Titulo");
                DialogResult = DialogResult.None;
                return;
            }
            else 
            {
                errorPopUpPelicula.SetError(txtTitulo, "");
            }

            DateTime fecha = dtpFE.Value;
            int idgenero = int.Parse(cbGenero.SelectedValue.ToString());
            int idpais = int.Parse(cbPais.SelectedValue.ToString());
            string sinopsis = cbTCensura.Text;

            if (fecha.Equals(""))
            {
                errorPopUpPelicula.SetError(dtpFE, "Ingrese Fecha");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpPelicula.SetError(dtpFE, "");
            }

            if (idgenero.Equals(""))
            {
                errorPopUpPelicula.SetError(cbGenero, "Ingrese Genero");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpPelicula.SetError(cbGenero, "");
            }

            if (idpais.Equals(""))
            {
                errorPopUpPelicula.SetError(cbPais, "Ingrese Pais");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpPelicula.SetError(cbPais, "");
            }

            if (sinopsis.Equals(""))
            {
                errorPopUpPelicula.SetError(cbTCensura, "Ingrese Sinopsis");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUpPelicula.SetError(cbTCensura, "");
            }

            int duracion = int.Parse(txtDuracion.Text);
            int idTipoCensura = int.Parse(cbTCensura.SelectedValue.ToString());
            if (Accion.Equals("Nuevo"))
            {
                
                PELICULA opelicula = new PELICULA()
                {
                    TITULO = titulo,
                    FECHAESTRENO = fecha.ToString(),
                    IDGENERO = idgenero,
                    IDPAIS = idpais,
                    SINOPSIS = sinopsis,
                    DURACION = duracion,
                    IDTIPOCENSURA = idTipoCensura,
                    BHABILITADO = true
                };
                bd.PELICULA.InsertOnSubmit(opelicula);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Ingreso Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar");
                }

            }
            else 
            {
                int id = int.Parse(txtIdP.Text);
                var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(Id));
                foreach (PELICULA pel in consulta)
                {
                    pel.TITULO = titulo;
                    pel.FECHAESTRENO = fecha.ToString();
                    pel.IDGENERO = idgenero;
                    pel.IDPAIS = idpais;
                    pel.SINOPSIS = sinopsis;
                    pel.DURACION = duracion;
                    pel.IDTIPOCENSURA = idTipoCensura;
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
