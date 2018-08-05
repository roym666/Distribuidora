namespace Distribuidora
{
    partial class CargarExcel
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.CodigoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAnterior,
            this.CodigoSistema,
            this.Nombre,
            this.Apellido1,
            this.Saldo});
            this.dgvResultado.Location = new System.Drawing.Point(13, 13);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(644, 176);
            this.dgvResultado.TabIndex = 0;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(582, 226);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(14, 208);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 20);
            this.lblRuta.TabIndex = 7;
            this.lblRuta.Text = "Ruta:";
            // 
            // cmbRuta
            // 
            this.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(68, 205);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(285, 28);
            this.cmbRuta.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Archivo con la Extensión:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(188, 248);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(245, 20);
            this.txtRuta.TabIndex = 9;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(544, 269);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(113, 23);
            this.btnResultado.TabIndex = 11;
            this.btnResultado.Text = "Ver Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // CodigoAnterior
            // 
            this.CodigoAnterior.DataPropertyName = "CodigoTemporal";
            this.CodigoAnterior.HeaderText = "Código Anterior";
            this.CodigoAnterior.Name = "CodigoAnterior";
            this.CodigoAnterior.ReadOnly = true;
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.DataPropertyName = "idTarjeta";
            this.CodigoSistema.HeaderText = "Código Sistema";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido1
            // 
            this.Apellido1.DataPropertyName = "Apellido1";
            this.Apellido1.HeaderText = "Apellido1";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // CargarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 304);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvResultado);
            this.Name = "CargarExcel";
            this.Text = "Cargar Datos al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}