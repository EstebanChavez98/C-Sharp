namespace VentasMayoreo
{
    partial class ArticulosActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticulosActualizar));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbClaves = new System.Windows.Forms.ComboBox();
            this.txtPrecioCaptura = new System.Windows.Forms.TextBox();
            this.txtDescCaptura = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrecioCaptura = new System.Windows.Forms.Label();
            this.lblDescCaptura = new System.Windows.Forms.Label();
            this.lblClaveCaptura = new System.Windows.Forms.Label();
            this.gpbActualiza = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTituloCapturar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbActualiza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(208, 104);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 18);
            this.lblCategoria.TabIndex = 75;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbClaves
            // 
            this.cmbClaves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClaves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClaves.BackColor = System.Drawing.Color.DarkRed;
            this.cmbClaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClaves.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbClaves.FormattingEnabled = true;
            this.cmbClaves.Location = new System.Drawing.Point(45, 72);
            this.cmbClaves.Name = "cmbClaves";
            this.cmbClaves.Size = new System.Drawing.Size(141, 26);
            this.cmbClaves.TabIndex = 74;
            this.cmbClaves.SelectedIndexChanged += new System.EventHandler(this.cmbClaves_SelectedIndexChanged);
            // 
            // txtPrecioCaptura
            // 
            this.txtPrecioCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaptura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCaptura.Location = new System.Drawing.Point(20, 128);
            this.txtPrecioCaptura.MaxLength = 10;
            this.txtPrecioCaptura.Name = "txtPrecioCaptura";
            this.txtPrecioCaptura.Size = new System.Drawing.Size(100, 31);
            this.txtPrecioCaptura.TabIndex = 69;
            this.txtPrecioCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCaptura_KeyPress);
            // 
            // txtDescCaptura
            // 
            this.txtDescCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtDescCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCaptura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescCaptura.Location = new System.Drawing.Point(23, 65);
            this.txtDescCaptura.MaxLength = 50;
            this.txtDescCaptura.Multiline = true;
            this.txtDescCaptura.Name = "txtDescCaptura";
            this.txtDescCaptura.Size = new System.Drawing.Size(552, 24);
            this.txtDescCaptura.TabIndex = 68;
            this.txtDescCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescCaptura_KeyPress);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.DarkRed;
            this.txtCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCategoria.Location = new System.Drawing.Point(211, 128);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(240, 31);
            this.txtCategoria.TabIndex = 70;
            // 
            // lblPrecioCaptura
            // 
            this.lblPrecioCaptura.AutoSize = true;
            this.lblPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCaptura.Location = new System.Drawing.Point(17, 107);
            this.lblPrecioCaptura.Name = "lblPrecioCaptura";
            this.lblPrecioCaptura.Size = new System.Drawing.Size(54, 18);
            this.lblPrecioCaptura.TabIndex = 73;
            this.lblPrecioCaptura.Text = "Precio";
            // 
            // lblDescCaptura
            // 
            this.lblDescCaptura.AutoSize = true;
            this.lblDescCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCaptura.ForeColor = System.Drawing.Color.White;
            this.lblDescCaptura.Location = new System.Drawing.Point(20, 44);
            this.lblDescCaptura.Name = "lblDescCaptura";
            this.lblDescCaptura.Size = new System.Drawing.Size(94, 18);
            this.lblDescCaptura.TabIndex = 72;
            this.lblDescCaptura.Text = "Descripción";
            // 
            // lblClaveCaptura
            // 
            this.lblClaveCaptura.AutoSize = true;
            this.lblClaveCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCaptura.ForeColor = System.Drawing.Color.White;
            this.lblClaveCaptura.Location = new System.Drawing.Point(42, 51);
            this.lblClaveCaptura.Name = "lblClaveCaptura";
            this.lblClaveCaptura.Size = new System.Drawing.Size(48, 18);
            this.lblClaveCaptura.TabIndex = 71;
            this.lblClaveCaptura.Text = "Clave";
            // 
            // gpbActualiza
            // 
            this.gpbActualiza.BackColor = System.Drawing.Color.Firebrick;
            this.gpbActualiza.Controls.Add(this.btnRegistrar);
            this.gpbActualiza.Controls.Add(this.txtCategoria);
            this.gpbActualiza.Controls.Add(this.lblCategoria);
            this.gpbActualiza.Controls.Add(this.lblDescCaptura);
            this.gpbActualiza.Controls.Add(this.lblPrecioCaptura);
            this.gpbActualiza.Controls.Add(this.txtPrecioCaptura);
            this.gpbActualiza.Controls.Add(this.txtDescCaptura);
            this.gpbActualiza.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbActualiza.ForeColor = System.Drawing.Color.White;
            this.gpbActualiza.Location = new System.Drawing.Point(45, 143);
            this.gpbActualiza.Name = "gpbActualiza";
            this.gpbActualiza.Size = new System.Drawing.Size(603, 211);
            this.gpbActualiza.TabIndex = 76;
            this.gpbActualiza.TabStop = false;
            this.gpbActualiza.Text = "Modifica los campos deseados";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 3;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(474, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 35);
            this.btnRegistrar.TabIndex = 76;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTituloCapturar
            // 
            this.lblTituloCapturar.AutoSize = true;
            this.lblTituloCapturar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCapturar.ForeColor = System.Drawing.Color.White;
            this.lblTituloCapturar.Location = new System.Drawing.Point(230, 9);
            this.lblTituloCapturar.Name = "lblTituloCapturar";
            this.lblTituloCapturar.Size = new System.Drawing.Size(303, 25);
            this.lblTituloCapturar.TabIndex = 77;
            this.lblTituloCapturar.Text = "Actualización de artículos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ArticulosActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.Controls.Add(this.lblTituloCapturar);
            this.Controls.Add(this.gpbActualiza);
            this.Controls.Add(this.cmbClaves);
            this.Controls.Add(this.lblClaveCaptura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticulosActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Articulo";
            this.Load += new System.EventHandler(this.ArticulosActualizar_Load);
            this.gpbActualiza.ResumeLayout(false);
            this.gpbActualiza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbClaves;
        private System.Windows.Forms.TextBox txtPrecioCaptura;
        private System.Windows.Forms.TextBox txtDescCaptura;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrecioCaptura;
        private System.Windows.Forms.Label lblDescCaptura;
        private System.Windows.Forms.Label lblClaveCaptura;
        private System.Windows.Forms.GroupBox gpbActualiza;
        private System.Windows.Forms.Label lblTituloCapturar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}