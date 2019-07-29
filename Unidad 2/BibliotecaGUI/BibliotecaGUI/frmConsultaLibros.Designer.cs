namespace BibliotecaGUI
{
    partial class frmConsultaLibros
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
            this.dgvConsultaLibros = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaLibros
            // 
            this.dgvConsultaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.NombreLibro,
            this.Autor,
            this.Editorial,
            this.Existencia,
            this.Uso});
            this.dgvConsultaLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaLibros.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaLibros.Name = "dgvConsultaLibros";
            this.dgvConsultaLibros.RowTemplate.Height = 24;
            this.dgvConsultaLibros.Size = new System.Drawing.Size(635, 274);
            this.dgvConsultaLibros.TabIndex = 0;
            this.dgvConsultaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "Nombre del libro";
            this.NombreLibro.Name = "NombreLibro";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor(es)";
            this.Autor.Name = "Autor";
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            // 
            // Uso
            // 
            this.Uso.HeaderText = "Uso";
            this.Uso.Name = "Uso";
            // 
            // frmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 274);
            this.Controls.Add(this.dgvConsultaLibros);
            this.Name = "frmConsultaLibros";
            this.Text = "Consulta de libros";
            this.Load += new System.EventHandler(this.frmConsultaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uso;
    }
}