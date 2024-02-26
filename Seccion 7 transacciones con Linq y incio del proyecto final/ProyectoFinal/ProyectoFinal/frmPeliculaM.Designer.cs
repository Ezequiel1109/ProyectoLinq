
namespace ProyectoFinal
{
    partial class frmPeliculaM
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
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripLabel();
            this.toolModificar = new System.Windows.Forms.ToolStripLabel();
            this.toolEliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolSalir = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Location = new System.Drawing.Point(12, 102);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPelicula.Size = new System.Drawing.Size(667, 336);
            this.dgvPelicula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Nombre de la Pelicula :";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(309, 45);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(266, 20);
            this.txtPelicula.TabIndex = 2;
            this.txtPelicula.TextChanged += new System.EventHandler(this.Filtro);
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
            this.toolStrip1.Size = new System.Drawing.Size(753, 25);
            this.toolStrip1.TabIndex = 3;
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
            // frmPeliculaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPelicula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeliculaM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Pelicula";
            this.Load += new System.EventHandler(this.frmPeliculaM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNuevo;
        private System.Windows.Forms.ToolStripLabel toolModificar;
        private System.Windows.Forms.ToolStripLabel toolEliminar;
        private System.Windows.Forms.ToolStripLabel toolSalir;
    }
}