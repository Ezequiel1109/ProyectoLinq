
namespace ProyectoFinal
{
    partial class frmPopUpSala
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCine = new System.Windows.Forms.ComboBox();
            this.nupButacas = new System.Windows.Forms.NumericUpDown();
            this.nupFilas = new System.Windows.Forms.NumericUpDown();
            this.nupColumnas = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.errorPopUpSala = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupButacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopUpSala)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Butacas : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Filas : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Columnas: ";
            // 
            // cbCine
            // 
            this.cbCine.FormattingEnabled = true;
            this.cbCine.Location = new System.Drawing.Point(204, 33);
            this.cbCine.Name = "cbCine";
            this.cbCine.Size = new System.Drawing.Size(170, 21);
            this.cbCine.TabIndex = 4;
            // 
            // nupButacas
            // 
            this.nupButacas.Location = new System.Drawing.Point(205, 123);
            this.nupButacas.Name = "nupButacas";
            this.nupButacas.Size = new System.Drawing.Size(170, 20);
            this.nupButacas.TabIndex = 5;
            // 
            // nupFilas
            // 
            this.nupFilas.Location = new System.Drawing.Point(205, 169);
            this.nupFilas.Name = "nupFilas";
            this.nupFilas.Size = new System.Drawing.Size(170, 20);
            this.nupFilas.TabIndex = 6;
            // 
            // nupColumnas
            // 
            this.nupColumnas.Location = new System.Drawing.Point(205, 214);
            this.nupColumnas.Name = "nupColumnas";
            this.nupColumnas.Size = new System.Drawing.Size(170, 20);
            this.nupColumnas.TabIndex = 7;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(103, 287);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(275, 287);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorPopUpSala
            // 
            this.errorPopUpSala.ContainerControl = this;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(204, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Sala :";
            // 
            // frmPopUpSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 365);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.nupColumnas);
            this.Controls.Add(this.nupFilas);
            this.Controls.Add(this.nupButacas);
            this.Controls.Add(this.cbCine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPopUpSala";
            this.Text = "Ingresar Sala";
            this.Load += new System.EventHandler(this.frmPopUpSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupButacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopUpSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCine;
        private System.Windows.Forms.NumericUpDown nupButacas;
        private System.Windows.Forms.NumericUpDown nupFilas;
        private System.Windows.Forms.NumericUpDown nupColumnas;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider errorPopUpSala;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
    }
}