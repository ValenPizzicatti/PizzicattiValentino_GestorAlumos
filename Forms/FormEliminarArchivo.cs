using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzicattiValentino_GestorAlumos.Forms
{
    public partial class FormEliminarArchivo : Form
    {
        private string ruta;

        public FormEliminarArchivo(string rutaArchivo)
        {
            InitializeComponent();
            ruta = rutaArchivo;
            lblRuta.Text = ruta;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo ya no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("¿Está seguro que desea eliminar este archivo? \nEsta acción NO se puede deshacer.",  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

            if (r == DialogResult.Yes)
            {
                try
                {
                    File.Delete(ruta);
                    MessageBox.Show("Archivo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El archivo NO fue eliminado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
