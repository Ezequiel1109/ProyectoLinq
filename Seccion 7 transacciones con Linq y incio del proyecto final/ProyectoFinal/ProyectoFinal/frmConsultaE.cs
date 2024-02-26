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
    public partial class frmConsultaE : Form
    {
        public frmConsultaE()
        {
            InitializeComponent();
        }
        ConexiondbmlDataContext bd = new ConexiondbmlDataContext();
        private void frmConsultaE_Load(object sender, EventArgs e)
        {
            cboEmpleado.DataSource = bd.EMPLEADO.Where(p => p.BHABILITADO.Equals(true)).ToList();
            cboEmpleado.DisplayMember = "NOMBREEMPLEADO";
            cboEmpleado.ValueMember = "IDEMPLEADO";
            Listar();
        }
        private void Listar()
        {
            dgvReserva.DataSource = (from reserva in bd.RESERVA
                                     join empleado in bd.EMPLEADO
                                     on reserva.IDEMPLEADO equals
                                     empleado.IDEMPLEADO
                                     join cliente in bd.CLIENTE
                                     on reserva.IDCLIENTE equals
                                     cliente.IDCLIENTE
                                     where reserva.BHABILITADO.Equals(true)
                                     select new
                                     {
                                         IdReserva = reserva.IDRESERVA,
                                         NombreCliente = cliente.NOMBRE + " " +
                                         cliente.APPATERNO + " " + cliente.APMATERNO,
                                         NombreEmpleado = empleado.NOMBREEMPLEADO + " " +
                                         empleado.APPATERNO + " " + empleado.APMATERNO,
                                         TotalPagar = reserva.TOTAL
                                     }).ToList();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int idEmpleado = ((EMPLEADO)cboEmpleado.SelectedItem).IDEMPLEADO;
            dgvReserva.DataSource = (from reserva in bd.RESERVA
                                     join empleado in bd.EMPLEADO
                                     on reserva.IDEMPLEADO equals
                                     empleado.IDEMPLEADO
                                     join cliente in bd.CLIENTE
                                     on reserva.IDCLIENTE equals
                                     cliente.IDCLIENTE
                                     where reserva.BHABILITADO.Equals(true)
                                     && reserva.IDEMPLEADO.Equals(idEmpleado)
                                     select new
                                     {
                                         IdReserva = reserva.IDRESERVA,
                                         NombreCliente = cliente.NOMBRE + " " +
                                         cliente.APPATERNO + " " + cliente.APMATERNO,
                                         NombreEmpleado = empleado.NOMBREEMPLEADO + " " +
                                         empleado.APPATERNO + " " + empleado.APMATERNO,
                                         TotalPagar = reserva.TOTAL
                                     }).ToList();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            dgvDetalle.DataSource = null;
        }

        private void ObtenerInformacion(object sender, DataGridViewCellEventArgs e)
        {
            int idReserva = (int)dgvReserva.CurrentRow.Cells[0].Value;
            var consulta = (from detallereserva in bd.DETALLERESERVA
                            join cliente in bd.CLIENTE
                            on detallereserva.IDCLIENTE equals
                            cliente.IDCLIENTE
                            join funcion in bd.FUNCION
                            on detallereserva.IDFUNCION equals
                            funcion.IDFUNCION
                            join pelicula in bd.PELICULA
                            on funcion.IDPELICULA equals pelicula.IDPELICULA
                            join cine in bd.CINE
                            on funcion.IDCINE equals cine.IDCINE
                            where detallereserva.BHABILITADO.Equals(true)
                            && detallereserva.IDRESERVA.Equals(idReserva)
                            select new
                            {
                                NombreCompletoCliente = cliente.NOMBRE + " " + cliente.APPATERNO + " " +
                                cliente.APMATERNO,
                                NombreCine = cine.NOMBRE,
                                NombrePelicula = pelicula.FECHAESTRENO,
                                Precio = detallereserva.PRECIO
                            }).ToList();
            dgvDetalle.DataSource = consulta;
        }
    }
}
