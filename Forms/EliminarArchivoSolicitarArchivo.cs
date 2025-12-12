using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzicattiValentino_GestorAlumos.Forms
{
    public partial class EliminarArchivoSolicitarArchivo : Form
    {
        public string RutaArchivoEncontrado { get; private set; }

        public EliminarArchivoSolicitarArchivo()
        {
            InitializeComponent();
            btnContinuar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtRuta.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                MessageBox.Show("Ingrese el nombre del archivo con extensión.");
                return;
            }

            // 📌 Siempre ir a la carpeta Ejemplos del proyecto
            string carpetaEjemplos = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\Ejemplos"
            );

            carpetaEjemplos = Path.GetFullPath(carpetaEjemplos);

            // 📌 Se arma la ruta final
            string rutaArchivo = Path.Combine(carpetaEjemplos, nombreArchivo);

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show($"El archivo no existe en:\n{rutaArchivo}");
                dgvInfo.DataSource = null;
                btnContinuar.Enabled = false;
                return;
            }

            RutaArchivoEncontrado = rutaArchivo;

            FileInfo info = new FileInfo(rutaArchivo);

            // Crear tabla para mostrar info
            var tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Tamaño (KB)");
            tabla.Columns.Add("Creación");
            tabla.Columns.Add("Última Modificación");

            tabla.Rows.Add(
                info.Name,
                (info.Length / 1024.0).ToString("F2"),
                info.CreationTime.ToString(),
                info.LastWriteTime.ToString()
            );

            dgvInfo.DataSource = tabla;
            dgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfo.ClearSelection();

            btnContinuar.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RutaArchivoEncontrado))
            {
                MessageBox.Show("Debe seleccionar un archivo primero.");
                return;
            }

            FormEliminarArchivo frm = new FormEliminarArchivo(RutaArchivoEncontrado);
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
