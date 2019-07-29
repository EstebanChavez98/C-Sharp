namespace VentasMayoreo
{
    partial class Almacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacenes));
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.lblTituloCapturar = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPrecioCaptura = new System.Windows.Forms.Label();
            this.txtPrecioCaptura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSucursales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSucursales.BackColor = System.Drawing.Color.DarkRed;
            this.cmbSucursales.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursales.ForeColor = System.Drawing.Color.White;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(97, 102);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(339, 26);
            this.cmbSucursales.TabIndex = 88;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.cmbSucursales_SelectedIndexChanged);
            this.cmbSucursales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSucursales_KeyPress);
            // 
            // lblTituloCapturar
            // 
            this.lblTituloCapturar.AutoSize = true;
            this.lblTituloCapturar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCapturar.ForeColor = System.Drawing.Color.White;
            this.lblTituloCapturar.Location = new System.Drawing.Point(92, 19);
            this.lblTituloCapturar.Name = "lblTituloCapturar";
            this.lblTituloCapturar.Size = new System.Drawing.Size(445, 25);
            this.lblTituloCapturar.TabIndex = 87;
            this.lblTituloCapturar.Text = "Actualización de Entradas de Artículos";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(94, 80);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(67, 18);
            this.lblClave.TabIndex = 86;
            this.lblClave.Text = "Sucursal";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbArticulos.BackColor = System.Drawing.Color.DarkRed;
            this.cmbArticulos.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulos.ForeColor = System.Drawing.Color.White;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(97, 178);
            this.cmbArticulos.MaxDropDownItems = 5;
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(339, 26);
            this.cmbArticulos.TabIndex = 90;
            this.cmbArticulos.SelectedIndexChanged += new System.EventHandler(this.cmbArticulos_SelectedIndexChanged);
            this.cmbArticulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbArticulos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Artículo";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.DarkRed;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.nudCantidad.Location = new System.Drawing.Point(125, 256);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 24);
            this.nudCantidad.TabIndex = 91;
            this.nudCantidad.ThousandsSeparator = true;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nuevo ingreso";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Brown;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatAppearance.BorderSize = 3;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(315, 248);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 38);
            this.btnRegistrar.TabIndex = 93;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPrecioCaptura
            // 
            this.lblPrecioCaptura.AutoSize = true;
            this.lblPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCaptura.Location = new System.Drawing.Point(446, 152);
            this.lblPrecioCaptura.Name = "lblPrecioCaptura";
            this.lblPrecioCaptura.Size = new System.Drawing.Size(129, 18);
            this.lblPrecioCaptura.TabIndex = 95;
            this.lblPrecioCaptura.Text = "Existencia actual";
            // 
            // txtPrecioCaptura
            // 
            this.txtPrecioCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaptura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCaptura.Location = new System.Drawing.Point(449, 173);
            this.txtPrecioCaptura.MaxLength = 10;
            this.txtPrecioCaptura.Name = "txtPrecioCaptura";
            this.txtPrecioCaptura.ReadOnly = true;
            this.txtPrecioCaptura.Size = new System.Drawing.Size(100, 31);
            this.txtPrecioCaptura.TabIndex = 94;
            // 
            // Almacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.lblPrecioCaptura);
            this.Controls.Add(this.txtPrecioCaptura);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.lblTituloCapturar);
            this.Controls.Add(this.lblClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Almacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label lblTituloCapturar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPrecioCaptura;
        private System.Windows.Forms.TextBox txtPrecioCaptura;
    }
}