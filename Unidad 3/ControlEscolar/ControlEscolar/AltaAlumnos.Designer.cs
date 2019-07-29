namespace ControlEscolar
{
    partial class frmAltaAlumnos
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
            this.lblNumControl = new System.Windows.Forms.Label();
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApeP = new System.Windows.Forms.Label();
            this.txtApeP = new System.Windows.Forms.TextBox();
            this.lblApeM = new System.Windows.Forms.Label();
            this.txtApeM = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.mcNac = new System.Windows.Forms.MonthCalendar();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumControl
            // 
            this.lblNumControl.AutoSize = true;
            this.lblNumControl.Location = new System.Drawing.Point(28, 25);
            this.lblNumControl.Name = "lblNumControl";
            this.lblNumControl.Size = new System.Drawing.Size(127, 17);
            this.lblNumControl.TabIndex = 0;
            this.lblNumControl.Text = "Numero de Control";
            // 
            // txtNumControl
            // 
            this.txtNumControl.Location = new System.Drawing.Point(31, 45);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.ReadOnly = true;
            this.txtNumControl.Size = new System.Drawing.Size(187, 22);
            this.txtNumControl.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(31, 109);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblApeP
            // 
            this.lblApeP.AutoSize = true;
            this.lblApeP.Location = new System.Drawing.Point(308, 89);
            this.lblApeP.Name = "lblApeP";
            this.lblApeP.Size = new System.Drawing.Size(112, 17);
            this.lblApeP.TabIndex = 4;
            this.lblApeP.Text = "Apellido Paterno";
            // 
            // txtApeP
            // 
            this.txtApeP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeP.Location = new System.Drawing.Point(311, 109);
            this.txtApeP.MaxLength = 20;
            this.txtApeP.Name = "txtApeP";
            this.txtApeP.Size = new System.Drawing.Size(245, 22);
            this.txtApeP.TabIndex = 2;
            this.txtApeP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeP_KeyPress);
            // 
            // lblApeM
            // 
            this.lblApeM.AutoSize = true;
            this.lblApeM.Location = new System.Drawing.Point(590, 89);
            this.lblApeM.Name = "lblApeM";
            this.lblApeM.Size = new System.Drawing.Size(114, 17);
            this.lblApeM.TabIndex = 6;
            this.lblApeM.Text = "Apellido Materno";
            // 
            // txtApeM
            // 
            this.txtApeM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeM.Location = new System.Drawing.Point(593, 109);
            this.txtApeM.MaxLength = 20;
            this.txtApeM.Name = "txtApeM";
            this.txtApeM.Size = new System.Drawing.Size(245, 22);
            this.txtApeM.TabIndex = 3;
            this.txtApeM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeM_KeyPress);
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(28, 151);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(46, 17);
            this.lblCurp.TabIndex = 8;
            this.lblCurp.Text = "CURP";
            // 
            // txtCurp
            // 
            this.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurp.Location = new System.Drawing.Point(31, 171);
            this.txtCurp.MaxLength = 18;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(245, 22);
            this.txtCurp.TabIndex = 4;
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(308, 151);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(141, 17);
            this.lblFechaNac.TabIndex = 10;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(311, 171);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.ReadOnly = true;
            this.txtFechaNac.Size = new System.Drawing.Size(245, 22);
            this.txtFechaNac.TabIndex = 11;
            this.txtFechaNac.Click += new System.EventHandler(this.txtFechaNac_Click);
            // 
            // mcNac
            // 
            this.mcNac.Location = new System.Drawing.Point(593, 171);
            this.mcNac.Name = "mcNac";
            this.mcNac.TabIndex = 12;
            this.mcNac.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcNac_DateChanged);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(28, 213);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(64, 17);
            this.lbltelefono.TabIndex = 13;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(31, 233);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(245, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(311, 233);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(245, 24);
            this.cmbCarrera.TabIndex = 16;
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(28, 274);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(42, 17);
            this.lblTutor.TabIndex = 17;
            this.lblTutor.Text = "Tutor";
            // 
            // txtTutor
            // 
            this.txtTutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTutor.Location = new System.Drawing.Point(31, 294);
            this.txtTutor.MaxLength = 50;
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(525, 22);
            this.txtTutor.TabIndex = 6;
            this.txtTutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutor_KeyPress);
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdMasculino);
            this.grpSexo.Controls.Add(this.rdFemenino);
            this.grpSexo.Location = new System.Drawing.Point(31, 335);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(245, 72);
            this.grpSexo.TabIndex = 19;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(135, 33);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdMasculino.TabIndex = 20;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(14, 33);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdFemenino.TabIndex = 0;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(302, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAltaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 508);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.txtTutor);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.mcNac);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.txtApeM);
            this.Controls.Add(this.lblApeM);
            this.Controls.Add(this.txtApeP);
            this.Controls.Add(this.lblApeP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNumControl);
            this.Controls.Add(this.lblNumControl);
            this.Name = "frmAltaAlumnos";
            this.Text = "alta de Alumnos";
            this.Load += new System.EventHandler(this.frmAltaEmpleados_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumControl;
        private System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApeP;
        private System.Windows.Forms.TextBox txtApeP;
        private System.Windows.Forms.Label lblApeM;
        private System.Windows.Forms.TextBox txtApeM;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.MonthCalendar mcNac;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}