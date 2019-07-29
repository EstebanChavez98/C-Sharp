namespace ControlEscolar
{
    partial class frmConsultaCarreras
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
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.NombreCarrera,
            this.NumAl});
            this.dgvCarreras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarreras.Location = new System.Drawing.Point(0, 0);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.RowTemplate.Height = 24;
            this.dgvCarreras.Size = new System.Drawing.Size(995, 253);
            this.dgvCarreras.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clave.Frozen = true;
            this.Clave.HeaderText = "Clave de Carrera";
            this.Clave.Name = "Clave";
            this.Clave.Width = 132;
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NombreCarrera.Frozen = true;
            this.NombreCarrera.HeaderText = "Nombre de carrera";
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.Width = 144;
            // 
            // NumAl
            // 
            this.NumAl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumAl.Frozen = true;
            this.NumAl.HeaderText = "Numero de alumnos en la carrera";
            this.NumAl.Name = "NumAl";
            this.NumAl.Width = 168;
            // 
            // frmConsultaCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 253);
            this.Controls.Add(this.dgvCarreras);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCarreras";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Consulta de carreras";
            this.Load += new System.EventHandler(this.frmConsultaCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAl;
    }
}