using NorthwindContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Listar el id del territorio, nombre, region

            var consulta = (from territorio in bd.Territories
                            join region in bd.Regions
                            on territorio.RegionID equals region.RegionID
                            select new
                            {
                                territorio.TerritoryID,
                                territorio.TerritoryDescription,
                                region.RegionDescription
                            });
            dgvVista.DataSource = consulta;
        }
    }
}
