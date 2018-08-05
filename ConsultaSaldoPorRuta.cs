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
    public partial class ConsultaSaldoPorRuta : Form
    {
        public ConsultaSaldoPorRuta()
        {
            InitializeComponent();
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
                    var tarjetas = from m in contextoGlobal.tarjeta
                                   join r in contextoGlobal.ruta on m.idRuta equals r.idRuta
                                   where m.Estado == "A"
                                   select new  { idRuta = m.idRuta, Saldo = m.Saldo, Ruta = r.Descripcion };

                    var total = from t in tarjetas
                                group t by t.Ruta 
                                    into grupo
                                    select new  { Ruta = grupo.Key, Saldo = grupo.Sum(s=>s.Saldo) };

                    this.lblTotal.Text = total.Sum(p => p.Saldo).ToString();

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

    public class SaldoPorRuta
    {
        public decimal Saldo { get; set; }
        public string Ruta { get; set; }

    }
}
