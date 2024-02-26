
namespace ProyectoFinal
{
    partial class frmSalaM
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripLabel();
            this.toolModificar = new System.Windows.Forms.ToolStripLabel();
            this.toolEliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolSalir = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.cbCine = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese Nombre Cine :";
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(12, 108);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.ReadOnly = true;
            this.dgvSala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSala.Size = new System.Drawing.Size(741, 336);
            this.dgvSala.TabIndex = 4;
            // 
            // cbCine
            // 
            this.cbCine.FormattingEnabled = true;
            this.cbCine.Location = new System.Drawing.Point(267, 50);
            this.cbCine.Name = "cbCine";
            this.cbCine.Size = new System.Drawing.Size(251, 21);
            this.cbCine.TabIndex = 8;
            this.cbCine.SelectionChangeCommitted += new System.EventHandler(this.Filtro);
            // 
            // frmSalaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCine);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSala);
            this.Name = "frmSalaM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Sala";
            this.Load += new System.EventHandler(this.frmSalaM_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolNuevo;
        private System.Windows.Forms.ToolStripLabel toolModificar;
        private System.Windows.Forms.ToolStripLabel toolEliminar;
        private System.Windows.Forms.ToolStripLabel toolSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSala;
        private System.Windows.Forms.ComboBox cbCine;
    }
}