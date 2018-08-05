namespace Distribuidora
{
    partial class Movimiento
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSumaResta = new System.Windows.Forms.GroupBox();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.gbxSumaResta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(81, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(145, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 26);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericKeyDown);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(145, 116);
            this.txtMonto.MaxLength = 7;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(111, 26);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericKeyDown);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(81, 119);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(58, 20);
            this.lblMonto.TabIndex = 25;
            this.lblMonto.Text = "Monto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(145, 50);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(121, 26);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(76, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(145, 152);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(442, 26);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descripción:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(12, 85);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(127, 20);
            this.lblRuta.TabIndex = 29;
            this.lblRuta.Text = "Tipo Movimiento:";
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMovimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Location = new System.Drawing.Point(145, 82);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(285, 28);
            this.cmbMovimiento.TabIndex = 3;
            this.cmbMovimiento.SelectedIndexChanged += new System.EventHandler(this.cmbMovimiento_SelectedIndexChanged);
            this.cmbMovimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericKeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(180, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(272, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAgente
            // 
            this.txtAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgente.Location = new System.Drawing.Point(359, 50);
            this.txtAgente.MaxLength = 4;
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.Size = new System.Drawing.Size(121, 26);
            this.txtAgente.TabIndex = 2;
            this.txtAgente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Agente:";
            // 
            // gbxSumaResta
            // 
            this.gbxSumaResta.Controls.Add(this.rbRestar);
            this.gbxSumaResta.Controls.Add(this.rbSumar);
            this.gbxSumaResta.Location = new System.Drawing.Point(436, 82);
            this.gbxSumaResta.Name = "gbxSumaResta";
            this.gbxSumaResta.Size = new System.Drawing.Size(125, 66);
            this.gbxSumaResta.TabIndex = 35;
            this.gbxSumaResta.TabStop = false;
            this.gbxSumaResta.Text = "Sumar o restar";
            // 
            // rbRestar
            // 
            this.rbRestar.AutoSize = true;
            this.rbRestar.Location = new System.Drawing.Point(7, 39);
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.Size = new System.Drawing.Size(56, 17);
            this.rbRestar.TabIndex = 9;
            this.rbRestar.TabStop = true;
            this.rbRestar.Text = "Restar";
            this.rbRestar.UseVisualStyleBackColor = true;
            // 
            // rbSumar
            // 
            this.rbSumar.AutoSize = true;
            this.rbSumar.Location = new System.Drawing.Point(7, 20);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(55, 17);
            this.rbSumar.TabIndex = 8;
            this.rbSumar.TabStop = true;
            this.rbSumar.Text = "Sumar";
            this.rbSumar.UseVisualStyleBackColor = true;
            // 
            // Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.gbxSumaResta);
            this.Controls.Add(this.txtAgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cmbMovimiento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Movimiento";
            this.Text = "Agregar Movimiento";
            this.gbxSumaResta.ResumeLayout(false);
            this.gbxSumaResta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtAgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSumaResta;
        private System.Windows.Forms.RadioButton rbRestar;
        private System.Windows.Forms.RadioButton rbSumar;
    }
}