namespace frmVentas
{
    partial class frmVentas
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
            this.lblVClaveCliente = new System.Windows.Forms.Label();
            this.txtVClaveCliente = new System.Windows.Forms.TextBox();
            this.lblVArticulos = new System.Windows.Forms.Label();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.txtVArticulo = new System.Windows.Forms.TextBox();
            this.txtVCantidad = new System.Windows.Forms.TextBox();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdContado = new System.Windows.Forms.RadioButton();
            this.rdCredito = new System.Windows.Forms.RadioButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVClaveCliente
            // 
            this.lblVClaveCliente.AutoSize = true;
            this.lblVClaveCliente.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVClaveCliente.ForeColor = System.Drawing.Color.Black;
            this.lblVClaveCliente.Location = new System.Drawing.Point(61, 18);
            this.lblVClaveCliente.Name = "lblVClaveCliente";
            this.lblVClaveCliente.Size = new System.Drawing.Size(136, 19);
            this.lblVClaveCliente.TabIndex = 0;
            this.lblVClaveCliente.Text = "Clave del Cliente:";
            // 
            // txtVClaveCliente
            // 
            this.txtVClaveCliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVClaveCliente.Location = new System.Drawing.Point(23, 40);
            this.txtVClaveCliente.Name = "txtVClaveCliente";
            this.txtVClaveCliente.Size = new System.Drawing.Size(204, 22);
            this.txtVClaveCliente.TabIndex = 1;
            // 
            // lblVArticulos
            // 
            this.lblVArticulos.AutoSize = true;
            this.lblVArticulos.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVArticulos.ForeColor = System.Drawing.Color.Black;
            this.lblVArticulos.Location = new System.Drawing.Point(119, 341);
            this.lblVArticulos.Name = "lblVArticulos";
            this.lblVArticulos.Size = new System.Drawing.Size(72, 19);
            this.lblVArticulos.TabIndex = 2;
            this.lblVArticulos.Text = "Articulo:";
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadArticulos.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadArticulos.Location = new System.Drawing.Point(409, 341);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(80, 19);
            this.lblCantidadArticulos.TabIndex = 4;
            this.lblCantidadArticulos.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(232, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArticulo.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarArticulo.Location = new System.Drawing.Point(692, 431);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(113, 43);
            this.btnGuardarArticulo.TabIndex = 7;
            this.btnGuardarArticulo.Text = "GUARDAR";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            // 
            // txtVArticulo
            // 
            this.txtVArticulo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVArticulo.Location = new System.Drawing.Point(45, 363);
            this.txtVArticulo.Name = "txtVArticulo";
            this.txtVArticulo.Size = new System.Drawing.Size(204, 22);
            this.txtVArticulo.TabIndex = 9;
            // 
            // txtVCantidad
            // 
            this.txtVCantidad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVCantidad.Location = new System.Drawing.Point(336, 363);
            this.txtVCantidad.Name = "txtVCantidad";
            this.txtVCantidad.Size = new System.Drawing.Size(204, 22);
            this.txtVCantidad.TabIndex = 10;
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.textBox2);
            this.gbVenta.Controls.Add(this.label1);
            this.gbVenta.Controls.Add(this.btnGuardarArticulo);
            this.gbVenta.Controls.Add(this.txtVCantidad);
            this.gbVenta.Controls.Add(this.btnAgregar);
            this.gbVenta.Controls.Add(this.textBox1);
            this.gbVenta.Controls.Add(this.lblCantidadArticulos);
            this.gbVenta.Controls.Add(this.txtVArticulo);
            this.gbVenta.Controls.Add(this.lblVArticulos);
            this.gbVenta.Controls.Add(this.lblCliente);
            this.gbVenta.Location = new System.Drawing.Point(25, 148);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(839, 495);
            this.gbVenta.TabIndex = 11;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCredito);
            this.groupBox1.Controls.Add(this.rdContado);
            this.groupBox1.Controls.Add(this.txtVClaveCliente);
            this.groupBox1.Controls.Add(this.lblVClaveCliente);
            this.groupBox1.Location = new System.Drawing.Point(361, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de compra";
            // 
            // rdContado
            // 
            this.rdContado.AutoSize = true;
            this.rdContado.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdContado.ForeColor = System.Drawing.Color.Black;
            this.rdContado.Location = new System.Drawing.Point(36, 68);
            this.rdContado.Name = "rdContado";
            this.rdContado.Size = new System.Drawing.Size(81, 20);
            this.rdContado.TabIndex = 0;
            this.rdContado.TabStop = true;
            this.rdContado.Text = "Contado";
            this.rdContado.UseVisualStyleBackColor = true;
            // 
            // rdCredito
            // 
            this.rdCredito.AutoSize = true;
            this.rdCredito.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCredito.ForeColor = System.Drawing.Color.Black;
            this.rdCredito.Location = new System.Drawing.Point(133, 68);
            this.rdCredito.Name = "rdCredito";
            this.rdCredito.Size = new System.Drawing.Size(75, 20);
            this.rdCredito.TabIndex = 13;
            this.rdCredito.TabStop = true;
            this.rdCredito.Text = "Credito";
            this.rdCredito.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(68, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Clave Venta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(621, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 16;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(990, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVenta);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVClaveCliente;
        private System.Windows.Forms.TextBox txtVClaveCliente;
        private System.Windows.Forms.Label lblVArticulos;
        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.TextBox txtVArticulo;
        private System.Windows.Forms.TextBox txtVCantidad;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCredito;
        private System.Windows.Forms.RadioButton rdContado;
    }
}

