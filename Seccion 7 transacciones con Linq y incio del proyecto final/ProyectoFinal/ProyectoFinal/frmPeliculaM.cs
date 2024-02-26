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
    public partial class frmPeliculaM : Form
    {
        public frmPeliculaM()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpPelicula frmpelicula = new frmPopUpPelicula();
            frmpelicula.Accion = "Nuevo";
            frmpelicula.ShowDialog();
            if (frmpelicula.DialogResult.Equals(DialogResult.OK))
            {
                Listar();
            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpPelicula frmpelicula = new frmPopUpPelicula();
            frmpelicula.Accion = "Modifciar";
            frmpelicula.Id = dgvPelicula.CurrentRow.Cells[0].Value.ToString();
            frmpelicula.ShowDialog();
            if (frmpelicula.DialogResult.Equals(DialogResult.OK)) 
            {
                Listar();
            }
        }

        private void frmPeliculaM_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar() 
        {
            dgvPelicula.DataSource = bd.PELICULA.Where(p => p.BHABILITADO.Equals(1)).Select(p =>
            new
            {

                p.IDPELICULA,
                p.TITULO,
                p.FECHAESTRENO,
                p.SINOPSIS,
                p.DURACION
            }).ToList();
        }

        private void Filtro(object sender, EventArgs e)
        {
            dgvPelicula.DataSource = bd.PELICULA.Where(p => p.BHABILITADO.Equals(1)&& p.TITULO.Contains(txtPelicula.Text)).Select(p =>
          new
          {
              p.IDPELICULA,
              p.TITULO,
              p.FECHAESTRENO,
              p.SINOPSIS,
              p.DURACION
          }).ToList();
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                string id = dgvPelicula.CurrentRow.Cells[0].Value.ToString();
                var consulta = bd.PELICULA.Where(p => p.IDPELICULA.Equals(id));
                foreach (PELICULA peli in consulta)
                {
                    peli.BHABILITADO = false;
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
