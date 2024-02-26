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
    public partial class frmConsultaPeliculaPorGenero : Form
    {
        public frmConsultaPeliculaPorGenero()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmConsultaPeliculaPorGenero_Load(object sender, EventArgs e)
        {
            cboGenero.DataSource = bd.GENERO.Where(p => p.BHABILITADO.Equals(true)).ToList();
            cboGenero.DisplayMember = "NOMBRE";
            cboGenero.ValueMember = "IDGENERO";
            Listar();
        }

        private void Listar()
        {
            dgvPelicula.DataSource = (from pelicula in bd.PELICULA
                                      join genero in bd.GENERO
                                      on pelicula.IDGENERO equals
                                      genero.IDGENERO
                                      join pais in bd.PAIS
                                      on pelicula.IDPAIS equals
                                      pais.IDPAIS
                                      where pelicula.BHABILITADO.Equals(true)
                                      select new
                                      {
                                          Titulo = pelicula.TITULO,
                                          FechaEstreno = pelicula.FECHAESTRENO,
                                          NombreGenero = genero.NOMBRE,
                                          NombrePais = pais.NOMBRE
                                      }).ToList();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int idGenero = ((GENERO)cboGenero.SelectedItem).IDGENERO;
            dgvPelicula.DataSource = (from pelicula in bd.PELICULA
                                      join genero in bd.GENERO
                                      on pelicula.IDGENERO equals
                                      genero.IDGENERO
                                      join pais in bd.PAIS
                                      on pelicula.IDPAIS equals
                                      pais.IDPAIS
                                      where pelicula.BHABILITADO.Equals(true)
                                           && pelicula.IDGENERO.Equals(idGenero)
                                      select new
                                      {
                                          Titulo = pelicula.TITULO,
                                          FechaEstreno = pelicula.FECHAESTRENO,
                                          NombreGenero = genero.NOMBRE,
                                          NombrePais = pais.NOMBRE
                                      }).ToList();
        }
    }
}
