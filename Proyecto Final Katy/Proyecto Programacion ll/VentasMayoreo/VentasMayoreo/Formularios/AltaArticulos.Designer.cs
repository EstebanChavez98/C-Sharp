﻿namespace VentasMayoreo
{
    partial class AltaArticulos
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
            this.lblTituloCapturar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecioCaptura = new System.Windows.Forms.TextBox();
            this.txtDescCaptura = new System.Windows.Forms.TextBox();
            this.txtClaveCaptura = new System.Windows.Forms.TextBox();
            this.lblPrecioCaptura = new System.Windows.Forms.Label();
            this.lblDescCaptura = new System.Windows.Forms.Label();
            this.lblClaveCaptura = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCapturar
            // 
            this.lblTituloCapturar.AutoSize = true;
            this.lblTituloCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCapturar.Location = new System.Drawing.Point(232, 39);
            this.lblTituloCapturar.Name = "lblTituloCapturar";
            this.lblTituloCapturar.Size = new System.Drawing.Size(225, 25);
            this.lblTituloCapturar.TabIndex = 57;
            this.lblTituloCapturar.Text = "Captura de artículos";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(71, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 31);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(475, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 20;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(556, 257);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 31);
            this.btnRegistrar.TabIndex = 48;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecioCaptura
            // 
            this.txtPrecioCaptura.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtPrecioCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCaptura.Location = new System.Drawing.Point(237, 108);
            this.txtPrecioCaptura.MaxLength = 10;
            this.txtPrecioCaptura.Name = "txtPrecioCaptura";
            this.txtPrecioCaptura.Size = new System.Drawing.Size(100, 24);
            this.txtPrecioCaptura.TabIndex = 46;
            this.txtPrecioCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCaptura_KeyPress);
            // 
            // txtDescCaptura
            // 
            this.txtDescCaptura.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDescCaptura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescCaptura.Location = new System.Drawing.Point(98, 154);
            this.txtDescCaptura.MaxLength = 50;
            this.txtDescCaptura.Multiline = true;
            this.txtDescCaptura.Name = "txtDescCaptura";
            this.txtDescCaptura.Size = new System.Drawing.Size(552, 21);
            this.txtDescCaptura.TabIndex = 45;
            this.txtDescCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescCaptura_KeyPress);
            // 
            // txtClaveCaptura
            // 
            this.txtClaveCaptura.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtClaveCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCaptura.Location = new System.Drawing.Point(95, 108);
            this.txtClaveCaptura.Name = "txtClaveCaptura";
            this.txtClaveCaptura.ReadOnly = true;
            this.txtClaveCaptura.Size = new System.Drawing.Size(44, 24);
            this.txtClaveCaptura.TabIndex = 52;
            // 
            // lblPrecioCaptura
            // 
            this.lblPrecioCaptura.AutoSize = true;
            this.lblPrecioCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCaptura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrecioCaptura.Location = new System.Drawing.Point(183, 110);
            this.lblPrecioCaptura.Name = "lblPrecioCaptura";
            this.lblPrecioCaptura.Size = new System.Drawing.Size(51, 18);
            this.lblPrecioCaptura.TabIndex = 55;
            this.lblPrecioCaptura.Text = "Precio";
            // 
            // lblDescCaptura
            // 
            this.lblDescCaptura.AutoSize = true;
            this.lblDescCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCaptura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescCaptura.Location = new System.Drawing.Point(10, 154);
            this.lblDescCaptura.Name = "lblDescCaptura";
            this.lblDescCaptura.Size = new System.Drawing.Size(87, 18);
            this.lblDescCaptura.TabIndex = 54;
            this.lblDescCaptura.Text = "Descripción";
            // 
            // lblClaveCaptura
            // 
            this.lblClaveCaptura.AutoSize = true;
            this.lblClaveCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCaptura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClaveCaptura.Location = new System.Drawing.Point(44, 110);
            this.lblClaveCaptura.Name = "lblClaveCaptura";
            this.lblClaveCaptura.Size = new System.Drawing.Size(45, 18);
            this.lblClaveCaptura.TabIndex = 53;
            this.lblClaveCaptura.Text = "Clave";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(475, 106);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(175, 26);
            this.cmbCategorias.TabIndex = 58;
            this.cmbCategorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategorias_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoria.Location = new System.Drawing.Point(397, 111);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 59;
            this.lblCategoria.Text = "Categoría";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AltaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(687, 326);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.lblTituloCapturar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecioCaptura);
            this.Controls.Add(this.txtDescCaptura);
            this.Controls.Add(this.txtClaveCaptura);
            this.Controls.Add(this.lblPrecioCaptura);
            this.Controls.Add(this.lblDescCaptura);
            this.Controls.Add(this.lblClaveCaptura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaArticulos";
            this.Text = "Alta de Articulos";
            this.Load += new System.EventHandler(this.AltaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCapturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecioCaptura;
        private System.Windows.Forms.TextBox txtDescCaptura;
        private System.Windows.Forms.TextBox txtClaveCaptura;
        private System.Windows.Forms.Label lblPrecioCaptura;
        private System.Windows.Forms.Label lblDescCaptura;
        private System.Windows.Forms.Label lblClaveCaptura;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}