namespace BibliotecaGUI
{
    partial class frmAltaLibros
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
            this.lblAltaLibros = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.grpUso = new System.Windows.Forms.GroupBox();
            this.rdGeneral = new System.Windows.Forms.RadioButton();
            this.rdInterno = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.chkAlumno = new System.Windows.Forms.CheckBox();
            this.chkMaestro = new System.Windows.Forms.CheckBox();
            this.grpUso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltaLibros
            // 
            this.lblAltaLibros.AutoSize = true;
            this.lblAltaLibros.Location = new System.Drawing.Point(340, 21);
            this.lblAltaLibros.Name = "lblAltaLibros";
            this.lblAltaLibros.Size = new System.Drawing.Size(99, 17);
            this.lblAltaLibros.TabIndex = 0;
            this.lblAltaLibros.Text = "Datos del libro";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(52, 53);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 17);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISBN.Location = new System.Drawing.Point(55, 73);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(123, 22);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(207, 53);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(117, 17);
            this.lblNombreLibro.TabIndex = 3;
            this.lblNombreLibro.Text = "Nombre del Libro";
            this.lblNombreLibro.Click += new System.EventHandler(this.lblNombreLibro_Click);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreLibro.Location = new System.Drawing.Point(210, 73);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(334, 22);
            this.txtNombreLibro.TabIndex = 4;
            this.txtNombreLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(591, 53);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(67, 17);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor(es)";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Location = new System.Drawing.Point(582, 73);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(250, 22);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(52, 129);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(59, 17);
            this.lblEditorial.TabIndex = 7;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditorial.Location = new System.Drawing.Point(55, 149);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(123, 22);
            this.txtEditorial.TabIndex = 8;
            this.txtEditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorial_KeyPress);
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(207, 129);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(71, 17);
            this.lblExistencia.TabIndex = 9;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExistencia.Location = new System.Drawing.Point(210, 149);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(138, 22);
            this.txtExistencia.TabIndex = 10;
            this.txtExistencia.TextChanged += new System.EventHandler(this.txtExistencia_TextChanged);
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // grpUso
            // 
            this.grpUso.Controls.Add(this.rdGeneral);
            this.grpUso.Controls.Add(this.rdInterno);
            this.grpUso.Location = new System.Drawing.Point(55, 191);
            this.grpUso.Name = "grpUso";
            this.grpUso.Size = new System.Drawing.Size(137, 134);
            this.grpUso.TabIndex = 11;
            this.grpUso.TabStop = false;
            this.grpUso.Text = "Para uso:";
            this.grpUso.Enter += new System.EventHandler(this.grpUso_Enter);
            // 
            // rdGeneral
            // 
            this.rdGeneral.AutoSize = true;
            this.rdGeneral.Location = new System.Drawing.Point(25, 81);
            this.rdGeneral.Name = "rdGeneral";
            this.rdGeneral.Size = new System.Drawing.Size(80, 21);
            this.rdGeneral.TabIndex = 1;
            this.rdGeneral.TabStop = true;
            this.rdGeneral.Text = "General";
            this.rdGeneral.UseVisualStyleBackColor = true;
            this.rdGeneral.CheckedChanged += new System.EventHandler(this.rdGeneral_CheckedChanged);
            // 
            // rdInterno
            // 
            this.rdInterno.AutoSize = true;
            this.rdInterno.Location = new System.Drawing.Point(25, 45);
            this.rdInterno.Name = "rdInterno";
            this.rdInterno.Size = new System.Drawing.Size(73, 21);
            this.rdInterno.TabIndex = 0;
            this.rdInterno.TabStop = true;
            this.rdInterno.Text = "Interno";
            this.rdInterno.UseVisualStyleBackColor = true;
            this.rdInterno.CheckedChanged += new System.EventHandler(this.rdInterno_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(554, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 43);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(554, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 43);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(737, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 43);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(737, 191);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(137, 43);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.chkMaestro);
            this.grpUsuario.Controls.Add(this.chkAlumno);
            this.grpUsuario.Location = new System.Drawing.Point(239, 193);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(200, 132);
            this.grpUsuario.TabIndex = 17;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuario";
            this.grpUsuario.Visible = false;
            // 
            // chkAlumno
            // 
            this.chkAlumno.AutoSize = true;
            this.chkAlumno.Location = new System.Drawing.Point(34, 44);
            this.chkAlumno.Name = "chkAlumno";
            this.chkAlumno.Size = new System.Drawing.Size(77, 21);
            this.chkAlumno.TabIndex = 0;
            this.chkAlumno.Text = "Alumno";
            this.chkAlumno.UseVisualStyleBackColor = true;
            // 
            // chkMaestro
            // 
            this.chkMaestro.AutoSize = true;
            this.chkMaestro.Location = new System.Drawing.Point(34, 80);
            this.chkMaestro.Name = "chkMaestro";
            this.chkMaestro.Size = new System.Drawing.Size(81, 21);
            this.chkMaestro.TabIndex = 1;
            this.chkMaestro.Text = "Maestro";
            this.chkMaestro.UseVisualStyleBackColor = true;
            // 
            // frmAltaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 364);
            this.ControlBox = false;
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpUso);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAltaLibros);
            this.Name = "frmAltaLibros";
            this.Text = "Alta de Libros";
            this.Load += new System.EventHandler(this.frmAltaLibros_Load);
            this.grpUso.ResumeLayout(false);
            this.grpUso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaLibros;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.GroupBox grpUso;
        private System.Windows.Forms.RadioButton rdGeneral;
        private System.Windows.Forms.RadioButton rdInterno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.CheckBox chkMaestro;
        private System.Windows.Forms.CheckBox chkAlumno;
    }
}