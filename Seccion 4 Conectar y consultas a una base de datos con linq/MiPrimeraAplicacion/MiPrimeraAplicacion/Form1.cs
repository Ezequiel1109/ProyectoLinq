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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPantalla.DataSource = bd.Empleados;

        }
    }
}
