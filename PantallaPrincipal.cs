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
    public partial class PantallaPrincipal : Form
    {

        Tarjeta tarjeta;
        Movimiento movimiento;
        ModificarTarjeta modificarTarjeta;

        public PantallaPrincipal()
        {
            try
            {
                InitializeComponent();
                this.dgvMovimientos.AutoGenerateColumns = false;
                this.CargarRutas();
                MessageBox.Show("Recuerde indicar la ruta y la fecha adecuada del rollo a trabajar", "Recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarRutas()
        {
            using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
            {
                this.cmbRuta.DataSource = contextoGlobal.ruta.OrderBy(r => r.idRuta).ToList();
                this.cmbRuta.DisplayMember = "Descripcion";
                this.cmbRuta.ValueMember = "idRuta";
            }
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            if (tarjeta == null || !tarjeta.Visible)
            {
                tarjeta = new Tarjeta(short.Parse(this.cmbRuta.SelectedValue.ToString()), dtpFecha.Value, this.txtAgente.Text.Trim());
                tarjeta.FormClosed += (s, e1) =>
                {
                    if (tarjeta.Guardo)
                    {
                        this.txtCodigo.Text = tarjeta.IDTarjeta;
                        this.txtAgente.Text = tarjeta.Agente;
                        this.BuscarTarjeta();
                    }
                };

                tarjeta.MdiParent = this.MdiParent;
                tarjeta.Show();
                tarjeta.WindowState = FormWindowState.Normal;
            }
        }

        private void LimpiarCampos()
        {
            this.dtpFechaCreacion.Value = DateTime.Now;
            this.txtEstado.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido1.Text = string.Empty;
            this.txtApellido2.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtAbono.Text = string.Empty;
            this.txtSaldo.Text = string.Empty;

            this.dgvMovimientos.DataSource = null;
            this.dgvMovimientos.Update();

        }

        private void BuscarTarjeta()
        {
            this.txtCodigoAnterior.Text = string.Empty;
            this.LimpiarCampos();
            Cursor.Current = Cursors.WaitCursor;
            if (txtCodigo.Text.Trim() != string.Empty)
            {
                try
                {
                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        int idTarjeta = int.Parse(txtCodigo.Text.Trim());
                        int idRuta = int.Parse(this.cmbRuta.SelectedValue.ToString());
                        Modelo.tarjeta tarjeta = contextoGlobal.tarjeta.Include("movimiento").Include("movimiento.tipomovimiento").FirstOrDefault(t => t.idTarjeta == idTarjeta && t.idRuta == (idRuta == 0 ? t.idRuta : idRuta));

                        if (tarjeta != null)
                        {
                            this.cmbRuta.SelectedValue = tarjeta.idRuta;
                            this.txtCodigoAnterior.Text = tarjeta.CodigoTemporal;
                            this.dtpFechaCreacion.Value = tarjeta.FechaCreacion;
                            this.txtEstado.Text = tarjeta.Estado;
                            this.txtNombre.Text = tarjeta.Nombre;
                            this.txtApellido1.Text = tarjeta.Apellido1;
                            this.txtApellido2.Text = tarjeta.Apellido2;
                            this.txtDireccion.Text = tarjeta.Direccion;
                            this.txtSaldo.Text = tarjeta.Saldo.ToString();

                            this.dgvMovimientos.DataSource = (from m in tarjeta.movimiento.OrderByDescending(p => p.Fecha) select new { idTipoMovimiento = m.idTipoMovimiento, idTarjeta = m.idTarjeta, Fecha = m.Fecha, FechaAbono = m.FechaAbono, Agente = m.Agente, Descripcion = m.Descripcion, Monto = m.Monto, Saldo = m.Saldo, TipoMovimiento = m.tipomovimiento.Descripcion }).ToList();
                            this.dgvMovimientos.Update();
                            this.txtAgente.Focus();
                            this.txtAgente.SelectAll();
                            this.btnGuardar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No existe la tarjeta con el código indicado, verifique que la ruta sea la correcta", "Tarjeta no existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarTarjeta();
            }
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnGuardar.Enabled = false;
            try
            {
                if (ValidarAbono())
                {
                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        int idTarjeta = int.Parse(this.txtCodigo.Text.Trim());
                        Modelo.tarjeta tarjetaMov = contextoGlobal.tarjeta.Include("movimiento").Include("movimiento.tipomovimiento").First(t => t.idTarjeta == idTarjeta);
                        Modelo.movimiento mov = new Modelo.movimiento()
                        {
                            Agente = this.txtAgente.Text.Trim(),
                            Descripcion = "Abono normal",
                            FechaAbono = this.dtpFecha.Value,
                            idTipoMovimiento = 1,//abono =1
                            Monto = decimal.Parse(this.txtAbono.Text.Trim()),
                            Fecha = DateTime.Now
                        };
                        tarjetaMov.Saldo = tarjetaMov.Saldo - mov.Monto;//el abono siempre resta al saldo
                        mov.Saldo = tarjetaMov.Saldo;
                        tarjetaMov.movimiento.Add(mov);

                        contextoGlobal.SaveChanges();
                        Cursor.Current = Cursors.Default;
                        this.dgvMovimientos.DataSource = tarjetaMov.movimiento.OrderByDescending(p => p.Fecha).ToList();

                        this.dgvMovimientos.Update();
                        this.txtSaldo.Text = tarjetaMov.Saldo.ToString();
                        this.txtCodigo.Focus();
                        this.txtCodigo.SelectAll();
                    }

                }
                else
                    this.btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarAbono()
        {
            if (cmbRuta.SelectedIndex == -1 || cmbRuta.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("La ruta es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtAgente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El agente es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.txtAbono.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El abono es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            if (this.dgvMovimientos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el abono?", "Eliminar abono", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int x = this.dgvMovimientos.SelectedCells[0].RowIndex;
                    Int16 idTipoMovimiento = Int16.Parse(dgvMovimientos.Rows[x].Cells[0].Value.ToString());
                    int idTarjeta = Int32.Parse(dgvMovimientos.Rows[x].Cells[1].Value.ToString());
                    DateTime fecha = DateTime.Parse(dgvMovimientos.Rows[x].Cells[2].Value.ToString());

                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        Modelo.tarjeta tarjetaMov = contextoGlobal.tarjeta.Include("movimiento").Include("movimiento.tipomovimiento").First(t => t.idTarjeta == idTarjeta);
                        Modelo.movimiento movEliminado = tarjetaMov.movimiento.First(m => m.idTipoMovimiento == idTipoMovimiento && m.idTarjeta == idTarjeta && m.Fecha == fecha);
                        tarjetaMov.movimiento.Remove(movEliminado);
                        tarjetaMov.Saldo = movEliminado.tipomovimiento.Naturaleza ? tarjetaMov.Saldo - movEliminado.Monto : tarjetaMov.Saldo + movEliminado.Monto;
                        this.txtSaldo.Text = tarjetaMov.Saldo.ToString();
                        this.dgvMovimientos.DataSource = tarjetaMov.movimiento.OrderByDescending(p => p.Fecha).ToList();
                        this.dgvMovimientos.Update();
                        contextoGlobal.SaveChanges();
                    }
                }
            }
            else
                MessageBox.Show("Debe seleccionar un movimiento");
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (movimiento == null || !movimiento.Visible)
                {
                    int idTarjeta = int.Parse(this.txtCodigo.Text.Trim());
                    short idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                    movimiento = new Movimiento(idTarjeta, this.dtpFecha.Value, idRuta, this.txtAgente.Text.Trim());
                    movimiento.FormClosed += (s, e1) =>
                    {
                        if (movimiento.Guardo)
                        {
                            this.BuscarTarjeta();
                        }
                    };
                    movimiento.MdiParent = this.MdiParent;
                    movimiento.Show();
                    movimiento.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
                MessageBox.Show("Verifique que la tarjeta exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificarTarjeta == null || !modificarTarjeta.Visible)
                {
                    int idTarjeta = int.Parse(this.txtCodigo.Text.Trim());
                    short idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                    modificarTarjeta = new ModificarTarjeta(idTarjeta, idRuta);
                    modificarTarjeta.FormClosed += (s, e1) =>
                    {
                        if (modificarTarjeta.Guardo)
                        {
                            this.BuscarTarjeta();
                        }
                    };
                    modificarTarjeta.MdiParent = this.MdiParent;
                    modificarTarjeta.Show();
                    modificarTarjeta.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
                MessageBox.Show("Verifique que la tarjeta exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAgente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtAbono.Focus();
            }
        }

        private void txtAbono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtCodigoAnterior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarTarjetaPorCodigoAnterior();
            }
        }

        private void txtCodigoAnterior_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BuscarTarjetaPorCodigoAnterior()
        {
            this.txtCodigo.Text = string.Empty;
            this.LimpiarCampos();
            Cursor.Current = Cursors.WaitCursor;
            if (txtCodigoAnterior.Text.Trim() != string.Empty)
            {
                try
                {
                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        string codAnterior = txtCodigoAnterior.Text.Trim();
                        int idRuta = int.Parse(this.cmbRuta.SelectedValue.ToString());
                        Modelo.tarjeta tarjeta = contextoGlobal.tarjeta.Include("movimiento").Include("movimiento.tipomovimiento").FirstOrDefault(t => t.CodigoTemporal.Trim() == codAnterior && t.idRuta == idRuta);

                        if (tarjeta != null)
                        {
                            this.txtCodigo.Text = tarjeta.idTarjeta.ToString();
                            this.dtpFechaCreacion.Value = tarjeta.FechaCreacion;
                            this.txtEstado.Text = tarjeta.Estado;
                            this.txtNombre.Text = tarjeta.Nombre;
                            this.txtApellido1.Text = tarjeta.Apellido1;
                            this.txtApellido2.Text = tarjeta.Apellido2;
                            this.txtDireccion.Text = tarjeta.Direccion;
                            this.txtSaldo.Text = tarjeta.Saldo.ToString();

                            this.dgvMovimientos.DataSource = (from m in tarjeta.movimiento.OrderByDescending(p => p.Fecha) select new { idTipoMovimiento = m.idTipoMovimiento, idTarjeta = m.idTarjeta, Fecha = m.Fecha, FechaAbono = m.FechaAbono, Agente = m.Agente, Descripcion = m.Descripcion, Monto = m.Monto, Saldo = m.Saldo, TipoMovimiento = m.tipomovimiento.Descripcion }).ToList();
                            this.dgvMovimientos.Update();
                            this.txtAgente.Focus();
                            this.txtAgente.SelectAll();
                            this.btnGuardar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No existe la tarjeta con el código indicado, verifique que la ruta sea la correcta", "Tarjeta no existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
