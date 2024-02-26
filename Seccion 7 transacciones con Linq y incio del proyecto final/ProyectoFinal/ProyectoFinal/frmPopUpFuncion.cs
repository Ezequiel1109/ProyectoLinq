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
    public partial class frmPopUpFuncion : Form
    {
        public string Accion { get; set; }
        public string Id { get; set; }
        public frmPopUpFuncion()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        List<ENTRADA> listaE = new List<ENTRADA>();
        
        private void frmPopUpFuncion_Load(object sender, EventArgs e)
        {
            cbPelicula.DataSource = bd.PELICULA;
            cbPelicula.DisplayMember = "TITULO";
            cbPelicula.ValueMember = "IDPELICULA";

            cbCine.DataSource = bd.CINE;
            cbCine.DisplayMember = "NOMBRE";
            cbCine.ValueMember = "IDCINE";

            //cbSala.DataSource = bd.SALA;
            //cbSala.DisplayMember = "NOMBRE";
            //cbSala.ValueMember = "IDSALA";

            cbTipo.DataSource = bd.TIPOENTRADA;
            cbTipo.DisplayMember = "NOMBRE";
            cbTipo.ValueMember = "IDTIPOENTRADA";

            if (Accion.Equals("Modificar"))
            {
                Text = "Modificando la Funcion";
                var consulta = bd.FUNCION.Where(p => p.IDFUNCION.Equals(Id));
                foreach (FUNCION ofuncion in consulta)
                {
                    dtpFF.Value = (DateTime)ofuncion.FECHAFUNCION;
                    cbPelicula.SelectedValue = ofuncion.IDPELICULA;
                    cbCine.SelectedValue = ofuncion.IDCINE;
                    cbSala.SelectedValue = ofuncion.IDSALA;
                }
                listaE = (from funcion in bd.FUNCIONENTRADA
                          join tipo in bd.TIPOENTRADA
                          on funcion.IDTIPOENTRADA equals
                          tipo.IDTIPOENTRADA
                          where funcion.IDFUNCION.Equals(Id)
                          && funcion.BHABILITADO.Equals(true)
                          select new ENTRADA
                          {
                              Idtipoentrada = funcion.IDTIPOENTRADA,
                              NombreTipo = tipo.NOMBRE,
                              Precio = (decimal)funcion.PRECIO
                          }).ToList();
                dgvPrecios.DataSource = listaE;
            }
            else
            {
                Text = "Agregando Funcion";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFF.Value;
            int idpelicula = ((PELICULA)cbPelicula.SelectedItem).IDPELICULA;
            int idcine = ((CINE)cbCine.SelectedItem).IDCINE;
            int idsala = ((SALA)cbSala.SelectedItem).IDSALA;
            if (Accion.Equals("Nuevo"))
            {
                if (dgvPrecios.Rows.Count.Equals(0))
                {
                    MessageBox.Show("Debe ingresar un precio");
                    return;
                }
                try
                {
                    using (var trans = new TransactionScope())
                    {
                        FUNCION ofuncion = new FUNCION
                        {
                            FECHAFUNCION = fecha,
                            IDPELICULA = idpelicula,
                            IDCINE = idcine,
                            IDSALA= idsala,
                            BHABILITADO = true
                        };
                        bd.FUNCION.InsertOnSubmit(ofuncion);
                        bd.SubmitChanges();
                        //obtengo el id autogenerado luego de insertar la funcion 
                        int idfuncion = ofuncion.IDFUNCION;

                        var consulta = bd.SALA.Where(p => p.IDSALA.Equals(idfuncion));
                        int ncolumnas = 0;
                        int nfilas = 0;

                        foreach (SALA osala in consulta)
                        {
                            ncolumnas = (int)osala.NUMEROCOLUMNAS;
                            nfilas = (int)osala.NUMEROFILAS;
                        }
                        int c = 1;
                        for (int i = 1; i <= ncolumnas; i++)
                        {
                            for (int j = 1; j <= nfilas; j++)
                            {
                                BUTACA obutacas = new BUTACA
                                {
                                    IDFUNCION = idfuncion,
                                    IDBUTACA = c,
                                    INDICECOLUMNA = j,
                                    INDICEFILA = i,
                                    BHABILITADO = true,
                                    BLIBRE = true

                                };
                                bd.BUTACA.InsertOnSubmit(obutacas);
                                c++;
                            }
                        }
                        bd.SubmitChanges();
                        //Guardar los tipos de entrada 
                        int nlista = listaE.Count;
                        for (int i = 0; i < nlista; i++)
                        {
                            FUNCIONENTRADA fun = new FUNCIONENTRADA
                            {
                                IDFUNCION = idfuncion,
                                IDTIPOENTRADA = listaE[i].Idtipoentrada,
                                PRECIO = listaE[i].Precio,
                                BHABILITADO = true
                            };
                            bd.FUNCIONENTRADA.InsertOnSubmit(fun);
                        }
                        bd.SubmitChanges();
                        trans.Complete();
                        MessageBox.Show("Se guardo correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else 
            {
                try
                {
                    using (var trans1 = new TransactionScope())
                    {
                        var consultaf = bd.FUNCION.Where(p => p.IDFUNCION.Equals(Id));
                        foreach (FUNCION ofuncion in consultaf)
                        {
                            ofuncion.FECHAFUNCION = fecha;
                            ofuncion.IDPELICULA = idpelicula;
                            ofuncion.IDCINE = idcine;
                            ofuncion.IDSALA = idsala;
                        }

                        var consultae = bd.FUNCIONENTRADA.Where(p => p.IDFUNCION.Equals(Id));
                        foreach (FUNCIONENTRADA ofuncione in consultae)
                        {
                            ofuncione.BHABILITADO = false;
                        }
                        //id que esta en la grilla existe en la bd, se tiene que actualizar
                        //si no existe entonces lo insertamos, y ponemos el bhabilitado=true
                        int nlista = listaE.Count;
                        //for recorre la lista 
                        for (int i = 0; i < nlista; i++)
                        {
                            var consulta = bd.FUNCIONENTRADA.Where(p => p.IDTIPOENTRADA.Equals(
                                listaE[i].Idtipoentrada) && p.IDFUNCION.Equals(Id));
                            int nveces = consulta.Count();
                            if (nveces == 0)
                            {
                                FUNCIONENTRADA fe = new FUNCIONENTRADA
                                {
                                    IDFUNCION = int.Parse(Id),
                                    IDTIPOENTRADA = listaE[i].Idtipoentrada,
                                    PRECIO = listaE[i].Precio,
                                    BHABILITADO = true
                                };
                            }
                            else
                            {
                                foreach (FUNCIONENTRADA fe in consulta)
                                {
                                    fe.BHABILITADO = true;
                                    fe.PRECIO = listaE[i].Precio;
                                }
                            }
                        }
                        bd.SubmitChanges();
                        MessageBox.Show("Se edito correctamente");
                        trans1.Complete();
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }

        private void ObtenerDatos(object sender, EventArgs e)
        {
            int idcine = ((CINE)cbCine.SelectedItem).IDCINE;
            var consulta = bd.SALA.Where(p => p.IDCINE.Equals(idcine));
            cbSala.DataSource = consulta;
            cbSala.DisplayMember = "NOMBRE";
            cbSala.ValueMember = "IDSALA";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrecios.Rows.Count.Equals(0)) 
            {
                MessageBox.Show("No hay resgistro a eliminar");
                return;
            }
            if (MessageBox.Show("¿Desea Eliminar?", "Aviso", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) 
            {
                int id = (int)dgvPrecios.CurrentRow.Cells[0].Value;
                listaE.RemoveAll(p => p.Idtipoentrada.Equals(id));
                dgvPrecios.DataSource = null;
                dgvPrecios.DataSource = listaE;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int idTEntrada = ((TIPOENTRADA)cbTipo.SelectedItem).IDTIPOENTRADA;
            string nombre = ((TIPOENTRADA)cbTipo.SelectedItem).NOMBRE;
            decimal precio = dudprecio.Value;

            if (precio <= 0)
            {
                MessageBox.Show("Debe ser mayor 0 el precio");
                return;
            }

 
            dgvPrecios.DataSource = null;
            listaE.Add(new ENTRADA
            {
                Idtipoentrada = idTEntrada,
                NombreTipo = nombre,
                Precio = precio
            });
            dgvPrecios.DataSource = listaE;
            dudprecio.Value = 0;
        }
    }
}
