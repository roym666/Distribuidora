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
    public partial class ConsultaCobroPorDia : Form
    {
        public ConsultaCobroPorDia()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = true;
            CargarRutas();
            this.dtpFecha.Value = DateTime.Now;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Update();

                using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                {
                    short idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                    DateTime fecha = this.dtpFecha.Value;

                    var movimientos = from m in contextoGlobal.movimiento
                                      join t in contextoGlobal.tarjeta on m.idTarjeta equals t.idTarjeta
                                      join tm in contextoGlobal.tipomovimiento on m.idTipoMovimiento equals tm.idTipoMovimiento
                                      where m.FechaAbono.Year == fecha.Year && m.FechaAbono.Month == fecha.Month && m.FechaAbono.Day == fecha.Day && t.idRuta == idRuta
                                      select new { idTipoMovimiento = m.idTipoMovimiento, Saldo = m.Monto, TipoMovimiento = tm.Descripcion };

                    var total = from t in movimientos
                                group t by t.TipoMovimiento
                                    into grupo
                                    select new { Ruta = grupo.Key, Saldo = grupo.Sum(s => s.Saldo) };


                    this.dataGridView1.DataSource = total.ToList();
                    this.dataGridView1.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
            }
        }

    }
}
