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
    public partial class FormConvertir : Form
    {
        private Conversor conversor = new Conversor();

        public FormConvertir()
        {
            InitializeComponent();
            CargarFormatosDestino();
            ConfigurarGrid();
        }

        private void CargarFormatosDestino()
        {
            cmbFormatoDestino.Items.Add("TXT");
            cmbFormatoDestino.Items.Add("CSV");
            cmbFormatoDestino.Items.Add("JSON");
            cmbFormatoDestino.Items.Add("XML");
            cmbFormatoDestino.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            dgvResumen.Columns.Clear();
            dgvResumen.Columns.Add("archivo", "Archivo");
            dgvResumen.Columns.Add("registros", "Registros");
            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // -------------------------------
        // BOTÓN BUSCAR ARCHIVO
        // -------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtArchivoOrigen.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                MessageBox.Show("Ingrese el nombre del archivo con extensión.");
                return;
            }

            //  Carpera EJEMPLOS del proyecto
            string carpetaEjemplos = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Ejemplos" );

            carpetaEjemplos = Path.GetFullPath(carpetaEjemplos);

            //  Ruta completa del archivo
            string ruta = Path.Combine(carpetaEjemplos, nombreArchivo);

            if (!File.Exists(ruta))
            {
                MessageBox.Show($"El archivo no existe en:\n{ruta}");
                return;
            }

            txtArchivoOrigen.Text = ruta;

            // Detectar formato actual
            string formato = conversor.DetectarFormato(ruta);
            label.Text = formato.ToUpper();

            MessageBox.Show("Archivo encontrado correctamente.");
        }


        // -------------------------------
        // BOTÓN CONVERTIR
        // -------------------------------
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtArchivoOrigen.Text))
                {
                    MessageBox.Show("Debe seleccionar un archivo origen.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNuevoNombre.Text))
                {
                    MessageBox.Show("Debe escribir el nombre del archivo destino.");
                    return;
                }

                string rutaOrigen = txtArchivoOrigen.Text;

                string formatoDestino = cmbFormatoDestino.SelectedItem.ToString().ToLower();
               
                
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\..\Ejemplos");

                carpeta = Path.GetFullPath(carpeta);

                string rutaDestino = Path.Combine(
                    carpeta,
                    txtNuevoNombre.Text + "." + formatoDestino
                );

                // 1. Leer archivo origen
                List<Alumno> alumnos = conversor.Leer(rutaOrigen);

                // 2. Guardar archivo destino
                conversor.Guardar(rutaDestino, formatoDestino, alumnos);

                // 3. Mostrar resumen en el grid
                dgvResumen.Rows.Clear();

                dgvResumen.Rows.Add(
                    Path.GetFileName(rutaOrigen),
                    alumnos.Count
                );

                dgvResumen.Rows.Add(
                    Path.GetFileName(rutaDestino),
                    alumnos.Count
                );

                MessageBox.Show("Conversión realizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir: " + ex.Message);
            }
        }
    }
}
