namespace VentasMayoreo
{
    partial class ConsultaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaArticulos));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbClaves = new System.Windows.Forms.ComboBox();
            this.txtPrecioCaptura = new System.Windows.Forms.TextBox();
            this.txtDescCaptura = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrecioCaptura = new System.Windows.Forms.Label();
            this.lblDescCaptura = new System.Windows.Forms.Label();
            this.lblClaveCaptura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(219, 196);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 16);
            this.lblCategoria.TabIndex = 67;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbClaves
            // 
            this.cmbClaves.BackColor = System.Drawing.Color.DarkRed;
            this.cmbClaves.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClaves.ForeColor = System.Drawing.Color.White;
            this.cmbClaves.FormattingEnabled = true;
            this.cmbClaves.Location = new System.Drawing.Point(82, 74);
            this.cmbClaves.Name = "cmbClaves";
            this.cmbClaves.Size = new System.Drawing.Size(141, 24);
            this.cmbClaves.TabIndex = 66;
            this.cmbClaves.SelectedIndexChanged += new System.EventHandler(this.cmbClaves_SelectedIndexChanged);
            // 
            // txtPrecioCaptura
            // 
            this.txtPrecioCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.txtPrecioCaptura.Location = new System.Drawing.Point(31, 220);
            this.txtPrecioCaptura.MaxLength = 10;
            this.txtPrecioCaptura.Name = "txtPrecioCaptura";
            this.txtPrecioCaptura.ReadOnly = true;
            this.txtPrecioCaptura.Size = new System.Drawing.Size(100, 27);
            this.txtPrecioCaptura.TabIndex = 61;
            // 
            // txtDescCaptura
            // 
            this.txtDescCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtDescCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCaptura.ForeColor = System.Drawing.Color.White;
            this.txtDescCaptura.Location = new System.Drawing.Point(34, 157);
            this.txtDescCaptura.MaxLength = 50;
            this.txtDescCaptura.Multiline = true;
            this.txtDescCaptura.Name = "txtDescCaptura";
            this.txtDescCaptura.ReadOnly = true;
            this.txtDescCaptura.Size = new System.Drawing.Size(552, 24);
            this.txtDescCaptura.TabIndex = 60;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.DarkRed;
            this.txtCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(222, 220);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(240, 27);
            this.txtCategoria.TabIndex = 62;
            // 
            // lblPrecioCaptura
            // 
            this.lblPrecioCaptura.AutoSize = true;
            this.lblPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCaptura.Location = new System.Drawing.Point(28, 199);
            this.lblPrecioCaptura.Name = "lblPrecioCaptura";
            this.lblPrecioCaptura.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioCaptura.TabIndex = 65;
            this.lblPrecioCaptura.Text = "Precio";
            // 
            // lblDescCaptura
            // 
            this.lblDescCaptura.AutoSize = true;
            this.lblDescCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCaptura.ForeColor = System.Drawing.Color.White;
            this.lblDescCaptura.Location = new System.Drawing.Point(31, 136);
            this.lblDescCaptura.Name = "lblDescCaptura";
            this.lblDescCaptura.Size = new System.Drawing.Size(83, 16);
            this.lblDescCaptura.TabIndex = 64;
            this.lblDescCaptura.Text = "Descripción";
            // 
            // lblClaveCaptura
            // 
            this.lblClaveCaptura.AutoSize = true;
            this.lblClaveCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCaptura.ForeColor = System.Drawing.Color.White;
            this.lblClaveCaptura.Location = new System.Drawing.Point(31, 77);
            this.lblClaveCaptura.Name = "lblClaveCaptura";
            this.lblClaveCaptura.Size = new System.Drawing.Size(42, 16);
            this.lblClaveCaptura.TabIndex = 63;
            this.lblClaveCaptura.Text = "Clave";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(234, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 25);
            this.lblTitulo.TabIndex = 68;
            this.lblTitulo.Text = "Consulta Individual";
            // 
            // ConsultaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(677, 299);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbClaves);
            this.Controls.Add(this.txtPrecioCaptura);
            this.Controls.Add(this.txtDescCaptura);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblPrecioCaptura);
            this.Controls.Add(this.lblDescCaptura);
            this.Controls.Add(this.lblClaveCaptura);
           
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Articulos";
            this.Load += new System.EventHandler(this.ConsultaArticulos_Load);
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
        private System.Windows.Forms.Label lblTitulo;
    }
}