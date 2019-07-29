namespace VentanaEmpleados
{
    partial class Form1
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblClaveDepartamento = new System.Windows.Forms.Label();
            this.txtClaveDepartamento = new System.Windows.Forms.TextBox();
            this.lblNombreDepartamento = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lblJefeDepartamento = new System.Windows.Forms.Label();
            this.txtJefeDepartamento = new System.Windows.Forms.TextBox();
            this.btnDGuardar = new System.Windows.Forms.Button();
            this.btnDLimpiar = new System.Windows.Forms.Button();
            this.btnDCosulta = new System.Windows.Forms.Button();
            this.btnDSalir = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblClaveEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtClaveEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.gbIdiomas = new System.Windows.Forms.GroupBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkPortugues = new System.Windows.Forms.CheckBox();
            this.chkChinoMandarin = new System.Windows.Forms.CheckBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbIdiomas.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDSalir);
            this.tabPage2.Controls.Add(this.btnDCosulta);
            this.tabPage2.Controls.Add(this.btnDLimpiar);
            this.tabPage2.Controls.Add(this.btnDGuardar);
            this.tabPage2.Controls.Add(this.txtJefeDepartamento);
            this.tabPage2.Controls.Add(this.txtNombreDepartamento);
            this.tabPage2.Controls.Add(this.txtClaveDepartamento);
            this.tabPage2.Controls.Add(this.lblJefeDepartamento);
            this.tabPage2.Controls.Add(this.lblNombreDepartamento);
            this.tabPage2.Controls.Add(this.lblClaveDepartamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblClaveDepartamento
            // 
            this.lblClaveDepartamento.AutoSize = true;
            this.lblClaveDepartamento.Location = new System.Drawing.Point(32, 35);
            this.lblClaveDepartamento.Name = "lblClaveDepartamento";
            this.lblClaveDepartamento.Size = new System.Drawing.Size(161, 17);
            this.lblClaveDepartamento.TabIndex = 0;
            this.lblClaveDepartamento.Text = "Clave de Departamento:";
            // 
            // txtClaveDepartamento
            // 
            this.txtClaveDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveDepartamento.Location = new System.Drawing.Point(35, 55);
            this.txtClaveDepartamento.Name = "txtClaveDepartamento";
            this.txtClaveDepartamento.Size = new System.Drawing.Size(251, 22);
            this.txtClaveDepartamento.TabIndex = 1;
            this.txtClaveDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveDepartamento_KeyPress);
            // 
            // lblNombreDepartamento
            // 
            this.lblNombreDepartamento.AutoSize = true;
            this.lblNombreDepartamento.Location = new System.Drawing.Point(32, 106);
            this.lblNombreDepartamento.Name = "lblNombreDepartamento";
            this.lblNombreDepartamento.Size = new System.Drawing.Size(176, 17);
            this.lblNombreDepartamento.TabIndex = 2;
            this.lblNombreDepartamento.Text = "Nombre de Departamento:";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDepartamento.Location = new System.Drawing.Point(35, 126);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(251, 22);
            this.txtNombreDepartamento.TabIndex = 3;
            this.txtNombreDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDepartamento_KeyPress);
            // 
            // lblJefeDepartamento
            // 
            this.lblJefeDepartamento.AutoSize = true;
            this.lblJefeDepartamento.Location = new System.Drawing.Point(32, 180);
            this.lblJefeDepartamento.Name = "lblJefeDepartamento";
            this.lblJefeDepartamento.Size = new System.Drawing.Size(153, 17);
            this.lblJefeDepartamento.TabIndex = 4;
            this.lblJefeDepartamento.Text = "Jefe de Departamento:";
            // 
            // txtJefeDepartamento
            // 
            this.txtJefeDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJefeDepartamento.Location = new System.Drawing.Point(35, 200);
            this.txtJefeDepartamento.Name = "txtJefeDepartamento";
            this.txtJefeDepartamento.Size = new System.Drawing.Size(251, 22);
            this.txtJefeDepartamento.TabIndex = 5;
            this.txtJefeDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJefeDepartamento_KeyPress);
            // 
            // btnDGuardar
            // 
            this.btnDGuardar.Location = new System.Drawing.Point(411, 35);
            this.btnDGuardar.Name = "btnDGuardar";
            this.btnDGuardar.Size = new System.Drawing.Size(141, 48);
            this.btnDGuardar.TabIndex = 6;
            this.btnDGuardar.Text = "GUARDAR";
            this.btnDGuardar.UseVisualStyleBackColor = true;
            this.btnDGuardar.Click += new System.EventHandler(this.btnDGuardar_Click);
            // 
            // btnDLimpiar
            // 
            this.btnDLimpiar.Location = new System.Drawing.Point(411, 106);
            this.btnDLimpiar.Name = "btnDLimpiar";
            this.btnDLimpiar.Size = new System.Drawing.Size(141, 48);
            this.btnDLimpiar.TabIndex = 7;
            this.btnDLimpiar.Text = "LIMPIAR";
            this.btnDLimpiar.UseVisualStyleBackColor = true;
            this.btnDLimpiar.Click += new System.EventHandler(this.btnDLimpiar_Click);
            // 
            // btnDCosulta
            // 
            this.btnDCosulta.Location = new System.Drawing.Point(411, 180);
            this.btnDCosulta.Name = "btnDCosulta";
            this.btnDCosulta.Size = new System.Drawing.Size(141, 48);
            this.btnDCosulta.TabIndex = 8;
            this.btnDCosulta.Text = "CONSULTA";
            this.btnDCosulta.UseVisualStyleBackColor = true;
            this.btnDCosulta.Click += new System.EventHandler(this.btnDCosulta_Click);
            // 
            // btnDSalir
            // 
            this.btnDSalir.Location = new System.Drawing.Point(411, 255);
            this.btnDSalir.Name = "btnDSalir";
            this.btnDSalir.Size = new System.Drawing.Size(141, 48);
            this.btnDSalir.TabIndex = 10;
            this.btnDSalir.Text = "SALIR";
            this.btnDSalir.UseVisualStyleBackColor = true;
            this.btnDSalir.Click += new System.EventHandler(this.btnDSalir_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnConsulta);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.gbSexo);
            this.tabPage1.Controls.Add(this.gbIdiomas);
            this.tabPage1.Controls.Add(this.cmbDepartamento);
            this.tabPage1.Controls.Add(this.txtDomicilio);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtClaveEmpleado);
            this.tabPage1.Controls.Add(this.lblDepartamento);
            this.tabPage1.Controls.Add(this.lblDomicilio);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblClaveEmpleado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleados";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblClaveEmpleado
            // 
            this.lblClaveEmpleado.AutoSize = true;
            this.lblClaveEmpleado.Location = new System.Drawing.Point(15, 36);
            this.lblClaveEmpleado.Name = "lblClaveEmpleado";
            this.lblClaveEmpleado.Size = new System.Drawing.Size(134, 17);
            this.lblClaveEmpleado.TabIndex = 0;
            this.lblClaveEmpleado.Text = "Clave de Empleado:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(15, 137);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(68, 17);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(462, 10);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(98, 17);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtClaveEmpleado
            // 
            this.txtClaveEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveEmpleado.Location = new System.Drawing.Point(155, 33);
            this.txtClaveEmpleado.Name = "txtClaveEmpleado";
            this.txtClaveEmpleado.Size = new System.Drawing.Size(198, 22);
            this.txtClaveEmpleado.TabIndex = 4;
            this.txtClaveEmpleado.TextChanged += new System.EventHandler(this.txtClaveEmpleado_TextChanged);
            this.txtClaveEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveEmpleado_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(98, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 22);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(98, 134);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(302, 22);
            this.txtDomicilio.TabIndex = 6;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(439, 36);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(162, 24);
            this.cmbDepartamento.TabIndex = 7;
            // 
            // gbIdiomas
            // 
            this.gbIdiomas.Controls.Add(this.chkChinoMandarin);
            this.gbIdiomas.Controls.Add(this.chkPortugues);
            this.gbIdiomas.Controls.Add(this.chkIngles);
            this.gbIdiomas.Location = new System.Drawing.Point(18, 181);
            this.gbIdiomas.Name = "gbIdiomas";
            this.gbIdiomas.Size = new System.Drawing.Size(212, 178);
            this.gbIdiomas.TabIndex = 8;
            this.gbIdiomas.TabStop = false;
            this.gbIdiomas.Text = "Idiomas";
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(18, 37);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(67, 21);
            this.chkIngles.TabIndex = 0;
            this.chkIngles.Text = "Ingles";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // chkPortugues
            // 
            this.chkPortugues.AutoSize = true;
            this.chkPortugues.Location = new System.Drawing.Point(18, 76);
            this.chkPortugues.Name = "chkPortugues";
            this.chkPortugues.Size = new System.Drawing.Size(95, 21);
            this.chkPortugues.TabIndex = 1;
            this.chkPortugues.Text = "Portugues";
            this.chkPortugues.UseVisualStyleBackColor = true;
            // 
            // chkChinoMandarin
            // 
            this.chkChinoMandarin.AutoSize = true;
            this.chkChinoMandarin.Location = new System.Drawing.Point(15, 113);
            this.chkChinoMandarin.Name = "chkChinoMandarin";
            this.chkChinoMandarin.Size = new System.Drawing.Size(129, 21);
            this.chkChinoMandarin.TabIndex = 2;
            this.chkChinoMandarin.Text = "Chino Mandarín";
            this.chkChinoMandarin.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdFemenino);
            this.gbSexo.Controls.Add(this.rdMasculino);
            this.gbSexo.Location = new System.Drawing.Point(249, 181);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(151, 178);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(19, 52);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(19, 101);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdFemenino.TabIndex = 1;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(456, 93);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(456, 152);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 42);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(456, 212);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 42);
            this.btnConsulta.TabIndex = 11;
            this.btnConsulta.Text = "CONSULTA";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 42);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Alta de Empleados y Departamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbIdiomas.ResumeLayout(false);
            this.gbIdiomas.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.GroupBox gbIdiomas;
        private System.Windows.Forms.CheckBox chkChinoMandarin;
        private System.Windows.Forms.CheckBox chkPortugues;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClaveEmpleado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClaveEmpleado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDSalir;
        private System.Windows.Forms.Button btnDCosulta;
        private System.Windows.Forms.Button btnDLimpiar;
        private System.Windows.Forms.Button btnDGuardar;
        private System.Windows.Forms.TextBox txtJefeDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.TextBox txtClaveDepartamento;
        private System.Windows.Forms.Label lblJefeDepartamento;
        private System.Windows.Forms.Label lblNombreDepartamento;
        private System.Windows.Forms.Label lblClaveDepartamento;
    }
}

