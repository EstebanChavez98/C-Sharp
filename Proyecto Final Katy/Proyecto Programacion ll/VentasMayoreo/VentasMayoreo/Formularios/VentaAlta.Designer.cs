namespace VentasMayoreo.Formularios
{
    partial class VentaAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaAlta));
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblVClaveCliente = new System.Windows.Forms.Label();
            this.rdContado = new System.Windows.Forms.RadioButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOperacion = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detalleVenta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.lblVArticulos = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.grpVenta.SuspendLayout();
            this.grpOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVenta
            // 
            this.grpVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpVenta.Controls.Add(this.cmbClientes);
            this.grpVenta.Controls.Add(this.lblVClaveCliente);
            this.grpVenta.Controls.Add(this.rdContado);
            this.grpVenta.Controls.Add(this.rdCredito);
            this.grpVenta.Controls.Add(this.label2);
            this.grpVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpVenta.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVenta.ForeColor = System.Drawing.Color.White;
            this.error.SetIconPadding(this.grpVenta, 2);
            this.grpVenta.Location = new System.Drawing.Point(221, 2);
            this.grpVenta.Margin = new System.Windows.Forms.Padding(2);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Padding = new System.Windows.Forms.Padding(2);
            this.grpVenta.Size = new System.Drawing.Size(470, 130);
            this.grpVenta.TabIndex = 16;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Venta";
            this.grpVenta.Visible = false;
            // 
            // cmbClientes
            // 
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.BackColor = System.Drawing.Color.DarkRed;
            this.cmbClientes.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.ForeColor = System.Drawing.Color.White;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(15, 47);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(321, 26);
            this.cmbClientes.Sorted = true;
            this.cmbClientes.TabIndex = 0;
            // 
            // lblVClaveCliente
            // 
            this.lblVClaveCliente.AutoSize = true;
            this.lblVClaveCliente.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVClaveCliente.ForeColor = System.Drawing.Color.White;
            this.lblVClaveCliente.Location = new System.Drawing.Point(90, 27);
            this.lblVClaveCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVClaveCliente.Name = "lblVClaveCliente";
            this.lblVClaveCliente.Size = new System.Drawing.Size(160, 18);
            this.lblVClaveCliente.TabIndex = 0;
            this.lblVClaveCliente.Text = "Seleccione El Cliente";
            // 
            // rdContado
            // 
            this.rdContado.AutoSize = true;
            this.rdContado.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdContado.ForeColor = System.Drawing.Color.White;
            this.rdContado.Location = new System.Drawing.Point(355, 42);
            this.rdContado.Margin = new System.Windows.Forms.Padding(2);
            this.rdContado.Name = "rdContado";
            this.rdContado.Size = new System.Drawing.Size(90, 22);
            this.rdContado.TabIndex = 1;
            this.rdContado.TabStop = true;
            this.rdContado.Text = "Contado";
            this.rdContado.UseVisualStyleBackColor = true;
            this.rdContado.Click += new System.EventHandler(this.rdContado_Click);
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCredito.ForeColor = System.Drawing.Color.White;
            this.rdCredito.Location = new System.Drawing.Point(355, 68);
            this.rdCredito.Margin = new System.Windows.Forms.Padding(2);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(82, 22);
            this.rdCredito.TabIndex = 2;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Credito";
            this.rdCredito.UseVisualStyleBackColor = true;
            this.rdCredito.Click += new System.EventHandler(this.rdContado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo De Compra:";
            // 
            // grpOperacion
            // 
            this.grpOperacion.Controls.Add(this.lblMonto);
            this.grpOperacion.Controls.Add(this.txtMonto);
            this.grpOperacion.Controls.Add(this.cantidad);
            this.grpOperacion.Controls.Add(this.btnEliminar);
            this.grpOperacion.Controls.Add(this.cmbArticulos);
            this.grpOperacion.Controls.Add(this.txtTotal);
            this.grpOperacion.Controls.Add(this.label4);
            this.grpOperacion.Controls.Add(this.label3);
            this.grpOperacion.Controls.Add(this.detalleVenta);
            this.grpOperacion.Controls.Add(this.btnGuardarArticulo);
            this.grpOperacion.Controls.Add(this.btnAgregar);
            this.grpOperacion.Controls.Add(this.txtCliente);
            this.grpOperacion.Controls.Add(this.lblCantidadArticulos);
            this.grpOperacion.Controls.Add(this.lblVArticulos);
            this.grpOperacion.Controls.Add(this.lblCliente);
            this.grpOperacion.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperacion.ForeColor = System.Drawing.Color.White;
            this.grpOperacion.Location = new System.Drawing.Point(43, 182);
            this.grpOperacion.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperacion.Name = "grpOperacion";
            this.grpOperacion.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperacion.Size = new System.Drawing.Size(746, 462);
            this.grpOperacion.TabIndex = 15;
            this.grpOperacion.TabStop = false;
            this.grpOperacion.Text = "Operacion";
            this.grpOperacion.Visible = false;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(337, 10);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(218, 20);
            this.lblMonto.TabIndex = 24;
            this.lblMonto.Text = "Monto Maximo De Credito";
            this.lblMonto.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.DarkRed;
            this.txtMonto.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(360, 32);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(154, 26);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.DarkRed;
            this.cantidad.ForeColor = System.Drawing.Color.White;
            this.cantidad.Location = new System.Drawing.Point(326, 372);
            this.cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 32);
            this.cantidad.TabIndex = 22;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.ValueChanged += new System.EventHandler(this.cantidad_ValueChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(33, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 36);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArticulos.BackColor = System.Drawing.Color.DarkRed;
            this.cmbArticulos.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulos.ForeColor = System.Drawing.Color.White;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(33, 375);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(228, 24);
            this.cmbArticulos.Sorted = true;
            this.cmbArticulos.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DarkRed;
            this.txtTotal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(533, 372);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(167, 27);
            this.txtTotal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(580, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Detalle De Venta";
            // 
            // detalleVenta
            // 
            this.detalleVenta.BackColor = System.Drawing.Color.DarkGray;
            this.detalleVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.detalleVenta.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleVenta.ForeColor = System.Drawing.Color.Black;
            this.detalleVenta.Location = new System.Drawing.Point(20, 79);
            this.detalleVenta.MultiSelect = false;
            this.detalleVenta.Name = "detalleVenta";
            this.detalleVenta.Size = new System.Drawing.Size(712, 274);
            this.detalleVenta.TabIndex = 17;
            this.detalleVenta.UseCompatibleStateImageBehavior = false;
            this.detalleVenta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Clave";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 336;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Importe";
            this.columnHeader4.Width = 87;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuardarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarArticulo.FlatAppearance.BorderSize = 3;
            this.btnGuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarArticulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArticulo.Location = new System.Drawing.Point(565, 410);
            this.btnGuardarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(124, 31);
            this.btnGuardarArticulo.TabIndex = 7;
            this.btnGuardarArticulo.Text = "Guardar Venta";
            this.btnGuardarArticulo.UseVisualStyleBackColor = false;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(219, 405);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.DarkRed;
            this.txtCliente.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(20, 32);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(248, 26);
            this.txtCliente.TabIndex = 14;
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadArticulos.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadArticulos.Location = new System.Drawing.Point(338, 357);
            this.lblCantidadArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(65, 16);
            this.lblCantidadArticulos.TabIndex = 4;
            this.lblCantidadArticulos.Text = "Cantidad:";
            // 
            // lblVArticulos
            // 
            this.lblVArticulos.AutoSize = true;
            this.lblVArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVArticulos.ForeColor = System.Drawing.Color.Black;
            this.lblVArticulos.Location = new System.Drawing.Point(129, 357);
            this.lblVArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVArticulos.Name = "lblVArticulos";
            this.lblVArticulos.Size = new System.Drawing.Size(55, 16);
            this.lblVArticulos.TabIndex = 2;
            this.lblVArticulos.Text = "Articulo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(93, 10);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 20);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.BackColor = System.Drawing.Color.DarkRed;
            this.cmbEmpleados.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleados.ForeColor = System.Drawing.Color.White;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(496, 153);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(220, 24);
            this.cmbEmpleados.TabIndex = 22;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(563, 134);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 16);
            this.lblEmpleado.TabIndex = 23;
            this.lblEmpleado.Text = " Empleado";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.BackColor = System.Drawing.Color.DarkRed;
            this.cmbSucursales.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursales.ForeColor = System.Drawing.Color.White;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(156, 153);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(271, 24);
            this.cmbSucursales.TabIndex = 24;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.Color.White;
            this.lblSucursal.Location = new System.Drawing.Point(218, 134);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(149, 16);
            this.lblSucursal.TabIndex = 25;
            this.lblSucursal.Text = "Seleccione La Sucursal";
            // 
            // VentaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(838, 648);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.grpOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentaAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentaAlta";
            this.Load += new System.EventHandler(this.VentaAlta_Load);
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
            this.grpOperacion.ResumeLayout(false);
            this.grpOperacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblVClaveCliente;
        private System.Windows.Forms.RadioButton rdContado;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOperacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView detalleVenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Label lblVArticulos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
    }
}