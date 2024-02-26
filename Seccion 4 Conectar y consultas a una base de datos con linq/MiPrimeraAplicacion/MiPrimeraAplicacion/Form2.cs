using CursoLinQ1Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            var consulta = (from empleado in bd.Empleados
                            select new
                            {
                                nombrecompleto = empleado.NOMBRE + "" + empleado.APPATERNO + "" + empleado.APMATERNO,
                                edad = empleado.EDAD,
                                edadFutura = empleado.EDAD + 10
                            });

            dgvEmpleado.DataSource = consulta;
        }
    }
}
