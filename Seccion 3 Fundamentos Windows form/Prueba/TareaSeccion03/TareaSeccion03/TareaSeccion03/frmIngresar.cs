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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        List<Empleado> listaEmpleado;
        private void frmIngresar_Load(object sender, EventArgs e)
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
            dgvEmpleado.DataSource = (from empleado in listaEmpleado
                                     select new { empleado.idEmpleado, empleado.nombre, empleado.apellidos }).ToList();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("")){
                errorDato.SetError(txtID, "El ID es un campo obligatorio");
                return;
            }
            else
            {
                errorDato.SetError(txtID, "");
            }

            if (txtnombre.Text.Equals(""))
            {
                errorDato.SetError(txtnombre, "El ID es un campo obligatorio");
                return;
            }
            else
            {
                errorDato.SetError(txtnombre, "");
            }

            if (txtnombre.Text.Equals(""))
            {
                errorDato.SetError(txtnombre, "El nombre es un campo obligatorio");
                return;
            }
            else
            {
                errorDato.SetError(txtnombre, "");
            }

            if (txtapellido.Text.Equals(""))
            {
                errorDato.SetError(txtapellido, "El apellido es un campo obligatorio");
                return;
            }
            else
            {
                errorDato.SetError(txtapellido, "");
            }

            Empleado emp = new Empleado();
            emp.idEmpleado = int.Parse( txtID.Text);
            emp.nombre = txtnombre.Text;
            emp.apellidos = txtapellido.Text;
            listaEmpleado.Add(emp);
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = (from empleado in listaEmpleado
                                     select new { empleado.idEmpleado, empleado.nombre, empleado.apellidos }).ToList();
            txtapellido.Text = "";
            txtID.Text = "";
            txtnombre.Text = "";
        }
    }
}
