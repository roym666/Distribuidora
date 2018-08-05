using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Distribuidora
{
    public partial class Tarjeta : Form
    {
        Modelo.distribuidoraEntities contexto = new Modelo.distribuidoraEntities();
        public string IDTarjeta { get; set; }
        public bool Guardo { get; set; }
        public string Agente { get; set; }

        public Tarjeta(short idRuta, DateTime fecha, string agente)
        {
            InitializeComponent();
            this.CargarRutas();
            this.cmbRuta.SelectedValue = idRuta;
            this.dtpFechaCreacion.Value = fecha;
            this.txtAgente.Text = agente;
        }

        private void CargarRutas()
        {
            this.cmbRuta.DataSource = contexto.ruta.OrderBy(r => r.idRuta).ToList();
            this.cmbRuta.DisplayMember = "Descripcion";
            this.cmbRuta.ValueMember = "idRuta";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.btnGuardar.Enabled = false;

                if (Validar())
                {
                    Modelo.tarjeta tarjeta = new Modelo.tarjeta();
                    tarjeta.Apellido1 = this.txtApellido1.Text.Trim();
                    tarjeta.Apellido2 = this.txtApellido2.Text.Trim();
                    tarjeta.Direccion = this.txtDireccion.Text.Trim();
                    tarjeta.Estado = this.txtEstado.Text.Trim();
                    tarjeta.FechaCreacion = this.dtpFechaCreacion.Value;
                    tarjeta.FechaRegistro = DateTime.Now;
                    tarjeta.idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                    tarjeta.Nombre = this.txtNombre.Text;
                    tarjeta.Agente = this.txtAgente.Text;

                    using (Modelo.distribuidoraEntities context = new Modelo.distribuidoraEntities())
                    {
                        context.tarjeta.Add(tarjeta);
                        context.SaveChanges();
                        this.txtCodigo.Text = tarjeta.idTarjeta.ToString();
                        this.Guardo = true;
                        this.IDTarjeta = txtCodigo.Text;
                        this.Agente = txtAgente.Text;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(string.Format("La tarjeta se creó con el código: {0}", tarjeta.idTarjeta.ToString()), "Se registró con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                this.btnGuardar.Enabled = true;
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (cmbRuta.SelectedIndex == -1 || cmbRuta.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("La ruta es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtDireccion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La dirección es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (this.txtAgente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El agente es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genericKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl((Control)sender, true, false, false, true);
        }
    }
}
