namespace VentasMayoreo.Formularios
{
    partial class ReporteClienteAbono
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
            this.clientes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasMayoreoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasMayoreo = new VentasMayoreo.DataSets.VentasMayoreo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientes1TableAdapter = new VentasMayoreo.DataSets.VentasMayoreoTableAdapters.Clientes1TableAdapter();
            this.clientes1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes1BindingSource
            // 
            this.clientes1BindingSource.DataMember = "Clientes1";
            this.clientes1BindingSource.DataSource = this.ventasMayoreoBindingSource;
            // 
            // ventasMayoreoBindingSource
            // 
            this.ventasMayoreoBindingSource.DataSource = this.ventasMayoreo;
            this.ventasMayoreoBindingSource.Position = 0;
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
            reportDataSource1.Value = this.clientes1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VentasMayoreo.Reportes.ClienteAbono.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(712, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientes1TableAdapter
            // 
            this.clientes1TableAdapter.ClearBeforeFill = true;
            // 
            // clientes1BindingSource1
            // 
            this.clientes1BindingSource1.DataMember = "Clientes1";
            this.clientes1BindingSource1.DataSource = this.ventasMayoreoBindingSource;
            // 
            // ReporteClienteAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteClienteAbono";
            this.Text = "ReporteClienteAbono";
            this.Load += new System.EventHandler(this.ReporteClienteAbono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventasMayoreoBindingSource;
        private DataSets.VentasMayoreo ventasMayoreo;
        private System.Windows.Forms.BindingSource clientes1BindingSource;
        private DataSets.VentasMayoreoTableAdapters.Clientes1TableAdapter clientes1TableAdapter;
        private System.Windows.Forms.BindingSource clientes1BindingSource1;
    }
}