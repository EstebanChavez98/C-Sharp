namespace VentanaEmpleados
{
    partial class ConsultaEmpleado
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
            this.dgvConsultaEmpleado = new System.Windows.Forms.DataGridView();
            this.ClaveEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idiomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaEmpleado
            // 
            this.dgvConsultaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveEmpleado,
            this.NombreEmp,
            this.Domicilio,
            this.DepEmp,
            this.Sexo,
            this.Idiomas});
            this.dgvConsultaEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaEmpleado.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaEmpleado.Name = "dgvConsultaEmpleado";
            this.dgvConsultaEmpleado.RowTemplate.Height = 24;
            this.dgvConsultaEmpleado.Size = new System.Drawing.Size(675, 374);
            this.dgvConsultaEmpleado.TabIndex = 0;
            this.dgvConsultaEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClaveEmpleado
            // 
            this.ClaveEmpleado.HeaderText = "Clave Empelado";
            this.ClaveEmpleado.Name = "ClaveEmpleado";
            // 
            // NombreEmp
            // 
            this.NombreEmp.HeaderText = "Nombre ";
            this.NombreEmp.Name = "NombreEmp";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // DepEmp
            // 
            this.DepEmp.HeaderText = "Departamento";
            this.DepEmp.Name = "DepEmp";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Idiomas
            // 
            this.Idiomas.HeaderText = "Idiomas que domina";
            this.Idiomas.Name = "Idiomas";
            // 
            // ConsultaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 374);
            this.Controls.Add(this.dgvConsultaEmpleado);
            this.Name = "ConsultaEmpleado";
            this.Text = "Consulta de Empleado";
            this.Load += new System.EventHandler(this.ConsultaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idiomas;
    }
}