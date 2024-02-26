using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
namespace ProyectoFinal
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmReserva_Load(object sender, EventArgs e)
        {
            cboCine.DataSource = bd.CINE.ToList();
            cboCine.DisplayMember = "NOMBRE";
            cboCine.ValueMember = "IDCINE";

            dgvClientes.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)).Select(
                p => new
                {

                    p.IDCLIENTE,
                    p.DNICLIENTE,
                    p.NOMBRE,
                    p.APPATERNO,
                    p.APMATERNO,
                    p.TELEFONOCELULAR,
                    p.TELEFONOFIJO
                }).ToList();
        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            frmBuscarE empleado = new frmBuscarE();
            empleado.ShowDialog();
            if (empleado.DialogResult.Equals(DialogResult.OK))
            {
                txtcodigoEmpleado.Text = empleado.Id;
                txtnombreEmpleado.Text = empleado.NombreCompleto;
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarC cliente = new frmBuscarC();
            cliente.ShowDialog();
            if (cliente.DialogResult.Equals(DialogResult.OK))
            {
                txtdniCliente.Text = cliente.Id;
                txtnombreCliente.Text = cliente.NombreCompleto;
            }
        }

        private void ObtenerPeliculas(object sender, EventArgs e)
        {
            if (cboCine.SelectedValue != null) 
            {
                int idcine = ((CINE)cboCine.SelectedItem).IDCINE;
                var consulta = (from funcion in bd.FUNCION
                                join pelicula in bd.PELICULA
                                on funcion.IDPELICULA equals
                                pelicula.IDPELICULA
                                where
                                funcion.IDCINE.Equals(idcine)
                                && funcion.FECHAFUNCION > DateTime.Now
                                select new Pelicula
                                {
                                    IdPelicula = pelicula.IDPELICULA,
                                    Titulo = pelicula.TITULO
                                }).Distinct().ToList();

                if (consulta.Count == 0) 
                {
                    cboFuncion.DataSource = null;
                    txtsala.Text = "";
                    cboTipoEntraba.DataSource = null;
                    txtprecio.Text = "";
                }
                cboPelicula.Text = "";
                cboPelicula.DataSource = consulta;
                cboPelicula.DisplayMember = "TITULO";
                cboPelicula.ValueMember = "IDPELICULA";
            }
        }

        private void ObtenerPelicula(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedValue != null) 
            {
                int idCine = ((CINE)cboCine.SelectedItem).IDCINE;
                int idPelicula = ((Pelicula)cboPelicula.SelectedItem).IdPelicula;

                var consulta = (from funcion in bd.FUNCION
                                where funcion.IDCINE.Equals(idCine)
                                && funcion.IDPELICULA.Equals(idPelicula)
                                select new Funcion
                                {
                                    IdFuncion = funcion.IDFUNCION,
                                    FechaFuncion = (DateTime)funcion.FECHAFUNCION
                                }).ToList();
                cboFuncion.DataSource = consulta;
                cboFuncion.DisplayMember = "FECHAFUNCION";
                cboFuncion.ValueMember = "IDFUNCION";
            }
        }

        private void ObtenerSala(object sender, EventArgs e)
        {
            if (cboFuncion.SelectedValue != null) 
            {
                int idfuncion = ((Funcion)cboFuncion.SelectedItem).IdFuncion;

                var consulta = (from funcion in bd.FUNCION
                                join sala in bd.SALA
                                on funcion.IDSALA equals
                                sala.IDSALA
                                where funcion.IDFUNCION.Equals(idfuncion)
                                select new
                                {
                                    sala.IDSALA,
                                    sala.NOMBRE
                                }).ToList();

                foreach (var item in consulta )
                {
                    txtsala.Text = item.NOMBRE;
                }

                var consultab = (from butaca in bd.BUTACA
                                 join funcion in bd.FUNCION
                                 on butaca.IDFUNCION equals
                                 funcion.IDFUNCION
                                 where funcion.IDFUNCION.Equals(idfuncion)
                                 && butaca.BHABILITADO.Equals(true) &&
                                 butaca.BLIBRE.Equals(true)
                                 select new
                                 {
                                     butaca.IDFUNCION,
                                     butaca.IDBUTACA,
                                     butaca.INDICEFILA,
                                     butaca.INDICECOLUMNA
                                 }).ToList();
                dgvButacas.DataSource = consultab;

                var consultate = (from funcionE in bd.FUNCIONENTRADA
                                  join tipoE in bd.TIPOENTRADA
                                  on funcionE.IDTIPOENTRADA equals
                                  tipoE.IDTIPOENTRADA
                                  where funcionE.IDFUNCION.Equals(idfuncion)
                                  select new TipoEntrada
                                  {
                                      IDTIPOENTRADA = tipoE.IDTIPOENTRADA,
                                      NOMBRE = tipoE.NOMBRE
                                  }).ToList();

                cboTipoEntraba.DataSource = consultate;
                cboTipoEntraba.DisplayMember = "NOMBRE";
                cboTipoEntraba.ValueMember = "IDTIPOENTRADA";
            }
        }

        private void FiltroRUT(object sender, EventArgs e)
        {
            string rut = txtDNI.Text;
            dgvClientes.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
            && p.DNICLIENTE.Contains(rut)
            ).
            Select(p => new
            {
                p.IDCLIENTE,
                p.DNICLIENTE,
                p.NOMBRE,
                p.APPATERNO,
                p.APMATERNO,
                p.TELEFONOCELULAR,
                p.TELEFONOFIJO
            }).ToList();
        }

        private void FiltroApellido(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            dgvClientes.DataSource = bd.CLIENTE.Where(p => p.BHABILITADO.Equals(true)
              && p.APPATERNO.Contains(apellido)
            ).
               Select(
               p => new
               {
                   p.IDCLIENTE,
                   p.DNICLIENTE,
                   p.NOMBRE,
                   p.APPATERNO,
                   p.APMATERNO,
                   p.TELEFONOCELULAR,
                   p.TELEFONOFIJO
               }

               ).ToList();
        }

        private void ObtenerPrecio(object sender, EventArgs e)
        {
            if (cboTipoEntraba.SelectedValue != null) 
            {
                int idFuncion = ((Funcion)cboFuncion.SelectedItem).IdFuncion;
                int idTipoEntrada = ((TipoEntrada)cboTipoEntraba.SelectedItem).IDTIPOENTRADA;
                var consulta = (from funcion in bd.FUNCION
                                join funcionEntrada in bd.FUNCIONENTRADA
                                on funcion.IDFUNCION equals funcionEntrada.IDFUNCION
                                where funcionEntrada.IDFUNCION.Equals(idFuncion)
                                && funcionEntrada.IDTIPOENTRADA.Equals(idTipoEntrada)
                                && funcionEntrada.BHABILITADO.Equals(true)
                                select new
                                {
                                    funcionEntrada.PRECIO
                                }).ToList();
                foreach (var item in consulta)
                {
                    txtprecio.Text = item.PRECIO.ToString();
                }
            }
        }

        List<Reserva> ListaReserva = new List<Reserva>();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtcodigoEmpleado.Text.Equals("")) 
            {
                MessageBox.Show("Debe seleccionar el empleado que realizara la venta", "Aviso");
                return;
            }

            if (txtdniCliente.Text.Equals("")) 
            {
                MessageBox.Show("Debe ingresar el cliente", "Aviso");
                return;
            }
            int idCliente = (int)dgvClientes.CurrentRow.Cells[0].Value;
            int idFuncion = ((Funcion)cboFuncion.SelectedItem).IdFuncion;
            int idButaca = (int)dgvButacas.CurrentRow.Cells[1].Value;
            int idTipoEntrada = ((TipoEntrada)cboTipoEntraba.SelectedItem).IDTIPOENTRADA;
            decimal precio = decimal.Parse(txtprecio.Text);
            string nombreCliente = dgvClientes.CurrentRow.Cells[2].Value.ToString()
                + " " + dgvClientes.CurrentRow.Cells[3].Value.ToString()
                + " " + dgvClientes.CurrentRow.Cells[4].Value.ToString();

            DateTime fechaFuncion = ((Funcion)cboFuncion.SelectedItem).FechaFuncion;
            string nombreCine = ((CINE)cboCine.SelectedItem).NOMBRE;
            string nombrePelicula = ((Pelicula)cboPelicula.SelectedItem).Titulo;
            string nombreSala = txtsala.Text;
            Reserva oReserva = new Reserva
            {
                IdCliente = idCliente,
                Precio = precio,
                IdFuncion = idFuncion,
                IdButaca = idButaca,
                IdTipoEntrada = idTipoEntrada,
                NombreCompleto = nombreCliente,
                FechaFuncion = fechaFuncion,
                NombreCine = nombreCine,
                NombrePelicula = nombrePelicula,
                NombreSala = nombreSala
            };

            var consultaB = (from lista in ListaReserva
                             where lista.IdFuncion.Equals(idFuncion)
                             && lista.IdButaca.Equals(idButaca)
                             select lista).ToList();
            int nbutacas = consultaB.Count;

            if (nbutacas >=1) 
            {
                MessageBox.Show("Ya se agrego la butaca para esa funcion", "Aviso");
                return;
            }
            var consultaP = (from item in ListaReserva
                                   where item.NombreCompleto.Equals(nombreCliente)
                                   && item.IdFuncion.Equals(idFuncion)
                                   select item).ToList();
            int npersonas = consultaP.Count;
            if (npersonas >= 1)
            {
                MessageBox.Show("Ya se agrego reservo un asiento a la persona para esa funcion", "Aviso");
                return;
            }
            ListaReserva.Add(oReserva);
            ListarDetalle();
            decimal suma = SumarMontos(ListaReserva);
            txtprecioTotal.Text = suma.ToString();
        }

        public decimal SumarMontos(List<Reserva> listaReserva)
        {
            int nelementos = listaReserva.Count;
            decimal suma = 0;
            for (int i = 0; i < nelementos; i++)
            {
                suma += listaReserva[i].Precio;
            }
            return suma;
        }

        private void ListarDetalle()
        {
            dgvDetalleReserva.DataSource = null;
            dgvDetalleReserva.DataSource = (from item in ListaReserva
                                            join funcion in bd.FUNCION
                                            on item.IdFuncion equals
                                            funcion.IDFUNCION
                                            join tipoEntrada in bd.TIPOENTRADA
                                            on item.IdTipoEntrada equals
                                            tipoEntrada.IDTIPOENTRADA
                                            select new
                                            {
                                                NombreCliente = item.NombreCompleto,
                                                NombreCine = item.NombreCine,
                                                NombrePelicula = item.NombrePelicula,
                                                NombreSala = item.NombreSala,
                                                FechaFuncion = funcion.FECHAFUNCION,
                                                IdButaca = item.IdButaca,
                                                TipoEntrada = tipoEntrada.NOMBRE,
                                                Precio = item.Precio
                                            }).ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DateTime fechaF = (DateTime)dgvDetalleReserva.CurrentRow.Cells[4].Value;
            string nombreC = dgvDetalleReserva.CurrentRow.Cells[0].Value.ToString();
            ListaReserva.RemoveAll(p => p.FechaFuncion.Equals(fechaF) && p.NombreCompleto.Equals(nombreC));
            ListarDetalle();
            decimal suma = SumarMontos(ListaReserva);
            txtprecioTotal.Text = suma.ToString();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                using (var trans = new TransactionScope())
                {
                    int idcliente = int.Parse(txtdniCliente.Text);
                    int idempleado = int.Parse(txtcodigoEmpleado.Text);
                    decimal total = decimal.Parse(txtprecioTotal.Text);

                    RESERVA res = new RESERVA
                    {
                        IDCLIENTE = idcliente,
                        IDEMPLEADO = idempleado,
                        TOTAL = total,
                        BHABILITADO = true
                    };

                    bd.RESERVA.InsertOnSubmit(res);
                    bd.SubmitChanges();

                    int idreserva = res.IDRESERVA;

                    int nlistaReserva = ListaReserva.Count;
                    for (int i = 0; i < nlistaReserva; i++)
                    {
                        int idFuncion = ListaReserva[i].IdFuncion;
                        int idButaca = ListaReserva[i].IdButaca;
                        DETALLERESERVA oDETALLERESERVA = new DETALLERESERVA
                        {
                            IDRESERVA = idreserva,
                            IDCLIENTE = ListaReserva[i].IdCliente,
                            PRECIO = (int)ListaReserva[i].Precio,
                            IDFUNCION = ListaReserva[i].IdFuncion,
                            IDBUTACA = ListaReserva[i].IdButaca,
                            BHABILITADO = true
                        };
                        bd.DETALLERESERVA.InsertOnSubmit(oDETALLERESERVA);

                        var butaca = bd.BUTACA.Where(p => p.IDFUNCION.Equals(idFuncion)
                         && p.IDBUTACA.Equals(idButaca));
                        foreach (var item in butaca)
                        {
                            item.BLIBRE = false;
                        }
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
    }
}
