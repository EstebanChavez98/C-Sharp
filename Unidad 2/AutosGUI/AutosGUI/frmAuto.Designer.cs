namespace AutosGUI
{
    partial class frmAuto
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
            this.lblMarcaAuto = new System.Windows.Forms.Label();
            this.cmbMarcaAuto = new System.Windows.Forms.ComboBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblNombreAuto = new System.Windows.Forms.Label();
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdEstandar = new System.Windows.Forms.RadioButton();
            this.rdAutomatica = new System.Windows.Forms.RadioButton();
            this.btnGuardarAuto = new System.Windows.Forms.Button();
            this.btnLimpiarAuto = new System.Windows.Forms.Button();
            this.btnSalirAuto = new System.Windows.Forms.Button();
            this.nudPasajeros = new System.Windows.Forms.NumericUpDown();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaAuto
            // 
            this.lblMarcaAuto.AutoSize = true;
            this.lblMarcaAuto.Location = new System.Drawing.Point(40, 170);
            this.lblMarcaAuto.Name = "lblMarcaAuto";
            this.lblMarcaAuto.Size = new System.Drawing.Size(47, 17);
            this.lblMarcaAuto.TabIndex = 0;
            this.lblMarcaAuto.Text = "Marca";
            // 
            // cmbMarcaAuto
            // 
            this.cmbMarcaAuto.FormattingEnabled = true;
            this.cmbMarcaAuto.Location = new System.Drawing.Point(43, 190);
            this.cmbMarcaAuto.Name = "cmbMarcaAuto";
            this.cmbMarcaAuto.Size = new System.Drawing.Size(185, 24);
            this.cmbMarcaAuto.TabIndex = 3;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(37, 31);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(119, 17);
            this.lblNumSerie.TabIndex = 2;
            this.lblNumSerie.Text = "Numero de Serie:";
            this.lblNumSerie.Click += new System.EventHandler(this.lblNumSerie_Click);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumSerie.Location = new System.Drawing.Point(43, 57);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(243, 22);
            this.txtNumSerie.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumSerie, "Proporcione el numero de serie del auto.");
            this.txtNumSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumSerie_KeyPress);
            // 
            // lblNombreAuto
            // 
            this.lblNombreAuto.AutoSize = true;
            this.lblNombreAuto.Location = new System.Drawing.Point(37, 106);
            this.lblNombreAuto.Name = "lblNombreAuto";
            this.lblNombreAuto.Size = new System.Drawing.Size(115, 17);
            this.lblNombreAuto.TabIndex = 4;
            this.lblNombreAuto.Text = "Nombre de Auto:";
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAuto.Location = new System.Drawing.Point(43, 126);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(243, 22);
            this.txtNombreAuto.TabIndex = 2;
            this.txtNombreAuto.TextChanged += new System.EventHandler(this.txtNombreAuto_TextChanged);
            this.txtNombreAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAuto_KeyPress);
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(319, 31);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(159, 17);
            this.lblPasajeros.TabIndex = 6;
            this.lblPasajeros.Text = "Num. Maximo Pasajeros";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdEstandar);
            this.grpTipo.Controls.Add(this.rdAutomatica);
            this.grpTipo.Location = new System.Drawing.Point(322, 106);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(200, 108);
            this.grpTipo.TabIndex = 7;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Transmisión:";
            // 
            // rdEstandar
            // 
            this.rdEstandar.AutoSize = true;
            this.rdEstandar.Location = new System.Drawing.Point(27, 64);
            this.rdEstandar.Name = "rdEstandar";
            this.rdEstandar.Size = new System.Drawing.Size(86, 21);
            this.rdEstandar.TabIndex = 6;
            this.rdEstandar.TabStop = true;
            this.rdEstandar.Text = "Estandar";
            this.rdEstandar.UseVisualStyleBackColor = true;
            // 
            // rdAutomatica
            // 
            this.rdAutomatica.AutoSize = true;
            this.rdAutomatica.Location = new System.Drawing.Point(27, 29);
            this.rdAutomatica.Name = "rdAutomatica";
            this.rdAutomatica.Size = new System.Drawing.Size(99, 21);
            this.rdAutomatica.TabIndex = 5;
            this.rdAutomatica.TabStop = true;
            this.rdAutomatica.Text = "Automatica";
            this.rdAutomatica.UseVisualStyleBackColor = true;
            // 
            // btnGuardarAuto
            // 
            this.btnGuardarAuto.Location = new System.Drawing.Point(12, 250);
            this.btnGuardarAuto.Name = "btnGuardarAuto";
            this.btnGuardarAuto.Size = new System.Drawing.Size(113, 43);
            this.btnGuardarAuto.TabIndex = 7;
            this.btnGuardarAuto.Text = "Guardar";
            this.btnGuardarAuto.UseVisualStyleBackColor = true;
            this.btnGuardarAuto.Click += new System.EventHandler(this.btnGuardarAuto_Click);
            // 
            // btnLimpiarAuto
            // 
            this.btnLimpiarAuto.Location = new System.Drawing.Point(150, 250);
            this.btnLimpiarAuto.Name = "btnLimpiarAuto";
            this.btnLimpiarAuto.Size = new System.Drawing.Size(113, 43);
            this.btnLimpiarAuto.TabIndex = 8;
            this.btnLimpiarAuto.Text = "Limpiar";
            this.btnLimpiarAuto.UseVisualStyleBackColor = true;
            this.btnLimpiarAuto.Click += new System.EventHandler(this.btnLimpiarAuto_Click);
            // 
            // btnSalirAuto
            // 
            this.btnSalirAuto.Location = new System.Drawing.Point(431, 250);
            this.btnSalirAuto.Name = "btnSalirAuto";
            this.btnSalirAuto.Size = new System.Drawing.Size(113, 43);
            this.btnSalirAuto.TabIndex = 10;
            this.btnSalirAuto.Text = "Salir";
            this.btnSalirAuto.UseVisualStyleBackColor = true;
            this.btnSalirAuto.Click += new System.EventHandler(this.btnSalirAuto_Click);
            // 
            // nudPasajeros
            // 
            this.nudPasajeros.Location = new System.Drawing.Point(328, 57);
            this.nudPasajeros.Name = "nudPasajeros";
            this.nudPasajeros.Size = new System.Drawing.Size(150, 22);
            this.nudPasajeros.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(292, 250);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(113, 43);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 332);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.nudPasajeros);
            this.Controls.Add(this.btnSalirAuto);
            this.Controls.Add(this.btnLimpiarAuto);
            this.Controls.Add(this.btnGuardarAuto);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.txtNombreAuto);
            this.Controls.Add(this.lblNombreAuto);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.cmbMarcaAuto);
            this.Controls.Add(this.lblMarcaAuto);
            this.Name = "frmAuto";
            this.Text = "Captura de Autos";
            this.Load += new System.EventHandler(this.frmAuto_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaAuto;
        private System.Windows.Forms.ComboBox cmbMarcaAuto;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblNombreAuto;
        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdEstandar;
        private System.Windows.Forms.RadioButton rdAutomatica;
        private System.Windows.Forms.Button btnGuardarAuto;
        private System.Windows.Forms.Button btnLimpiarAuto;
        private System.Windows.Forms.Button btnSalirAuto;
        private System.Windows.Forms.NumericUpDown nudPasajeros;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}