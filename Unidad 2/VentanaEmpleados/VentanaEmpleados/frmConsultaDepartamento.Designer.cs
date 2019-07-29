namespace VentanaEmpleados
{
    partial class frmConsultaDepartamento
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
            this.dgvConsultaDep = new System.Windows.Forms.DataGridView();
            this.ClaveDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JefeDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaDep
            // 
            this.dgvConsultaDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveDepartamento,
            this.nombreDep,
            this.JefeDep});
            this.dgvConsultaDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaDep.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaDep.Name = "dgvConsultaDep";
            this.dgvConsultaDep.RowTemplate.Height = 24;
            this.dgvConsultaDep.Size = new System.Drawing.Size(583, 253);
            this.dgvConsultaDep.TabIndex = 0;
            this.dgvConsultaDep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClaveDepartamento
            // 
            this.ClaveDepartamento.HeaderText = "Clave de Departamento";
            this.ClaveDepartamento.Name = "ClaveDepartamento";
            // 
            // nombreDep
            // 
            this.nombreDep.HeaderText = "Departamento";
            this.nombreDep.Name = "nombreDep";
            // 
            // JefeDep
            // 
            this.JefeDep.HeaderText = "Jefe de departamento";
            this.JefeDep.Name = "JefeDep";
            // 
            // frmConsultaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 253);
            this.Controls.Add(this.dgvConsultaDep);
            this.Name = "frmConsultaDepartamento";
            this.Text = "Consulta de Departamentos";
            this.Load += new System.EventHandler(this.frmConsultaDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn JefeDep;
    }
}