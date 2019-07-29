namespace ControlEscolar
{
    partial class frmConsultaRegistroAct
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
            this.dgvRegistroAct = new System.Windows.Forms.DataGridView();
            this.IdActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroAct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroAct
            // 
            this.dgvRegistroAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdActividad,
            this.Actividad,
            this.NumControl,
            this.Al,
            this.ApP,
            this.ApM});
            this.dgvRegistroAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroAct.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroAct.Name = "dgvRegistroAct";
            this.dgvRegistroAct.RowTemplate.Height = 24;
            this.dgvRegistroAct.Size = new System.Drawing.Size(641, 253);
            this.dgvRegistroAct.TabIndex = 0;
            // 
            // IdActividad
            // 
            this.IdActividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdActividad.Frozen = true;
            this.IdActividad.HeaderText = "Clave de actividad";
            this.IdActividad.Name = "IdActividad";
            this.IdActividad.Width = 139;
            // 
            // Actividad
            // 
            this.Actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Actividad.Frozen = true;
            this.Actividad.HeaderText = "Actvidad";
            this.Actividad.Name = "Actividad";
            this.Actividad.Width = 91;
            // 
            // NumControl
            // 
            this.NumControl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumControl.Frozen = true;
            this.NumControl.HeaderText = "Numero de control";
            this.NumControl.Name = "NumControl";
            this.NumControl.Width = 102;
            // 
            // Al
            // 
            this.Al.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Al.Frozen = true;
            this.Al.HeaderText = "Nombre de alumno";
            this.Al.Name = "Al";
            this.Al.Width = 144;
            // 
            // ApP
            // 
            this.ApP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ApP.Frozen = true;
            this.ApP.HeaderText = "Apellido Paterno";
            this.ApP.Name = "ApP";
            this.ApP.Width = 129;
            // 
            // ApM
            // 
            this.ApM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ApM.Frozen = true;
            this.ApM.HeaderText = "Apelllido Materno";
            this.ApM.Name = "ApM";
            this.ApM.Width = 134;
            // 
            // frmConsultaRegistroAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 253);
            this.Controls.Add(this.dgvRegistroAct);
            this.Name = "frmConsultaRegistroAct";
            this.Text = "Registros de actividades";
            this.Load += new System.EventHandler(this.ConsultaRegistroAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroAct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApM;
    }
}