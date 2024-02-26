namespace MiPrimeraAplicacion
{
    partial class Test
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
            this.dgvVista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupRango1 = new System.Windows.Forms.NumericUpDown();
            this.nupRango2 = new System.Windows.Forms.NumericUpDown();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRango1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRango2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVista
            // 
            this.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVista.Location = new System.Drawing.Point(51, 154);
            this.dgvVista.Name = "dgvVista";
            this.dgvVista.Size = new System.Drawing.Size(628, 273);
            this.dgvVista.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Rango 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresar Rango 2";
            // 
            // nupRango1
            // 
            this.nupRango1.Location = new System.Drawing.Point(159, 36);
            this.nupRango1.Name = "nupRango1";
            this.nupRango1.Size = new System.Drawing.Size(120, 20);
            this.nupRango1.TabIndex = 6;
            // 
            // nupRango2
            // 
            this.nupRango2.Location = new System.Drawing.Point(493, 38);
            this.nupRango2.Name = "nupRango2";
            this.nupRango2.Size = new System.Drawing.Size(120, 20);
            this.nupRango2.TabIndex = 7;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(239, 94);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 8;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(381, 94);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.nupRango2);
            this.Controls.Add(this.nupRango1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVista);
            this.Controls.Add(this.label2);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRango1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRango2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupRango1;
        private System.Windows.Forms.NumericUpDown nupRango2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}