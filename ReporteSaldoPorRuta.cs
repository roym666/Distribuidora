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
    public partial class ReporteSaldoPorRuta : Form
    {
        public ReporteSaldoPorRuta()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'distribuidoraDataSet.SaldoPorRuta' table. You can move, or remove it, as needed.
            this.SaldoPorRutaTableAdapter.Fill(this.distribuidoraDataSet.SaldoPorRuta,1);

            this.reportViewer1.RefreshReport();
        }

        private void ReporteSaldoPorRuta_Load(object sender, EventArgs e)
        {
        }
    }
}
