using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Distribuidora
{
    public partial class ImportarExcel : Form
    {
        public ImportarExcel()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            string excelConexionString = string.Empty;
            excelConexionString = string.Format(ConfigurationManager.ConnectionStrings["xls"].ToString(), ConfigurationManager.AppSettings["OrigenArchivosCarga"] + txtRuta.Text.Trim());
            //excelConexionString = string.Format(ConfigurationManager.ConnectionStrings["xls"].ToString(), "C:\\Users\\rblanco\\Desktop\\RutasImportar\\juanvinas1.xls");

            // Create the connection object
            OleDbConnection oledbConn = new OleDbConnection(excelConexionString);
            // Open connection
            oledbConn.Open();
            // Get the data table containg the schema guid.
            DataTable dtHojas = oledbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            OleDbCommand cmd = new OleDbCommand(string.Format("SELECT {1} FROM [{0}] where [{2}] <>''", ConfigurationManager.AppSettings["HojaParaImportar"], ConfigurationManager.AppSettings["ColumnasParaImportar"], ConfigurationManager.AppSettings["ColumnaNombre"]), oledbConn);

            // Create new OleDbDataAdapter
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            oleda.SelectCommand = cmd;
            // Create a DataSet which will hold the data extracted from the worksheet.
            DataSet ds = new DataSet();
            // Fill the DataSet from the data extracted from the worksheet.
            oleda.Fill(ds, "Excel");
            oledbConn.Close();
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Update();

        }
    }
}
