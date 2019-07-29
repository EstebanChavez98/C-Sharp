namespace ControlEscolar
{
    partial class frmAltaActividad
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
            this.lblClAct = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClAct
            // 
            this.lblClAct.AutoSize = true;
            this.lblClAct.Location = new System.Drawing.Point(29, 34);
            this.lblClAct.Name = "lblClAct";
            this.lblClAct.Size = new System.Drawing.Size(43, 17);
            this.lblClAct.TabIndex = 0;
            this.lblClAct.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(32, 54);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(100, 22);
            this.txtClave.TabIndex = 207;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(163, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtActividad.Location = new System.Drawing.Point(166, 54);
            this.txtActividad.MaxLength = 30;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(237, 22);
            this.txtActividad.TabIndex = 1;
            this.txtActividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActividad_KeyPress);
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(29, 90);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(60, 17);
            this.lblCreditos.TabIndex = 4;
            this.lblCreditos.Text = "Creditos";
            // 
            // txtCreditos
            // 
            this.txtCreditos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreditos.Location = new System.Drawing.Point(32, 110);
            this.txtCreditos.MaxLength = 1;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 22);
            this.txtCreditos.TabIndex = 2;
            this.txtCreditos.TextChanged += new System.EventHandler(this.txtCreditos_TextChanged);
            this.txtCreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditos_KeyPress);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(163, 90);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(42, 17);
            this.lblTutor.TabIndex = 6;
            this.lblTutor.Text = "Tutor";
            // 
            // txtTutor
            // 
            this.txtTutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTutor.Location = new System.Drawing.Point(166, 110);
            this.txtTutor.MaxLength = 30;
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(237, 22);
            this.txtTutor.TabIndex = 3;
            this.txtTutor.TextChanged += new System.EventHandler(this.txtTutor_TextChanged);
            this.txtTutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutor_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(81, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(216, 160);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 40);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAltaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 228);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTutor);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClAct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaActividad";
            this.Text = "Alta de Actividad";
            this.Load += new System.EventHandler(this.frmAltaActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClAct;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}