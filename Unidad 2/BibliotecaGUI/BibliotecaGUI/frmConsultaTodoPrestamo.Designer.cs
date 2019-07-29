namespace BibliotecaGUI
{
    partial class frmConsultaTodoPrestamo
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
            this.dgvConsultaTodo = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaTodo
            // 
            this.dgvConsultaTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.NUsuario,
            this.Domicilio,
            this.Isbn,
            this.FechaDevolucion});
            this.dgvConsultaTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaTodo.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaTodo.Name = "dgvConsultaTodo";
            this.dgvConsultaTodo.RowTemplate.Height = 24;
            this.dgvConsultaTodo.Size = new System.Drawing.Size(689, 287);
            this.dgvConsultaTodo.TabIndex = 0;
            this.dgvConsultaTodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo de prestamo";
            this.Codigo.Name = "Codigo";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // NUsuario
            // 
            this.NUsuario.HeaderText = "Nombre de Usuario";
            this.NUsuario.Name = "NUsuario";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Isbn
            // 
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.Name = "Isbn";
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.HeaderText = "Fecha de Devolucion";
            this.FechaDevolucion.Name = "FechaDevolucion";
            // 
            // frmConsultaTodoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 287);
            this.Controls.Add(this.dgvConsultaTodo);
            this.Name = "frmConsultaTodoPrestamo";
            this.Text = "Consulta de todos los prestamos";
            this.Load += new System.EventHandler(this.frmConsultaTodoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
    }
}