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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        
        private void Form2_Load(object sender, EventArgs e)
        {            
            cboRegion.DataSource = bd.Regions;
            cboRegion.DisplayMember = "RegionDescription";
            cboRegion.ValueMember = "RegionID";

            dgvVista.DataSource = (from territorio in bd.Territories
                                   join region in bd.Regions on
                                   territorio.RegionID equals region.RegionID
                                   select new
                                   {
                                       territorio.TerritoryDescription,
                                       region.RegionDescription
                                   });
        }

        private void Filtro(object sender, EventArgs e)
        {
            int id = int.Parse(cboRegion.SelectedValue.ToString());

            dgvVista.DataSource = (from territorio in bd.Territories
                                   join region in bd.Regions on
                                   territorio.RegionID equals region.RegionID
                                   where territorio.RegionID.Equals(id)
                                   select new
                                   {
                                       territorio.TerritoryDescription,
                                       region.RegionDescription
                                   });
        }
    }
}
