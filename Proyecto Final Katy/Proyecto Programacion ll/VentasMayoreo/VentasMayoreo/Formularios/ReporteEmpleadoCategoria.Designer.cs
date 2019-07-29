namespace VentasMayoreo.Formularios
{
    partial class ReporteEmpleadoCategoria
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleadoCategoria));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasMayoreo = new VentasMayoreo.DataSets.VentasMayoreo();
            this.empleadosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleados_CategoriasTableAdapter = new VentasMayoreo.DataSets.VentasMayoreoTableAdapters.Empleados_CategoriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.empleadosCategoriasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VentasMayoreo.Reportes.EmpleadosCategorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(937, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasMayoreo
            // 
            this.ventasMayoreo.DataSetName = "VentasMayoreo";
            this.ventasMayoreo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosCategoriasBindingSource
            // 
            this.empleadosCategoriasBindingSource.DataMember = "Empleados Categorias";
            this.empleadosCategoriasBindingSource.DataSource = this.ventasMayoreo;
            // 
            // empleados_CategoriasTableAdapter
            // 
            this.empleados_CategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 373);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteEmpleadoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Empleados por Categoria";
            this.Load += new System.EventHandler(this.ReporteEmpleadoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.VentasMayoreo ventasMayoreo;
        private System.Windows.Forms.BindingSource empleadosCategoriasBindingSource;
        private DataSets.VentasMayoreoTableAdapters.Empleados_CategoriasTableAdapter empleados_CategoriasTableAdapter;
    }
}