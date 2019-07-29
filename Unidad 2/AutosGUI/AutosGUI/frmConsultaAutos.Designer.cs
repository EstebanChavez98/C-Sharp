namespace AutosGUI
{
    partial class frmConsultaAutos
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
            this.dgvConsultaAuto = new System.Windows.Forms.DataGridView();
            this.nomAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaAuto
            // 
            this.dgvConsultaAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomAuto,
            this.clave,
            this.Manejo,
            this.NumSerie,
            this.maxPasajeros});
            this.dgvConsultaAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultaAuto.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaAuto.Name = "dgvConsultaAuto";
            this.dgvConsultaAuto.RowTemplate.Height = 24;
            this.dgvConsultaAuto.Size = new System.Drawing.Size(585, 253);
            this.dgvConsultaAuto.TabIndex = 0;
            this.dgvConsultaAuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomAuto
            // 
            this.nomAuto.HeaderText = "Auto";
            this.nomAuto.Name = "nomAuto";
            // 
            // clave
            // 
            this.clave.HeaderText = "Marca";
            this.clave.Name = "clave";
            // 
            // Manejo
            // 
            this.Manejo.HeaderText = "Tipo de Manejo";
            this.Manejo.Name = "Manejo";
            // 
            // NumSerie
            // 
            this.NumSerie.HeaderText = "Numero de serie";
            this.NumSerie.Name = "NumSerie";
            // 
            // maxPasajeros
            // 
            this.maxPasajeros.HeaderText = "Numero de pasajeros";
            this.maxPasajeros.Name = "maxPasajeros";
            // 
            // frmConsultaAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 253);
            this.Controls.Add(this.dgvConsultaAuto);
            this.Name = "frmConsultaAutos";
            this.Text = "frmConsultaAutos";
            this.Load += new System.EventHandler(this.frmConsultaAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPasajeros;
    }
}