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
    public partial class frmConsultaSensitiva : Form
    {
        public frmConsultaSensitiva()
        {
            InitializeComponent();
        }

        private void filtrar(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            var consulta = (from empleado in listaEmpleado
                           where empleado.apellidos.Contains(apellido)
                           select empleado).ToList();
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = consulta;
        }
        List<Empleado> listaEmpleado;
        private void frmConsultaSensitiva_Load(object sender, EventArgs e)
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
        }
    }
}
