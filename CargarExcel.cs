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
    public partial class CargarExcel : Form
    {
        public CargarExcel()
        {
            InitializeComponent();
            this.dgvResultado.AutoGenerateColumns = false;
            CargarRutas();
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

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string excelConexionString = string.Empty;
                excelConexionString = string.Format(ConfigurationManager.ConnectionStrings["xls"].ToString(), ConfigurationManager.AppSettings["OrigenArchivosCarga"] + txtRuta.Text.Trim());

                // Create the connection object
                OleDbConnection oledbConn = new OleDbConnection(excelConexionString);
                // Open connection
                oledbConn.Open();
                // Get the data table containg the schema guid.
                DataTable dtHojas = oledbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                OleDbCommand cmd = new OleDbCommand(string.Format("SELECT {1} FROM [{0}]", ConfigurationManager.AppSettings["HojaParaImportar"], ConfigurationManager.AppSettings["ColumnasParaCargar"]), oledbConn);

                // Create new OleDbDataAdapter
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                oleda.SelectCommand = cmd;
                // Create a DataSet which will hold the data extracted from the worksheet.
                DataSet ds = new DataSet();
                // Fill the DataSet from the data extracted from the worksheet.
                oleda.Fill(ds, "Excel");
                oledbConn.Close();

                using (Modelo.distribuidoraEntities contexto = new Modelo.distribuidoraEntities())
                {
                    Modelo.tarjeta tarjeta;
                    Modelo.movimiento movimiento;
                    string[] nombreCompleto;
                    string nombre, apellido1, apellido2;
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        nombre = apellido2 = apellido1 = string.Empty;
                        nombreCompleto = fila["nombre"].ToString().Split(' ');
                        if (nombreCompleto.Length >= 1)
                        {
                            nombre = nombreCompleto[0].Length <= 45 ? nombreCompleto[0] : nombreCompleto[0].Substring(0, 45);
                        }
                        if (nombreCompleto.Length >= 2)
                        {
                            apellido1 = nombreCompleto[1].Length <= 45 ? nombreCompleto[1] : nombreCompleto[1].Substring(0, 45);
                        }
                        if (nombreCompleto.Length >= 3)
                        {
                            apellido2 = nombreCompleto[2].Length <= 45 ? nombreCompleto[2] : nombreCompleto[2].Substring(0, 45);
                        }

                        tarjeta = new Modelo.tarjeta()
                        {
                            Agente = "SYS",
                            Nombre = nombre,
                            Apellido1 = apellido1,
                            Apellido2 = apellido2,
                            Direccion = fila["direccion"].ToString().Length <= 300 ? fila["direccion"].ToString() : fila["direccion"].ToString().Substring(0,300),
                            Estado = "A",
                            FechaCreacion = DateTime.Now,
                            FechaRegistro = DateTime.Now,
                            idRuta = short.Parse(this.cmbRuta.SelectedValue.ToString()),
                            Saldo = decimal.Parse(fila["saldo"].ToString()),
                            CodigoTemporal = fila["codigo"].ToString()
                        };

                        movimiento = new Modelo.movimiento()
                        {
                            Agente = "SYS",
                            Descripcion = fila["prenda"].ToString().Length <= 100 ? fila["prenda"].ToString() : fila["prenda"].ToString().Substring(0,100),
                            Fecha = DateTime.Now,
                            FechaAbono = DateTime.Now,
                            idTipoMovimiento = 4,
                            Monto = tarjeta.Saldo,
                            Saldo = tarjeta.Saldo
                        };
                        tarjeta.movimiento.Add(movimiento);
                        contexto.tarjeta.Add(tarjeta);
                    }//fin foreach de ds

                    int resultado = contexto.SaveChanges();

                    MessageBox.Show(string.Format("Se almacenó la información con éxito, registros:{0}", resultado.ToString()));
                }//fin using
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            short ruta = short.Parse(this.cmbRuta.SelectedValue.ToString());
            using (Modelo.distribuidoraEntities contexto = new Modelo.distribuidoraEntities())
            {
                this.dgvResultado.DataSource = contexto.tarjeta.Where(t => t.idRuta == ruta).ToList();
            }
        }//fin metodo
    }
}
