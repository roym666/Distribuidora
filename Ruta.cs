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
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.btnGuardar.Enabled = false;
            try
            {
                if (Validar())
                {
                    using (Modelo.distribuidoraEntities contexto = new Modelo.distribuidoraEntities())
                    {
                        Modelo.ruta ruta = new Modelo.ruta()
                        {
                            Descripcion = this.txtDescripcion.Text.Trim(),
                            Estado = true
                        };
                        contexto.ruta.Add(ruta);
                        contexto.SaveChanges();
                        Cursor.Current = Cursors.Default;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.btnGuardar.Enabled = true;
        }

        private bool Validar()
        {
            if (this.txtDescripcion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La descripción es requerida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
