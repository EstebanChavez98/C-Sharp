namespace Empleados
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
            this.cmbDeptos = new System.Windows.Forms.ComboBox();
            this.lblClaveDepto = new System.Windows.Forms.Label();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDeptos
            // 
            this.cmbDeptos.FormattingEnabled = true;
            this.cmbDeptos.Location = new System.Drawing.Point(183, 51);
            this.cmbDeptos.Name = "cmbDeptos";
            this.cmbDeptos.Size = new System.Drawing.Size(243, 24);
            this.cmbDeptos.TabIndex = 0;
            // 
            // lblClaveDepto
            // 
            this.lblClaveDepto.AutoSize = true;
            this.lblClaveDepto.Location = new System.Drawing.Point(236, 31);
            this.lblClaveDepto.Name = "lblClaveDepto";
            this.lblClaveDepto.Size = new System.Drawing.Size(157, 17);
            this.lblClaveDepto.TabIndex = 1;
            this.lblClaveDepto.Text = "Clave de Departamento";
            // 
            // lblNombreDepto
            // 
            this.lblNombreDepto.AutoSize = true;
            this.lblNombreDepto.Location = new System.Drawing.Point(275, 108);
            this.lblNombreDepto.Name = "lblNombreDepto";
            this.lblNombreDepto.Size = new System.Drawing.Size(58, 17);
            this.lblNombreDepto.TabIndex = 2;
            this.lblNombreDepto.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(243, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(287, 189);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(35, 17);
            this.lblJefe.TabIndex = 4;
            this.lblJefe.Text = "Jefe";
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(183, 209);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.ReadOnly = true;
            this.txtJefe.Size = new System.Drawing.Size(243, 22);
            this.txtJefe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 364);
            this.Controls.Add(this.txtJefe);
            this.Controls.Add(this.lblJefe);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreDepto);
            this.Controls.Add(this.lblClaveDepto);
            this.Controls.Add(this.cmbDeptos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeptos;
        private System.Windows.Forms.Label lblClaveDepto;
        private System.Windows.Forms.Label lblNombreDepto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.TextBox txtJefe;
    }
}

