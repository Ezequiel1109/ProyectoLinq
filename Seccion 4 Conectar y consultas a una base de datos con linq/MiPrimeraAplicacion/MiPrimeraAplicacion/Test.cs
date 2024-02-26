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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
        private void Test_Load(object sender, EventArgs e)
        {
            Listar();

            //Ejercicio 1
            //var consulta = (from alumno in bd.ALUMNOs
            //                select new
            //                {
            //                    nombreCompleto = alumno.NOMBREALUMNO + " " + alumno.APELLIDOPATERNOALUMNO + " " + alumno.APELLIDOMATERNOALUMNO,
            //                    curso = alumno.CURSOFAVORITO,
            //                    nivel = alumno.NIVELACADEMICO
            //                });
            //dgvVista.DataSource = consulta;

            //Ejercicio 2

            //var consulta = (from alumno in bd.ALUMNOs
            //                select new
            //                {
            //                    NombreCompleto = alumno.NOMBREALUMNO + " " + alumno.APELLIDOPATERNOALUMNO + " " + alumno.APELLIDOMATERNOALUMNO,
            //                    Nota1 = alumno.NOTA1,
            //                    Nota2 = alumno.NOTA2,
            //                    Nota3 = alumno.NOTA3,
            //                    Nota4 = alumno.NOTA4,
            //                    Promedio = (alumno.NOTA1 + alumno.NOTA2 + alumno.NOTA3 + alumno.NOTA4) / 4
            //                });
            //dgvVista.DataSource = consulta;

            //Ejercicio 3
            //    cbSeleccionar.SelectedIndex = 0;
            //    Listar();


            //}

            //private void Listar()
            //{
            //    dgvVista.DataSource = bd.ALUMNOs;
            //}
            //CursoLinQ1DataContext bd = new CursoLinQ1DataContext();
            //private void BtnBuscar_Click(object sender, EventArgs e)
            //{
            //    string nombre = cbSeleccionar.Text;
            //    int valor = int.Parse(txtValor.Text);

            //    var consulta = bd.ALUMNOs.Where(p => p.IDALUMNO == valor).Select(
            //        alumno => new
            //        {
            //            nombre = alumno.NOMBREALUMNO,
            //            nota1 = alumno.NOTA1,
            //            nota2 = alumno.NOTA2,
            //            nota3 = alumno.NOTA3,
            //            nota4 = alumno.NOTA4
            //        });
            //        dgvVista.DataSource = consulta;
            //}

            //private void BtnLimpiar_Click(object sender, EventArgs e)
            //{
            //    Listar();
            //}
        }


        //Ejercicio 4

        //private void Filtro(object sender, EventArgs e)
        //{
        //    string nombre = txtGrado.Text;
        //    var consulta = bd.ALUMNOs.Where(p => p.NIVELACADEMICO == nombre).Select
        //        ( alumno => new
        //        {
        //            Nombre = alumno.NOMBREALUMNO,
        //            ApellidoPaterno = alumno.APELLIDOPATERNOALUMNO,
        //            ApellidoMaterno = alumno.APELLIDOMATERNOALUMNO,
        //            CursoFavorito = alumno.CURSOFAVORITO
        //        });
        //    dgvVista.DataSource = consulta;
        //}

        //Ejercicio 5

        private void Listar()
        {
           dgvVista.DataSource = bd.ALUMNOs.Select(alumno => new { nombre = alumno.NOMBREALUMNO, suma = alumno.NOTA1 + alumno.NOTA2 + alumno.NOTA3 + alumno.NOTA4 });
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            decimal numero1 = nupRango1.Value;
            decimal numero2 = nupRango2.Value;

            dgvVista.DataSource = bd.ALUMNOs.Select(alumno => new { nombre = alumno.NOMBREALUMNO, suma = alumno.NOTA1 + alumno.NOTA2 + alumno.NOTA3 + alumno.NOTA4 }).
                Where(p => p.suma > nupRango1.Value && p.suma < nupRango2.Value);

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Listar();
            nupRango1.Value = 0;
            nupRango2.Value = 0;
        }
    }
}
    

