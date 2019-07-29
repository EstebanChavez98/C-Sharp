namespace VentasMayoreo.Formularios
{
    partial class ReporteClienteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteClienteVentas));
            this.Clientes_VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasMayoreo = new VentasMayoreo.DataSets.VentasMayoreo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes_VentasTableAdapter = new VentasMayoreo.DataSets.VentasMayoreoTableAdapters.Clientes_VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Clientes_VentasBindingSource
            // 
            this.Clientes_VentasBindingSource.DataMember = "Clientes Ventas";
            this.Clientes_VentasBindingSource.DataSource = this.ventasMayoreo;
            // 
            // ventasMayoreo
            // 
            this.ventasMayoreo.DataSetName = "VentasMayoreo";
            this.ventasMayoreo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Clientes_VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VentasMayoreo.Reportes.ClientesVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(605, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientesVentasBindingSource
            // 
            this.clientesVentasBindingSource.DataMember = "Clientes Ventas";
            this.clientesVentasBindingSource.DataSource = this.ventasMayoreo;
            // 
            // clientes_VentasTableAdapter
            // 
            this.clientes_VentasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteClienteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 261);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteClienteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clientes Venta";
            this.Load += new System.EventHandler(this.ReporteClienteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.VentasMayoreo ventasMayoreo;
        private System.Windows.Forms.BindingSource clientesVentasBindingSource;
        private DataSets.VentasMayoreoTableAdapters.Clientes_VentasTableAdapter clientes_VentasTableAdapter;
        private System.Windows.Forms.BindingSource Clientes_VentasBindingSource;
    }
}