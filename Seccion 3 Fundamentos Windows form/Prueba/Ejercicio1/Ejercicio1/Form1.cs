using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Empleado> listaEmpleado;
        List<Modalidad> listaModalidad;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ejercicio 3
            listaModalidad = new List<Modalidad>()
            {
                new Modalidad(){IdModalidad=1 , Nombre="CAS"},
                new Modalidad(){IdModalidad=2 , Nombre="Temporal"},
                new Modalidad(){IdModalidad=3 , Nombre="Plazo Indeterminado"}
            };

            cbModalidad.DataSource = listaModalidad;
            cbModalidad.ValueMember = "IdModalidad";
            cbModalidad.DisplayMember = "Nombre";


            listaEmpleado = new List<Empleado>

            {

                new Empleado(){IdEmpleado=1 , Nombre="Felipe" , Apellidos="Contreras", IdModalidad=1},
                new Empleado(){IdEmpleado=2 , Nombre="Josue" , Apellidos="Lopez", IdModalidad=2},
                new Empleado(){IdEmpleado=3 , Nombre="Enrique" , Apellidos="Valle", IdModalidad=2},
                new Empleado(){IdEmpleado=4 , Nombre="Carmen" , Apellidos="Rojas", IdModalidad=1},
                new Empleado(){IdEmpleado=5 , Nombre="Ricardo" , Apellidos="Garma", IdModalidad=3},
                new Empleado(){IdEmpleado=6 , Nombre="Rolando" , Apellidos="Minchan", IdModalidad=3}

            };

            var consulta = (from empleado in listaEmpleado
                           select new{ empleado.IdEmpleado, empleado.Nombre, empleado.Apellidos }).ToList();

            DataGridTest.DataSource = consulta;


            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion
                if (txtidEmpleado.Text.Equals(""))
                {
                    errorFormulario.SetError(txtidEmpleado, "Ingrese el id del empleado");
                    return;
                }
                else
                {
                    errorFormulario.SetError(txtidEmpleado, "");

                }

                if (txtNombre.Text.Equals(""))
                {
                    errorFormulario.SetError(txtNombre, "Ingrese nombre");
                    return;
                }
                else
                {
                    errorFormulario.SetError(txtNombre, "");

                }


                if (txtApellidos.Text.Equals(""))
                {
                    errorFormulario.SetError(txtApellidos, "Ingrese Apellido");
                    return;
                }
                else
                {
                    errorFormulario.SetError(txtApellidos, "");

                }
                //Capturar valores
                int idEmpleado = int.Parse(txtidEmpleado.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellidos.Text;

                Empleado emp = new Empleado();
                emp.IdEmpleado = idEmpleado;
                emp.Nombre = nombre;
                emp.Apellidos = apellido;
                listaEmpleado.Add(emp);


                var consulta = (from empleado in listaEmpleado
                                select new { empleado.IdEmpleado, empleado.Nombre, empleado.Apellidos }).ToList();
                DataGridTest.DataSource = null;
                DataGridTest.DataSource = consulta;
                Limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error!!");
            }
        }

        private void Limpiar()
        {
            txtidEmpleado.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text="";
        }

        //Ejercicio 2
        private void Filtrar(object sender, EventArgs e)
        {
            
            var consulta = (from emp in listaEmpleado
                            where emp.Apellidos.Contains(txtFiltro.Text)
                            select new { emp.IdEmpleado, emp.Nombre, emp.Apellidos }).ToList();

            DataGridTest.DataSource = consulta;
        }


        //Ejercicio 3
        private void Filtro(object sender, EventArgs e)
        {
           
            int id = int.Parse(cbModalidad.SelectedValue.ToString());
            var consulta = (from modal in listaEmpleado
                            where modal.IdModalidad.Equals(id)
                            select modal).ToList();

            DataGridTest.DataSource = consulta;
        }

        private void cbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
