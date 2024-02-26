using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion2WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
          private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //convertir la cadena a un numero con int.parse
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            int suma = numero1 + numero2;

            lblRespuesta.Text = "La Suma es : " + suma;
        }

      
    }
}
