using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaSeccion03
{
    public partial class frmConsultaComboSensitiva : Form
    {
        public frmConsultaComboSensitiva()
        {
            InitializeComponent();
        }
        List<Empleado> listaEmpleado;

        private void frmConsultaComboSensitiva_Load(object sender, EventArgs e)
        {
            listaEmpleado = new List<Empleado>
            {
                new Empleado(){idEmpleado=1 , nombre="Felipe" , apellidos="Contreras", idModalidad=1},
                new Empleado(){idEmpleado=2 , nombre="Josue" , apellidos="Lopez", idModalidad=2},
                new Empleado(){idEmpleado=3 , nombre="Enrique" , apellidos="Valle", idModalidad=2},
                new Empleado(){idEmpleado=4 , nombre="Carmen" , apellidos="Rojas", idModalidad=1},
                new Empleado(){idEmpleado=5 , nombre="Ricardo" , apellidos="Garma", idModalidad=3},
                new Empleado(){idEmpleado=6 , nombre="Rolando" , apellidos="Minchan", idModalidad=3}
            };
            dgvEmpleado.DataSource = listaEmpleado;

            List<Modalidad> listaModalidad = new List<Modalidad>()
            {
                new Modalidad(){idModalidad=1 , nombre="CAS"},
                new Modalidad(){idModalidad=2 , nombre="Temporal"},
                new Modalidad(){idModalidad=3 , nombre="Plazo Indeterminado"}
            };
            cboOpcion.DataSource = listaModalidad;
            cboOpcion.DisplayMember = "nombre";
            cboOpcion.ValueMember = "idModalidad";
        }

        private void filtrar(object sender, EventArgs e)
        {
            int id = int.Parse( cboOpcion.SelectedValue.ToString());
            var consulta = (from empleado in listaEmpleado
                           where empleado.idModalidad.Equals(id)
                           select empleado).ToList();
            dgvEmpleado.DataSource = consulta;
        }
    }
}
