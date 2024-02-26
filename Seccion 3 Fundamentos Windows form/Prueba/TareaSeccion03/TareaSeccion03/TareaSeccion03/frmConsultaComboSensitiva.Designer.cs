namespace TareaSeccion03
{
    partial class frmConsultaComboSensitiva
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
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Opción";
            // 
            // cboOpcion
            // 
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(162, 24);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(173, 21);
            this.cboOpcion.TabIndex = 1;
            this.cboOpcion.SelectionChangeCommitted += new System.EventHandler(this.filtrar);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(42, 77);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(451, 195);
            this.dgvEmpleado.TabIndex = 2;
            // 
            // frmConsultaComboSensitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 284);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.cboOpcion);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaComboSensitiva";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsultaComboSensitiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.DataGridView dgvEmpleado;
    }
}