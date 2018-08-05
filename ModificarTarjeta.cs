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
    public partial class ModificarTarjeta : Form
    {
        private int _idTarjeta;
        private short _idRuta;
        public bool Guardo { get; set; }
        public ModificarTarjeta(int idTarjeta, short idRuta)
        {
            try
            {
                InitializeComponent();
                this.CargarRutas();
                this._idTarjeta = idTarjeta;
                this._idRuta = idRuta;
                this.CargarTarjeta();
                this.Guardo = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarRutas()
        {
            using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
            {
                this.cmbRuta.DataSource = contextoGlobal.ruta.OrderBy(r => r.idRuta).ToList();
                this.cmbRuta.DisplayMember = "Descripcion";
                this.cmbRuta.ValueMember = "idRuta";
            }
        }

        private void CargarTarjeta()
        {
            using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
            {
                var tarjeta = contextoGlobal.tarjeta.First(t => t.idTarjeta == _idTarjeta && t.idRuta == _idRuta);
                this.txtCodigo.Text = tarjeta.idTarjeta.ToString();
                this.dtpFechaCreacion.Value = tarjeta.FechaCreacion;
                this.cmbRuta.SelectedValue = tarjeta.idRuta;
                this.cmbEstado.SelectedItem = tarjeta.Estado;
                this.txtNombre.Text = tarjeta.Nombre;
                this.txtApellido1.Text = tarjeta.Apellido1;
                this.txtApellido2.Text = tarjeta.Apellido2;
                this.txtDireccion.Text = tarjeta.Direccion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Cursor.Current = Cursors.WaitCursor;
                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        var tarjeta = contextoGlobal.tarjeta.First(t => t.idTarjeta == _idTarjeta && t.idRuta == _idRuta);
                        tarjeta.FechaCreacion = dtpFechaCreacion.Value;
                        tarjeta.Apellido1 = this.txtApellido1.Text.Trim();
                        tarjeta.Apellido2 = this.txtApellido2.Text.Trim();
                        tarjeta.Direccion = this.txtDireccion.Text.Trim();
                        tarjeta.Estado = this.cmbEstado.SelectedItem.ToString();
                        tarjeta.idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                        tarjeta.Nombre = this.txtNombre.Text.Trim();
                        DateTime fechaModificacion = DateTime.Now;
                        tarjeta.UltimaModificacion = fechaModificacion.Millisecond == 0 ? fechaModificacion.AddMilliseconds(1) : fechaModificacion;
                        contextoGlobal.SaveChanges();
                        this.Guardo = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private bool Validar()
        {
            if (cmbRuta.SelectedIndex == -1 || cmbRuta.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("La ruta es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("El estado es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
