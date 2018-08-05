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
    public partial class Principal : Form
    {
        PantallaPrincipal pantallaPrincipal;
        ConsultaSinAbono consultaSinAbono;
        ConsultaTarjetasPorRuta tarjetasPorRuta;
        ReporteSaldoPorRuta saldoPorRuta;
        Ruta ruta;
        ConsultaCobroPorDia cobroPorDia;
        public Principal()
        {
            InitializeComponent();
            pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.MdiParent = this;
            pantallaPrincipal.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pantallaPrincipal.Visible)
            {
                pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.MdiParent = this;
                pantallaPrincipal.Show();
            }
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (consultaSinAbono == null || !consultaSinAbono.Visible)
            {
                consultaSinAbono = new ConsultaSinAbono();
                consultaSinAbono.MdiParent = this;
                consultaSinAbono.Show();
            }
        }

        private void tarjetasPorRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tarjetasPorRuta == null || !tarjetasPorRuta.Visible)
            {
                tarjetasPorRuta = new ConsultaTarjetasPorRuta();
                tarjetasPorRuta.MdiParent = this;
                tarjetasPorRuta.Show();
            }

        }

        private void saldoPorRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saldoPorRuta == null || !saldoPorRuta.Visible)
            {
                saldoPorRuta = new ReporteSaldoPorRuta();
                saldoPorRuta.MdiParent = this;
                saldoPorRuta.Show();
            }
        }

        private void importarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarExcel importar = new ImportarExcel();
            importar.MdiParent = this;
            importar.Show();
        }

        private void cargarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarExcel cargar = new CargarExcel();
            cargar.MdiParent = this;
            cargar.Show();
        }

        private void agregarRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta == null || !ruta.Visible)
            {
                ruta = new Ruta();
                ruta.FormClosed += (s, e1) =>
                {
                    if (pantallaPrincipal != null)
                        pantallaPrincipal.CargarRutas();
                };
                ruta.MdiParent = this.MdiParent;
                ruta.Show();
                ruta.WindowState = FormWindowState.Normal;
            }
        }

        private void totalDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cobroPorDia == null || !cobroPorDia.Visible)
            {
                cobroPorDia = new ConsultaCobroPorDia();
                cobroPorDia.MdiParent = this;
                cobroPorDia.Show();
            }
        }
    }
}
