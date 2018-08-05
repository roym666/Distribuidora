using System;
using System.Linq;
using System.Windows.Forms;

namespace Distribuidora
{
    public partial class EliminarTarjeta : Form
    {
        public EliminarTarjeta()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.btnEliminar.Enabled = false;
            try
            {
                if (Validar())
                {
                    if (MessageBox.Show("Desea eliminar la tarjeta?", "Eliminar tarjeta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                        {
                            contextoGlobal.Database.ExecuteSqlCommand("INSERT INTO tarjeta_historico SELECT * FROM tarjeta where idTarjeta ={0};INSERT INTO movimiento_historico SELECT * FROM movimiento where idTarjeta ={0}; delete from movimiento where idTarjeta ={0};delete from tarjeta where idTarjeta ={0};", txtCodigo.Text.Trim());
                            MessageBox.Show("Se eliminó con éxito", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtCodigo.Text = string.Empty;
                            this.txtNombre.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnEliminar.Enabled = true;
            }
        }

        private bool Validar()
        {
            if (this.txtCodigo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El código es requerido", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void BuscarTarjeta()
        {
            this.txtNombre.Text = string.Empty;
            Cursor.Current = Cursors.WaitCursor;
            if (txtCodigo.Text.Trim() != string.Empty)
            {
                try
                {
                    using (Modelo.distribuidoraEntities contextoGlobal = new Modelo.distribuidoraEntities())
                    {
                        int idTarjeta = int.Parse(txtCodigo.Text.Trim());
                        Modelo.tarjeta tarjeta = contextoGlobal.tarjeta.FirstOrDefault(t => t.idTarjeta == idTarjeta);

                        if (tarjeta != null)
                        {
                            txtNombre.Text = String.Format("{0} {1} {2}", tarjeta.Nombre, tarjeta.Apellido1, tarjeta.Apellido2);
                            this.btnEliminar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No existe la tarjeta con el código indicado.", "Tarjeta no existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
