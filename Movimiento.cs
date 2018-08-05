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
    public partial class Movimiento : Form
    {

        private int _idTarjeta;
        private short _idRuta;
        public bool Guardo { get; set; }
        private List<Modelo.tipomovimiento> TiposMovimientos;

        public Movimiento(int idTarjeta, DateTime fecha, short idRuta, string agente)
        {
            try
            {
                InitializeComponent();
                this.Guardo = false;
                this._idTarjeta = idTarjeta;
                this._idRuta = idRuta;
                this.dtpFecha.Value = fecha;
                this.CargarTipoMovimiento();
                this.txtCodigo.Text = idTarjeta.ToString();
                this.txtAgente.Text = agente;
                MostrarRadios(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    short idTipoMovimiento = Int16.Parse(this.cmbMovimiento.SelectedValue.ToString());
                    decimal monto = decimal.Parse(this.txtMonto.Text.Trim());
                    using (Modelo.distribuidoraEntities contexto = new Modelo.distribuidoraEntities())
                    {
                        var tipoMovimiento = contexto.tipomovimiento.First(t => t.idTipoMovimiento == idTipoMovimiento);

                        Modelo.movimiento movimiento = new Modelo.movimiento()
                        {
                            Descripcion = this.txtDescripcion.Text.Trim(),
                            Fecha = DateTime.Now,
                            FechaAbono = this.dtpFecha.Value,
                            idTarjeta = this._idTarjeta,
                            idTipoMovimiento = idTipoMovimiento,
                            Monto = monto,
                            Agente = this.txtAgente.Text.Trim(),
                        };
                        var tarjeta = contexto.tarjeta.First(t => t.idTarjeta == _idTarjeta && t.idRuta == this._idRuta);

                        //si el tipo de movimiento es ajuste
                        if (tipoMovimiento.idTipoMovimiento == 6)
                        {
                            if (this.rbSumar.Checked)
                            {
                                tarjeta.Saldo = tarjeta.Saldo + monto;
                            }
                            else
                            {
                                tarjeta.Saldo = tarjeta.Saldo - monto;
                            }
                        }
                        else
                        {
                            tarjeta.Saldo = tipoMovimiento.Naturaleza ? tarjeta.Saldo + monto : tarjeta.Saldo - monto;
                        }
                        movimiento.Saldo = tarjeta.Saldo;
                        tarjeta.movimiento.Add(movimiento);
                        contexto.SaveChanges();
                        this.Guardo = true;
                        this.Close();
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTipoMovimiento()
        {
            using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
            {
                string[] filtros = System.Configuration.ConfigurationManager.AppSettings["FiltroTiposMovimiento"].Split(',');
                List<short> tiposMovimiento = new List<short>();
                foreach (string filtro in filtros)
                    tiposMovimiento.Add(short.Parse(filtro));

                var tipos = contextoGlobal.tipomovimiento.Where(t => tiposMovimiento.Contains(t.idTipoMovimiento));
                TiposMovimientos = tipos.ToList();
                this.cmbMovimiento.DataSource = TiposMovimientos;
                this.cmbMovimiento.DisplayMember = "Descripcion";
                this.cmbMovimiento.ValueMember = "idTipoMovimiento";
            }
        }

        private bool Validar()
        {
            if (this._idRuta == 0)
            {
                MessageBox.Show("La ruta es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtAgente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El agente es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.cmbMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("El tipo de movimiento es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtMonto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El monto es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtDescripcion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La descripción es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.gbxSumaResta.Visible)
            {
                if (this.rbSumar.Checked == false && this.rbRestar.Checked == false)
                {
                    MessageBox.Show("Debe indicar si quiere sumar o estar el monto para aplicar el ajuste", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (Char)Keys.Delete == e.KeyChar || (Char)Keys.Tab == e.KeyChar || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMovimiento.SelectedIndex >= 0)
            {
                //si es igual a ajuste de saldo
                if (this.cmbMovimiento.SelectedValue.ToString() == "6")
                {
                    this.MostrarRadios(true);
                }
                else
                {
                    this.MostrarRadios(false);
                }
            }
            else
            {
                MostrarRadios(false);
            }
        }

        private void MostrarRadios(bool valor)
        {
            this.gbxSumaResta.Visible = valor;
            this.rbRestar.Visible = valor;
            this.rbSumar.Visible = valor;
        }

        private void genericKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl((Control)sender,true,false,false,true);
        }

    }
}
