namespace frmPrincipal
{
    partial class frmConsultaJuegos
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
            this.dgvConsultaJuegos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desarrollador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaJuegos
            // 
            this.dgvConsultaJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.desarrollador,
            this.Existencia});
            this.dgvConsultaJuegos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaJuegos.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaJuegos.Name = "dgvConsultaJuegos";
            this.dgvConsultaJuegos.RowTemplate.Height = 24;
            this.dgvConsultaJuegos.Size = new System.Drawing.Size(444, 253);
            this.dgvConsultaJuegos.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo del juego";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del juego";
            this.nombre.Name = "nombre";
            // 
            // desarrollador
            // 
            this.desarrollador.HeaderText = "Desarrollador";
            this.desarrollador.Name = "desarrollador";
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // frmConsultaJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 253);
            this.Controls.Add(this.dgvConsultaJuegos);
            this.Name = "frmConsultaJuegos";
            this.Text = "frmConsultaJuegos";
            this.Load += new System.EventHandler(this.frmConsultaJuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaJuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn desarrollador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
    }
}