
namespace ProyectoFinal
{
    partial class frmReserva
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
            this.txtprecioTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.cboTipoEntraba = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvButacas = new System.Windows.Forms.DataGridView();
            this.txtsala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.txtdniCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreEmpleado = new System.Windows.Forms.TextBox();
            this.BtnBuscarEmpleado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtprecioTotal
            // 
            this.txtprecioTotal.Location = new System.Drawing.Point(554, 678);
            this.txtprecioTotal.Name = "txtprecioTotal";
            this.txtprecioTotal.ReadOnly = true;
            this.txtprecioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtprecioTotal.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 685);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Precio Total:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 685);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(217, 685);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 20;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox4.Controls.Add(this.txtprecio);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BtnEliminar);
            this.groupBox4.Controls.Add(this.BtnAgregar);
            this.groupBox4.Controls.Add(this.dgvDetalleReserva);
            this.groupBox4.Controls.Add(this.cboTipoEntraba);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(27, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(799, 164);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(444, 14);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(115, 20);
            this.txtprecio.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(369, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "PRECIO";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(683, 11);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(602, 11);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReserva.Location = new System.Drawing.Point(11, 40);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.ReadOnly = true;
            this.dgvDetalleReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleReserva.Size = new System.Drawing.Size(767, 118);
            this.dgvDetalleReserva.TabIndex = 7;
            // 
            // cboTipoEntraba
            // 
            this.cboTipoEntraba.FormattingEnabled = true;
            this.cboTipoEntraba.Location = new System.Drawing.Point(162, 13);
            this.cboTipoEntraba.Name = "cboTipoEntraba";
            this.cboTipoEntraba.Size = new System.Drawing.Size(184, 21);
            this.cboTipoEntraba.TabIndex = 6;
            this.cboTipoEntraba.SelectedIndexChanged += new System.EventHandler(this.ObtenerPrecio);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "TIPO ENTRADA";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Controls.Add(this.dgvClientes);
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtapellido);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(27, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 148);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(11, 43);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(747, 99);
            this.dgvClientes.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(471, 20);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(147, 20);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.TextChanged += new System.EventHandler(this.FiltroRUT);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "DNI";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(162, 17);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(147, 20);
            this.txtapellido.TabIndex = 1;
            this.txtapellido.TextChanged += new System.EventHandler(this.FiltroApellido);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "APELLIDO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.dgvButacas);
            this.groupBox2.Controls.Add(this.txtsala);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboFuncion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboPelicula);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboCine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(27, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 176);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Reserva";
            // 
            // dgvButacas
            // 
            this.dgvButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButacas.Location = new System.Drawing.Point(14, 64);
            this.dgvButacas.Name = "dgvButacas";
            this.dgvButacas.ReadOnly = true;
            this.dgvButacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvButacas.Size = new System.Drawing.Size(744, 106);
            this.dgvButacas.TabIndex = 8;
            // 
            // txtsala
            // 
            this.txtsala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsala.Location = new System.Drawing.Point(658, 29);
            this.txtsala.Name = "txtsala";
            this.txtsala.ReadOnly = true;
            this.txtsala.Size = new System.Drawing.Size(100, 20);
            this.txtsala.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(609, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "SALA";
            // 
            // cboFuncion
            // 
            this.cboFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Location = new System.Drawing.Point(471, 28);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(121, 21);
            this.cboFuncion.TabIndex = 5;
            this.cboFuncion.SelectedIndexChanged += new System.EventHandler(this.ObtenerSala);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "FUNCION";
            // 
            // cboPelicula
            // 
            this.cboPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(272, 28);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(121, 21);
            this.cboPelicula.TabIndex = 3;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.ObtenerPelicula);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "PELICULA";
            // 
            // cboCine
            // 
            this.cboCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCine.FormattingEnabled = true;
            this.cboCine.Location = new System.Drawing.Point(59, 28);
            this.cboCine.Name = "cboCine";
            this.cboCine.Size = new System.Drawing.Size(121, 21);
            this.cboCine.TabIndex = 1;
            this.cboCine.SelectedIndexChanged += new System.EventHandler(this.ObtenerPeliculas);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CINE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.txtnombreCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtdniCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnombreEmpleado);
            this.groupBox1.Controls.Add(this.BtnBuscarEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcodigoEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreCliente.Location = new System.Drawing.Point(484, 62);
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.Size = new System.Drawing.Size(297, 20);
            this.txtnombreCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOMBRE CLIENTE";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(272, 62);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(46, 23);
            this.BtnBuscarCliente.TabIndex = 7;
            this.BtnBuscarCliente.Text = "...";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtdniCliente
            // 
            this.txtdniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdniCliente.Location = new System.Drawing.Point(140, 62);
            this.txtdniCliente.Name = "txtdniCliente";
            this.txtdniCliente.ReadOnly = true;
            this.txtdniCliente.Size = new System.Drawing.Size(126, 20);
            this.txtdniCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID CLIENTE";
            // 
            // txtnombreEmpleado
            // 
            this.txtnombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreEmpleado.Location = new System.Drawing.Point(484, 29);
            this.txtnombreEmpleado.Name = "txtnombreEmpleado";
            this.txtnombreEmpleado.Size = new System.Drawing.Size(297, 20);
            this.txtnombreEmpleado.TabIndex = 4;
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(272, 26);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(46, 23);
            this.BtnBuscarEmpleado.TabIndex = 3;
            this.BtnBuscarEmpleado.Text = "...";
            this.BtnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BtnBuscarEmpleado.Click += new System.EventHandler(this.BtnBuscarEmpleado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE EMPLEADO";
            // 
            // txtcodigoEmpleado
            // 
            this.txtcodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoEmpleado.Location = new System.Drawing.Point(140, 26);
            this.txtcodigoEmpleado.Name = "txtcodigoEmpleado";
            this.txtcodigoEmpleado.ReadOnly = true;
            this.txtcodigoEmpleado.Size = new System.Drawing.Size(126, 20);
            this.txtcodigoEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO EMPLEADO";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 720);
            this.Controls.Add(this.txtprecioTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReserva";
            this.Text = "Proceso de Rerva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButacas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprecioTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleReserva;
        private System.Windows.Forms.ComboBox cboTipoEntraba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvButacas;
        private System.Windows.Forms.TextBox txtsala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFuncion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox txtdniCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreEmpleado;
        private System.Windows.Forms.Button BtnBuscarEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoEmpleado;
        private System.Windows.Forms.Label label1;
    }
}