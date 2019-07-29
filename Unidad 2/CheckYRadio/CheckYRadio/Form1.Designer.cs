namespace CheckYRadio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCheckBox = new System.Windows.Forms.GroupBox();
            this.chkAnimadas = new System.Windows.Forms.CheckBox();
            this.chkCienciaF = new System.Windows.Forms.CheckBox();
            this.chkAccion = new System.Windows.Forms.CheckBox();
            this.chkComedia = new System.Windows.Forms.CheckBox();
            this.grpRadio = new System.Windows.Forms.GroupBox();
            this.rdAnimadas = new System.Windows.Forms.RadioButton();
            this.rdCienciaF = new System.Windows.Forms.RadioButton();
            this.rdAccion = new System.Windows.Forms.RadioButton();
            this.rdComedia = new System.Windows.Forms.RadioButton();
            this.btnPreferidas = new System.Windows.Forms.Button();
            this.btnFavorita = new System.Windows.Forms.Button();
            this.grpCheckBox.SuspendLayout();
            this.grpRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(290, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(131, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Peliculas";
            // 
            // grpCheckBox
            // 
            this.grpCheckBox.Controls.Add(this.chkAnimadas);
            this.grpCheckBox.Controls.Add(this.chkCienciaF);
            this.grpCheckBox.Controls.Add(this.chkAccion);
            this.grpCheckBox.Controls.Add(this.chkComedia);
            this.grpCheckBox.Location = new System.Drawing.Point(43, 73);
            this.grpCheckBox.Name = "grpCheckBox";
            this.grpCheckBox.Size = new System.Drawing.Size(299, 190);
            this.grpCheckBox.TabIndex = 1;
            this.grpCheckBox.TabStop = false;
            this.grpCheckBox.Text = "Tipo de Peliculas que Prefieres";
            // 
            // chkAnimadas
            // 
            this.chkAnimadas.AutoSize = true;
            this.chkAnimadas.Location = new System.Drawing.Point(21, 150);
            this.chkAnimadas.Name = "chkAnimadas";
            this.chkAnimadas.Size = new System.Drawing.Size(92, 21);
            this.chkAnimadas.TabIndex = 3;
            this.chkAnimadas.Text = "Animadas";
            this.chkAnimadas.UseVisualStyleBackColor = true;
            // 
            // chkCienciaF
            // 
            this.chkCienciaF.AutoSize = true;
            this.chkCienciaF.Location = new System.Drawing.Point(21, 109);
            this.chkCienciaF.Name = "chkCienciaF";
            this.chkCienciaF.Size = new System.Drawing.Size(124, 21);
            this.chkCienciaF.TabIndex = 2;
            this.chkCienciaF.Text = "Ciencia Ficción";
            this.chkCienciaF.UseVisualStyleBackColor = true;
            // 
            // chkAccion
            // 
            this.chkAccion.AutoSize = true;
            this.chkAccion.Location = new System.Drawing.Point(21, 73);
            this.chkAccion.Name = "chkAccion";
            this.chkAccion.Size = new System.Drawing.Size(72, 21);
            this.chkAccion.TabIndex = 1;
            this.chkAccion.Text = "Acción";
            this.chkAccion.UseVisualStyleBackColor = true;
            // 
            // chkComedia
            // 
            this.chkComedia.AutoSize = true;
            this.chkComedia.Location = new System.Drawing.Point(21, 36);
            this.chkComedia.Name = "chkComedia";
            this.chkComedia.Size = new System.Drawing.Size(85, 21);
            this.chkComedia.TabIndex = 0;
            this.chkComedia.Text = "Comedia";
            this.chkComedia.UseVisualStyleBackColor = true;
            // 
            // grpRadio
            // 
            this.grpRadio.Controls.Add(this.rdAnimadas);
            this.grpRadio.Controls.Add(this.rdCienciaF);
            this.grpRadio.Controls.Add(this.rdAccion);
            this.grpRadio.Controls.Add(this.rdComedia);
            this.grpRadio.Location = new System.Drawing.Point(406, 73);
            this.grpRadio.Name = "grpRadio";
            this.grpRadio.Size = new System.Drawing.Size(299, 190);
            this.grpRadio.TabIndex = 2;
            this.grpRadio.TabStop = false;
            this.grpRadio.Text = "Tipo que más te gusta:";
            this.grpRadio.Enter += new System.EventHandler(this.grpRadio_Enter);
            // 
            // rdAnimadas
            // 
            this.rdAnimadas.AutoSize = true;
            this.rdAnimadas.Location = new System.Drawing.Point(27, 150);
            this.rdAnimadas.Name = "rdAnimadas";
            this.rdAnimadas.Size = new System.Drawing.Size(91, 21);
            this.rdAnimadas.TabIndex = 3;
            this.rdAnimadas.TabStop = true;
            this.rdAnimadas.Text = "Animadas";
            this.rdAnimadas.UseVisualStyleBackColor = true;
            // 
            // rdCienciaF
            // 
            this.rdCienciaF.AutoSize = true;
            this.rdCienciaF.Location = new System.Drawing.Point(27, 109);
            this.rdCienciaF.Name = "rdCienciaF";
            this.rdCienciaF.Size = new System.Drawing.Size(123, 21);
            this.rdCienciaF.TabIndex = 2;
            this.rdCienciaF.TabStop = true;
            this.rdCienciaF.Text = "Ciencia Ficción";
            this.rdCienciaF.UseVisualStyleBackColor = true;
            // 
            // rdAccion
            // 
            this.rdAccion.AutoSize = true;
            this.rdAccion.Location = new System.Drawing.Point(27, 72);
            this.rdAccion.Name = "rdAccion";
            this.rdAccion.Size = new System.Drawing.Size(71, 21);
            this.rdAccion.TabIndex = 1;
            this.rdAccion.TabStop = true;
            this.rdAccion.Text = "Acción";
            this.rdAccion.UseVisualStyleBackColor = true;
            // 
            // rdComedia
            // 
            this.rdComedia.AutoSize = true;
            this.rdComedia.Location = new System.Drawing.Point(27, 35);
            this.rdComedia.Name = "rdComedia";
            this.rdComedia.Size = new System.Drawing.Size(84, 21);
            this.rdComedia.TabIndex = 0;
            this.rdComedia.TabStop = true;
            this.rdComedia.Text = "Comedia";
            this.rdComedia.UseVisualStyleBackColor = true;
            // 
            // btnPreferidas
            // 
            this.btnPreferidas.Location = new System.Drawing.Point(77, 285);
            this.btnPreferidas.Name = "btnPreferidas";
            this.btnPreferidas.Size = new System.Drawing.Size(205, 33);
            this.btnPreferidas.TabIndex = 3;
            this.btnPreferidas.Text = "Peliculas Seleccionadas";
            this.btnPreferidas.UseVisualStyleBackColor = true;
            this.btnPreferidas.Click += new System.EventHandler(this.btnPreferidas_Click);
            // 
            // btnFavorita
            // 
            this.btnFavorita.Location = new System.Drawing.Point(433, 286);
            this.btnFavorita.Name = "btnFavorita";
            this.btnFavorita.Size = new System.Drawing.Size(204, 32);
            this.btnFavorita.TabIndex = 4;
            this.btnFavorita.Text = "Favorita";
            this.btnFavorita.UseVisualStyleBackColor = true;
            this.btnFavorita.Click += new System.EventHandler(this.btnFavorita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 351);
            this.Controls.Add(this.btnFavorita);
            this.Controls.Add(this.btnPreferidas);
            this.Controls.Add(this.grpRadio);
            this.Controls.Add(this.grpCheckBox);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "CheckBox y RadioButtons";
            this.grpCheckBox.ResumeLayout(false);
            this.grpCheckBox.PerformLayout();
            this.grpRadio.ResumeLayout(false);
            this.grpRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCheckBox;
        private System.Windows.Forms.CheckBox chkAnimadas;
        private System.Windows.Forms.CheckBox chkCienciaF;
        private System.Windows.Forms.CheckBox chkAccion;
        private System.Windows.Forms.CheckBox chkComedia;
        private System.Windows.Forms.GroupBox grpRadio;
        private System.Windows.Forms.RadioButton rdAnimadas;
        private System.Windows.Forms.RadioButton rdCienciaF;
        private System.Windows.Forms.RadioButton rdAccion;
        private System.Windows.Forms.RadioButton rdComedia;
        private System.Windows.Forms.Button btnPreferidas;
        private System.Windows.Forms.Button btnFavorita;
    }
}

