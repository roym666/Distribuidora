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
    public partial class ConsultaTarjetasPorRuta : Form
    {
        public ConsultaTarjetasPorRuta()
        {
            try
            {
                InitializeComponent();
                this.CargarRutas();
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

                    var tarjetas = contextoGlobal.tarjeta.Where(t => t.idRuta == idRuta);

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
