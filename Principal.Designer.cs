namespace Distribuidora
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasPorRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoPorRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarjetasToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.rutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.importarExcelToolStripMenuItem,
            this.cargarExcelToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.principalToolStripMenuItem.Text = "Abonos";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // importarExcelToolStripMenuItem
            // 
            this.importarExcelToolStripMenuItem.Name = "importarExcelToolStripMenuItem";
            this.importarExcelToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.importarExcelToolStripMenuItem.Text = "Leer Excel";
            this.importarExcelToolStripMenuItem.Click += new System.EventHandler(this.importarExcelToolStripMenuItem_Click);
            // 
            // cargarExcelToolStripMenuItem
            // 
            this.cargarExcelToolStripMenuItem.Name = "cargarExcelToolStripMenuItem";
            this.cargarExcelToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.cargarExcelToolStripMenuItem.Text = "Cargar Excel";
            this.cargarExcelToolStripMenuItem.Click += new System.EventHandler(this.cargarExcelToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diarioToolStripMenuItem,
            this.tarjetasPorRutaToolStripMenuItem,
            this.saldoPorRutaToolStripMenuItem,
            this.totalDeMovimientosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // diarioToolStripMenuItem
            // 
            this.diarioToolStripMenuItem.Name = "diarioToolStripMenuItem";
            this.diarioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.diarioToolStripMenuItem.Text = "Tarjetas sin Abono";
            this.diarioToolStripMenuItem.Click += new System.EventHandler(this.diarioToolStripMenuItem_Click);
            // 
            // tarjetasPorRutaToolStripMenuItem
            // 
            this.tarjetasPorRutaToolStripMenuItem.Name = "tarjetasPorRutaToolStripMenuItem";
            this.tarjetasPorRutaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tarjetasPorRutaToolStripMenuItem.Text = "Tarjetas por Ruta";
            this.tarjetasPorRutaToolStripMenuItem.Click += new System.EventHandler(this.tarjetasPorRutaToolStripMenuItem_Click);
            // 
            // saldoPorRutaToolStripMenuItem
            // 
            this.saldoPorRutaToolStripMenuItem.Name = "saldoPorRutaToolStripMenuItem";
            this.saldoPorRutaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saldoPorRutaToolStripMenuItem.Text = "Saldo por Ruta";
            this.saldoPorRutaToolStripMenuItem.Click += new System.EventHandler(this.saldoPorRutaToolStripMenuItem_Click);
            // 
            // totalDeMovimientosToolStripMenuItem
            // 
            this.totalDeMovimientosToolStripMenuItem.Name = "totalDeMovimientosToolStripMenuItem";
            this.totalDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.totalDeMovimientosToolStripMenuItem.Text = "Total de Movimientos";
            this.totalDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.totalDeMovimientosToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRutaToolStripMenuItem});
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.rutaToolStripMenuItem.Text = "Ruta";
            // 
            // agregarRutaToolStripMenuItem
            // 
            this.agregarRutaToolStripMenuItem.Name = "agregarRutaToolStripMenuItem";
            this.agregarRutaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.agregarRutaToolStripMenuItem.Text = "Agregar Ruta";
            this.agregarRutaToolStripMenuItem.Click += new System.EventHandler(this.agregarRutaToolStripMenuItem_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(575, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version1.0.6";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuidora Blanco - Sistema de Registro de Abonos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasPorRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoPorRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.Label lblVersion;
    }
}



