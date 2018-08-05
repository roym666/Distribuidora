namespace Distribuidora
{
    partial class ReporteSaldoPorRuta
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
            this.SaldoPorRutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribuidoraDataSet = new Distribuidora.distribuidoraDataSet();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SaldoPorRutaTableAdapter = new Distribuidora.distribuidoraDataSetTableAdapters.SaldoPorRutaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoPorRutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SaldoPorRutaBindingSource
            // 
            this.SaldoPorRutaBindingSource.DataMember = "SaldoPorRuta";
            this.SaldoPorRutaBindingSource.DataSource = this.distribuidoraDataSet;
            // 
            // distribuidoraDataSet
            // 
            this.distribuidoraDataSet.DataSetName = "distribuidoraDataSet";
            this.distribuidoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(2, 7);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaldoPorRutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Distribuidora.Reportes.SaldoPorRuta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 433);
            this.reportViewer1.TabIndex = 3;
            // 
            // SaldoPorRutaTableAdapter
            // 
            this.SaldoPorRutaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteSaldoPorRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 496);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "ReporteSaldoPorRuta";
            this.Text = "Reporte Saldo por Ruta";
            this.Load += new System.EventHandler(this.ReporteSaldoPorRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaldoPorRutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaldoPorRutaBindingSource;
        private distribuidoraDataSet distribuidoraDataSet;
        private distribuidoraDataSetTableAdapters.SaldoPorRutaTableAdapter SaldoPorRutaTableAdapter;
    }
}