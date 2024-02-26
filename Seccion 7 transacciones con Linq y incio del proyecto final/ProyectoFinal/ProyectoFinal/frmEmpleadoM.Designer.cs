
namespace ProyectoFinal
{
    partial class frmEmpleadoM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVistaE = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripLabel();
            this.toolModificar = new System.Windows.Forms.ToolStripLabel();
            this.toolEliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolSalir = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaE)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(321, 47);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(178, 20);
            this.txtNombreM.TabIndex = 10;
            this.txtNombreM.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese Nombre :";
            // 
            // dgvVistaE
            // 
            this.dgvVistaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaE.Location = new System.Drawing.Point(12, 98);
            this.dgvVistaE.Name = "dgvVistaE";
            this.dgvVistaE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVistaE.Size = new System.Drawing.Size(835, 340);
            this.dgvVistaE.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolModificar,
            this.toolEliminar,
            this.toolSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 7;
            // 
            // toolNuevo
            // 
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(42, 22);
            this.toolNuevo.Text = "Nuevo";
            this.toolNuevo.Click += new System.EventHandler(this.toolNuevo_Click);
            // 
            // toolModificar
            // 
            this.toolModificar.Name = "toolModificar";
            this.toolModificar.Size = new System.Drawing.Size(58, 22);
            this.toolModificar.Text = "Modificar";
            this.toolModificar.Click += new System.EventHandler(this.toolModificar_Click);
            // 
            // toolEliminar
            // 
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(50, 22);
            this.toolEliminar.Text = "Eliminar";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // toolSalir
            // 
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(29, 22);
            this.toolSalir.Text = "Salir";
            // 
            // frmEmpleadoM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVistaE);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEmpleadoM";
            this.Text = "Mantenimiento Empleado";
            this.Load += new System.EventHandler(this.frmEmpleadoM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaE)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVistaE;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNuevo;
        private System.Windows.Forms.ToolStripLabel toolModificar;
        private System.Windows.Forms.ToolStripLabel toolEliminar;
        private System.Windows.Forms.ToolStripLabel toolSalir;
    }
}