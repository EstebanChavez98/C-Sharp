namespace VentasMayoreo
{
    partial class ArticulosConsultaNombre
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.txtPrecioCaptura = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblPrecioCaptura = new System.Windows.Forms.Label();
            this.lblDescCaptura = new System.Windows.Forms.Label();
            this.lblClaveCaptura = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(206, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 25);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "Consulta Individual";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(198, 151);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 18);
            this.lblCategoria.TabIndex = 76;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbNombres
            // 
            this.cmbNombres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbNombres.BackColor = System.Drawing.Color.DarkRed;
            this.cmbNombres.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres.ForeColor = System.Drawing.Color.White;
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(60, 78);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(462, 26);
            this.cmbNombres.TabIndex = 75;
            this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.cmbClaves_SelectedIndexChanged);
            this.cmbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClaves_KeyPress);
            // 
            // txtPrecioCaptura
            // 
            this.txtPrecioCaptura.BackColor = System.Drawing.Color.DarkRed;
            this.txtPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.txtPrecioCaptura.Location = new System.Drawing.Point(54, 256);
            this.txtPrecioCaptura.MaxLength = 10;
            this.txtPrecioCaptura.Name = "txtPrecioCaptura";
            this.txtPrecioCaptura.ReadOnly = true;
            this.txtPrecioCaptura.Size = new System.Drawing.Size(100, 31);
            this.txtPrecioCaptura.TabIndex = 70;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.DarkRed;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.White;
            this.txtClave.Location = new System.Drawing.Point(60, 175);
            this.txtClave.MaxLength = 50;
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(94, 24);
            this.txtClave.TabIndex = 69;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.DarkRed;
            this.txtCategoria.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(201, 175);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(321, 31);
            this.txtCategoria.TabIndex = 71;
            // 
            // lblPrecioCaptura
            // 
            this.lblPrecioCaptura.AutoSize = true;
            this.lblPrecioCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCaptura.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCaptura.Location = new System.Drawing.Point(51, 235);
            this.lblPrecioCaptura.Name = "lblPrecioCaptura";
            this.lblPrecioCaptura.Size = new System.Drawing.Size(54, 18);
            this.lblPrecioCaptura.TabIndex = 74;
            this.lblPrecioCaptura.Text = "Precio";
            // 
            // lblDescCaptura
            // 
            this.lblDescCaptura.AutoSize = true;
            this.lblDescCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCaptura.ForeColor = System.Drawing.Color.White;
            this.lblDescCaptura.Location = new System.Drawing.Point(57, 57);
            this.lblDescCaptura.Name = "lblDescCaptura";
            this.lblDescCaptura.Size = new System.Drawing.Size(94, 18);
            this.lblDescCaptura.TabIndex = 73;
            this.lblDescCaptura.Text = "Descripción";
            // 
            // lblClaveCaptura
            // 
            this.lblClaveCaptura.AutoSize = true;
            this.lblClaveCaptura.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCaptura.ForeColor = System.Drawing.Color.White;
            this.lblClaveCaptura.Location = new System.Drawing.Point(57, 154);
            this.lblClaveCaptura.Name = "lblClaveCaptura";
            this.lblClaveCaptura.Size = new System.Drawing.Size(48, 18);
            this.lblClaveCaptura.TabIndex = 72;
            this.lblClaveCaptura.Text = "Clave";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ArticulosConsultaNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(593, 348);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.txtPrecioCaptura);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblPrecioCaptura);
            this.Controls.Add(this.lblDescCaptura);
            this.Controls.Add(this.lblClaveCaptura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArticulosConsultaNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta por Nombre";
            this.Load += new System.EventHandler(this.ArticulosConsultaNombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.TextBox txtPrecioCaptura;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblPrecioCaptura;
        private System.Windows.Forms.Label lblDescCaptura;
        private System.Windows.Forms.Label lblClaveCaptura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}