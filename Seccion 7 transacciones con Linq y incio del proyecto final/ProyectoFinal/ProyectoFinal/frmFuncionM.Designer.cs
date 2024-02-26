
namespace ProyectoFinal
{
    partial class frmFuncionM
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFuncionM = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripLabel();
            this.toolModificar = new System.Windows.Forms.ToolStripLabel();
            this.toolEliminar = new System.Windows.Forms.ToolStripLabel();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionM)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Pelicula :";
            // 
            // dgvFuncionM
            // 
            this.dgvFuncionM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionM.Location = new System.Drawing.Point(25, 98);
            this.dgvFuncionM.Name = "dgvFuncionM";
            this.dgvFuncionM.ReadOnly = true;
            this.dgvFuncionM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionM.Size = new System.Drawing.Size(835, 340);
            this.dgvFuncionM.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolModificar,
            this.toolEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 25);
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
            // cbPelicula
            // 
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(330, 46);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(121, 21);
            this.cbPelicula.TabIndex = 10;
            this.cbPelicula.SelectionChangeCommitted += new System.EventHandler(this.Filtro);
            // 
            // frmFuncionM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.cbPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFuncionM);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmFuncionM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Funcion";
            this.Load += new System.EventHandler(this.frmFuncionM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionM)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFuncionM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNuevo;
        private System.Windows.Forms.ToolStripLabel toolModificar;
        private System.Windows.Forms.ToolStripLabel toolEliminar;
        private System.Windows.Forms.ComboBox cbPelicula;
    }
}