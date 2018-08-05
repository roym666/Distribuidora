namespace Distribuidora
{
    partial class PantallaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoAnterior = new System.Windows.Forms.TextBox();
            this.lblCodigoAnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarAbono = new System.Windows.Forms.Button();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarMovimiento = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarTarjeta = new System.Windows.Forms.Button();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.idTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.lblAgente = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtCodigoAnterior);
            this.panel1.Controls.Add(this.lblCodigoAnt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminarAbono);
            this.panel1.Controls.Add(this.lblFechaCreacion);
            this.panel1.Controls.Add(this.dtpFechaCreacion);
            this.panel1.Controls.Add(this.btnAgregarMovimiento);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregarTarjeta);
            this.panel1.Controls.Add(this.lblMovimientos);
            this.panel1.Controls.Add(this.dgvMovimientos);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.txtAbono);
            this.panel1.Controls.Add(this.lblAbono);
            this.panel1.Controls.Add(this.txtAgente);
            this.panel1.Controls.Add(this.lblAgente);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.cmbRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 535);
            this.panel1.TabIndex = 0;
            // 
            // txtCodigoAnterior
            // 
            this.txtCodigoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAnterior.Location = new System.Drawing.Point(494, 3);
            this.txtCodigoAnterior.MaxLength = 6;
            this.txtCodigoAnterior.Name = "txtCodigoAnterior";
            this.txtCodigoAnterior.Size = new System.Drawing.Size(121, 26);
            this.txtCodigoAnterior.TabIndex = 29;
            this.txtCodigoAnterior.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoAnterior_KeyDown);
            this.txtCodigoAnterior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoAnterior_KeyPress);
            // 
            // lblCodigoAnt
            // 
            this.lblCodigoAnt.AutoSize = true;
            this.lblCodigoAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAnt.Location = new System.Drawing.Point(372, 6);
            this.lblCodigoAnt.Name = "lblCodigoAnt";
            this.lblCodigoAnt.Size = new System.Drawing.Size(123, 20);
            this.lblCodigoAnt.TabIndex = 30;
            this.lblCodigoAnt.Text = "Código Anterior:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "1=abono,2=venta,3=descuento,4=dato importado,5=devolución,6=ajuste";
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAbono.Location = new System.Drawing.Point(390, 490);
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.Size = new System.Drawing.Size(172, 35);
            this.btnEliminarAbono.TabIndex = 27;
            this.btnEliminarAbono.Text = "Eliminar Movimiento";
            this.btnEliminarAbono.UseVisualStyleBackColor = true;
            this.btnEliminarAbono.Click += new System.EventHandler(this.btnEliminarAbono_Click);
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(386, 31);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(125, 20);
            this.lblFechaCreacion.TabIndex = 26;
            this.lblFechaCreacion.Text = "Fecha Creación:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Enabled = false;
            this.dtpFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCreacion.Location = new System.Drawing.Point(429, 54);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(273, 26);
            this.dtpFechaCreacion.TabIndex = 25;
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(568, 219);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(180, 35);
            this.btnAgregarMovimiento.TabIndex = 23;
            this.btnAgregarMovimiento.Text = "Agregar Movimiento";
            this.btnAgregarMovimiento.UseVisualStyleBackColor = true;
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(204, 490);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 35);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar Tarjeta";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(18, 490);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(180, 35);
            this.btnAgregarTarjeta.TabIndex = 7;
            this.btnAgregarTarjeta.Text = "Agregar Tarjeta";
            this.btnAgregarTarjeta.UseVisualStyleBackColor = true;
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.Location = new System.Drawing.Point(15, 260);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(101, 20);
            this.lblMovimientos.TabIndex = 22;
            this.lblMovimientos.Text = "Movimientos:";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoMovimiento,
            this.idTarjeta,
            this.Fecha,
            this.FechaAbono,
            this.Agente,
            this.Descripción,
            this.Monto,
            this.Saldo,
            this.TipoMovimiento});
            this.dgvMovimientos.Location = new System.Drawing.Point(18, 283);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.Size = new System.Drawing.Size(730, 198);
            this.dgvMovimientos.TabIndex = 14;
            // 
            // idTipoMovimiento
            // 
            this.idTipoMovimiento.DataPropertyName = "idTipoMovimiento";
            this.idTipoMovimiento.HeaderText = "TipoMovimiento";
            this.idTipoMovimiento.Name = "idTipoMovimiento";
            this.idTipoMovimiento.ReadOnly = true;
            this.idTipoMovimiento.Visible = false;
            // 
            // idTarjeta
            // 
            this.idTarjeta.DataPropertyName = "idTarjeta";
            this.idTarjeta.HeaderText = "id Tarjeta";
            this.idTarjeta.Name = "idTarjeta";
            this.idTarjeta.ReadOnly = true;
            this.idTarjeta.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // FechaAbono
            // 
            this.FechaAbono.DataPropertyName = "FechaAbono";
            this.FechaAbono.HeaderText = "Fecha del Abono";
            this.FechaAbono.Name = "FechaAbono";
            this.FechaAbono.ReadOnly = true;
            this.FechaAbono.Width = 130;
            // 
            // Agente
            // 
            this.Agente.DataPropertyName = "Agente";
            this.Agente.HeaderText = "Agente";
            this.Agente.Name = "Agente";
            this.Agente.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.DataPropertyName = "idTipoMovimiento";
            this.TipoMovimiento.HeaderText = "Tipo Movimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.ReadOnly = true;
            this.TipoMovimiento.Width = 130;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(86, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 26);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(476, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(485, 187);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(111, 26);
            this.txtSaldo.TabIndex = 13;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(425, 190);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(308, 187);
            this.txtAbono.MaxLength = 7;
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(111, 26);
            this.txtAbono.TabIndex = 3;
            this.txtAbono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAbono_KeyDown);
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.Location = new System.Drawing.Point(168, 190);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(134, 20);
            this.lblAbono.TabIndex = 14;
            this.lblAbono.Text = "Monto del Abono:";
            // 
            // txtAgente
            // 
            this.txtAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgente.Location = new System.Drawing.Point(86, 187);
            this.txtAgente.MaxLength = 4;
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.Size = new System.Drawing.Size(76, 26);
            this.txtAgente.TabIndex = 2;
            this.txtAgente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgente_KeyDown);
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.Location = new System.Drawing.Point(15, 190);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(65, 20);
            this.lblAgente.TabIndex = 12;
            this.lblAgente.Text = "Agente:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(86, 155);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(509, 26);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(1, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 20);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(472, 123);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(187, 26);
            this.txtApellido2.TabIndex = 12;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(279, 123);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(187, 26);
            this.txtApellido1.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(86, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(187, 26);
            this.txtNombre.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(18, 126);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(86, 91);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(17, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(292, 91);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 26);
            this.txtEstado.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(222, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(32, 60);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 20);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta:";
            // 
            // cmbRuta
            // 
            this.cmbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(86, 57);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(285, 28);
            this.cmbRuta.TabIndex = 6;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PantallaPrincipal";
            this.Text = "Abonos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtAgente;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Button btnAgregarTarjeta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarMovimiento;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Button btnEliminarAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoAnterior;
        private System.Windows.Forms.Label lblCodigoAnt;
    }
}