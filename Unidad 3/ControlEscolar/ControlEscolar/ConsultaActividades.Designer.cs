namespace ControlEscolar
{
    partial class frmConsultaAct
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
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Alumnos,
            this.Tutor,
            this.creditos});
            this.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActividades.Location = new System.Drawing.Point(0, 0);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(595, 285);
            this.dgvActividades.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clave.Frozen = true;
            this.Clave.HeaderText = "Clave de actividad";
            this.Clave.Name = "Clave";
            this.Clave.Width = 139;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre de actividad";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 153;
            // 
            // Alumnos
            // 
            this.Alumnos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Alumnos.Frozen = true;
            this.Alumnos.HeaderText = "Alumnos registrados";
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Width = 152;
            // 
            // Tutor
            // 
            this.Tutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tutor.Frozen = true;
            this.Tutor.HeaderText = "Tutor";
            this.Tutor.Name = "Tutor";
            this.Tutor.Width = 71;
            // 
            // creditos
            // 
            this.creditos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditos.Frozen = true;
            this.creditos.HeaderText = "Creditos";
            this.creditos.Name = "creditos";
            this.creditos.Width = 89;
            // 
            // frmConsultaAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 285);
            this.Controls.Add(this.dgvActividades);
            this.Name = "frmConsultaAct";
            this.Text = "Consulta de Actividades";
            this.Load += new System.EventHandler(this.ConsultaActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditos;
    }
}