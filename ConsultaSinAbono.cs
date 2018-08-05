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
    public partial class ConsultaSinAbono : Form
    {
        public ConsultaSinAbono()
        {
            try
            {
                InitializeComponent();
                this.CargarRutas();
                this.dtpFecha.Value = DateTime.Now;
                this.dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.lblTotal.Text = string.Empty;
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Update();

                using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                {

                    short idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString());
                    DateTime fecha = this.dtpFecha.Value;

                    var idTarjetas = (from m in contextoGlobal.movimiento
                                      join t in contextoGlobal.tarjeta
                                      on m.idTarjeta equals t.idTarjeta
                                      where
                                          (m.idTipoMovimiento == 1) && m.FechaAbono.Year == fecha.Year && m.FechaAbono.Month == fecha.Month && m.FechaAbono.Day == fecha.Day && t.idRuta == idRuta
                                      select m.idTarjeta).ToList();

                    var tarjetas = contextoGlobal.tarjeta.Where(t => (t.Estado == "A") && t.idRuta == idRuta && !idTarjetas.Contains(t.idTarjeta));

                    this.dataGridView1.DataSource = tarjetas.ToList();
                    this.lblTotal.Text = tarjetas.Count().ToString();
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

        private void CargarRutas()
        {
            using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
            {
                this.cmbRuta.DataSource = contextoGlobal.ruta.OrderBy(r => r.idRuta).ToList();
                this.cmbRuta.DisplayMember = "Descripcion";
                this.cmbRuta.ValueMember = "idRuta";
            }
        }
    }
}
