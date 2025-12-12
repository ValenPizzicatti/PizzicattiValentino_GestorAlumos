using PizzicattiValentino_GestorAlumos.src;
using PizzicattiValentino_GestorAlumos.src.Models;
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

    public partial class FormReporte : Form
    {
        private GeneradorReportes generador = new GeneradorReportes();
        private List<Alumno> alumnosCargados;
        private string rutaArchivoOrigen;
        private string rutaBase;  // Carpeta Ejemplos real

        public FormReporte()
        {
            InitializeComponent();
            ConfigurarControles();

            // Ruta correcta usando tu versión
            rutaBase = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..",
                "..",
                "..",
                "Ejemplos"
            );

            rutaBase = Path.GetFullPath(rutaBase);
        }

        private void ConfigurarControles()
        {
            cmbFormato.Items.Add("TXT");
            cmbFormato.Items.Add("CSV");
            cmbFormato.Items.Add("JSON");
            cmbFormato.Items.Add("XML");
            cmbFormato.SelectedIndex = 0;

            txtReporte.ReadOnly = true;
            txtReporte.ScrollBars = ScrollBars.Vertical;
            txtReporte.Font = new Font("Consolas", 10);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
                    throw new Exception("Ingrese un nombre de archivo.");

                string formato = cmbFormato.SelectedItem.ToString().ToLower();

                // Ruta dentro de Ejemplos
                rutaArchivoOrigen = Path.Combine(
                    rutaBase,
                    $"{txtNombreArchivo.Text}.{formato}"
                );

                if (!File.Exists(rutaArchivoOrigen))
                    throw new Exception("El archivo no existe en la carpeta Ejemplos.");

                alumnosCargados = generador.CargarArchivo(rutaArchivoOrigen);

                string reporte = generador.GenerarReporte(alumnosCargados);

                txtReporte.Text = reporte;

                lblEstado.Text = "Reporte generado correctamente.";
                lblEstado.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
                lblEstado.ForeColor = Color.Red;
            }
        }

        private void btnGuardarTXT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtReporte.Text))
                    throw new Exception("Primero genere un reporte.");

                string rutaDestino = Path.Combine(
                    rutaBase,
                    "ReporteGenerado.txt"
                );

                generador.GuardarReporteTXT(rutaDestino, txtReporte.Text);

                lblEstado.Text = $"Reporte guardado en la carpeta Ejemplos.";
                lblEstado.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
                lblEstado.ForeColor = Color.Red;
            }
        }
    }

}
