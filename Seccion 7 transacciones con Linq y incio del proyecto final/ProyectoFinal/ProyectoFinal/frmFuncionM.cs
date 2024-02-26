using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmFuncionM : Form
    {
        public frmFuncionM()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmFuncionM_Load(object sender, EventArgs e)
        {
            cbPelicula.DataSource = bd.PELICULA.Where(p => p.BHABILITADO.Equals(true)).ToList();
            cbPelicula.DisplayMember = "TITULO";
            cbPelicula.ValueMember = "IDPELICULA";
            Listar();
            
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            frmPopUpFuncion ofuncion = new frmPopUpFuncion();
            ofuncion.Accion = "Nuevo";
            ofuncion.ShowDialog();
            if (ofuncion.DialogResult.Equals(DialogResult.OK))
            {
                Listar();

            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmPopUpFuncion ofuncion = new frmPopUpFuncion();
            ofuncion.Accion = "Modificar";
            ofuncion.Id = dgvFuncionM.CurrentRow.Cells[0].Value.ToString();
            ofuncion.ShowDialog();
            if (ofuncion.DialogResult.Equals(DialogResult.OK)) 
            {
                Listar();
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int id =(int)dgvFuncionM.CurrentRow.Cells[0].Value;
                try
                {
                    using (var transaccion = new TransactionScope())
                    {
                        var consultaf = bd.FUNCION.Where(p => p.IDFUNCION.Equals(id));
                        foreach (var fun in consultaf)
                        {
                            fun.BHABILITADO = false;
                        }
                        var consultab = bd.BUTACA.Where(x => x.IDFUNCION.Equals(id));
                        foreach (var but in consultab)
                        {
                            but.BHABILITADO = false;
                        }
                        bd.SubmitChanges();
                        Listar();
                        transaccion.Complete();
                        MessageBox.Show("Se elimino correctamente");
                    }
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
        }

        private void Listar() 
        {
         dgvFuncionM.DataSource = (from funcion in bd.FUNCION
                                 join sala in bd.SALA
                                 on funcion.IDSALA equals sala.IDSALA
                                 join pelicula in bd.PELICULA
                                 on funcion.IDPELICULA equals pelicula.IDPELICULA
                                 join cine in bd.CINE
                                 on funcion.IDCINE equals cine.IDCINE
                                 where funcion.BHABILITADO.Equals(true)
                                 && pelicula.BHABILITADO.Equals(true)
                                 select new
                                 {
                                     idFuncion = funcion.IDFUNCION,
                                     nombreSala = sala.NOMBRE,
                                     nombrePelicula = pelicula.TITULO,
                                     nombreCine = cine.NOMBRE
                                 }).ToList();
        }

        private void Filtro(object sender, EventArgs e)
        {
            int idpelicula = int.Parse(cbPelicula.SelectedValue.ToString());

            dgvFuncionM.DataSource = (from funcion in bd.FUNCION
                                      join sala in bd.SALA
                                      on funcion.IDSALA equals sala.IDSALA
                                      join pelicula in bd.PELICULA
                                      on funcion.IDPELICULA equals pelicula.IDPELICULA
                                      join cine in bd.CINE
                                      on funcion.IDCINE equals cine.IDCINE
                                      where funcion.BHABILITADO.Equals(true)
                                      && pelicula.IDPELICULA.Equals(idpelicula)
                                      && pelicula.BHABILITADO.Equals(true)
                                      select new
                                      {
                                          idFuncion = funcion.IDFUNCION,
                                          nombreSala = sala.NOMBRE,
                                          nombrePelicula = pelicula.TITULO,
                                          nombreCine = cine.NOMBRE
                                      }).ToList();
        }
    }
}
