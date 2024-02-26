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

namespace MiAplicacion6
{
    public partial class PopUP : Form
    {
        public string Accion { get; set; }
        public string id { get; set; }
        public PopUP()
        {
            InitializeComponent();
        }
        NorthwindDataContext bd = new NorthwindDataContext();
        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void PopUP_Load(object sender, EventArgs e)
        {
            if (Accion.Equals("Nuevo"))
            {
                this.Text = "Ingresar Territorio";
            }
            else
            {
                this.Text = "Editar Territorio";
                var consulta = bd.Territories.Where(p => p.TerritoryID.Equals(id));
                foreach (Territory ter in consulta)
                {
                    txtId.Text = ter.TerritoryID;
                    txtNombre.Text = ter.TerritoryDescription;
                    cbRegion.SelectedValue = ter.RegionID;
                }
            }
            cbRegion.DataSource = bd.Regions.ToList();
            cbRegion.DisplayMember = "RegionDescription";
            cbRegion.ValueMember = "RegionID";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                errorPopUp.SetError(txtNombre, "Ingrese Nombre");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtNombre, ""); 
            }

            if (txtId.Text.Equals(""))
            {
                errorPopUp.SetError(txtId, "Ingrese ID");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                errorPopUp.SetError(txtId, "");
            }
            if (Accion.Equals("Nuevo"))
            {
                //Insertar datos
                string id = txtId.Text;
                string nombre = txtNombre.Text;
                int idRegion = int.Parse(cbRegion.SelectedValue.ToString());
                Territory ter = new Territory()
                {
                    TerritoryID = id,
                    TerritoryDescription = nombre,
                    RegionID = idRegion,
                    BHabilitado = true
                };

                bd.Territories.InsertOnSubmit(ter);
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se Agrego Correctamente ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                //Editar los valores
                var consulta = bd.Territories.Where(p => p.TerritoryID.Equals(id));

                foreach (Territory ter in consulta)
                {
                    ter.TerritoryDescription = txtNombre.Text;
                    ter.RegionID =int.Parse(cbRegion.SelectedValue.ToString());
                }
                try
                {
                    bd.SubmitChanges();
                    MessageBox.Show("Se actualizo orrectamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
    }
}
