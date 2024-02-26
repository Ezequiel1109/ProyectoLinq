
namespace ProyectoFinal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaPorEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaPorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaPorGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaPorEmpleadosToolStripMenuItem,
            this.reservaPorClientesToolStripMenuItem,
            this.peliculaPorGeneroToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(121, 54);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reservaPorEmpleadosToolStripMenuItem
            // 
            this.reservaPorEmpleadosToolStripMenuItem.Name = "reservaPorEmpleadosToolStripMenuItem";
            this.reservaPorEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reservaPorEmpleadosToolStripMenuItem.Text = "Reserva por Empleados";
            // 
            // reservaPorClientesToolStripMenuItem
            // 
            this.reservaPorClientesToolStripMenuItem.Name = "reservaPorClientesToolStripMenuItem";
            this.reservaPorClientesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reservaPorClientesToolStripMenuItem.Text = "Reserva por Clientes";
            // 
            // peliculaPorGeneroToolStripMenuItem
            // 
            this.peliculaPorGeneroToolStripMenuItem.Name = "peliculaPorGeneroToolStripMenuItem";
            this.peliculaPorGeneroToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.peliculaPorGeneroToolStripMenuItem.Text = "Pelicula Por Genero";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.cineToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.peliculaToolStripMenuItem,
            this.funcionToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(151, 54);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(214, 56);
            this.clienteToolStripMenuItem.Text = "Cliente ";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // cineToolStripMenuItem
            // 
            this.cineToolStripMenuItem.Name = "cineToolStripMenuItem";
            this.cineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cineToolStripMenuItem.Text = "Cine";
            this.cineToolStripMenuItem.Click += new System.EventHandler(this.cineToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // funcionToolStripMenuItem
            // 
            this.funcionToolStripMenuItem.Name = "funcionToolStripMenuItem";
            this.funcionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionToolStripMenuItem.Text = "Funcion";
            this.funcionToolStripMenuItem.Click += new System.EventHandler(this.funcionToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoDeReservaToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesosToolStripMenuItem.Image")));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(116, 54);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // procesoDeReservaToolStripMenuItem
            // 
            this.procesoDeReservaToolStripMenuItem.Name = "procesoDeReservaToolStripMenuItem";
            this.procesoDeReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procesoDeReservaToolStripMenuItem.Text = "Proceso de Reserva";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(91, 54);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 357);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaPorEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaPorClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaPorGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

