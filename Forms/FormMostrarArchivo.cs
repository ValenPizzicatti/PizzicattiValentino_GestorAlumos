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
    public partial class FormMostrarArchivo : Form
    {
        private string rutaArchivo;
        public FormMostrarArchivo(string nombreArchivo)
        {
            InitializeComponent();
            rutaArchivo = nombreArchivo;
        }
        private void FormMostrarArchivo_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarArchivo();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo:\n" + ex.Message);
            }
        }

        private void MostrarArchivo()
        {
            string carpetaEjemplos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Ejemplos");
            string rutaCompleta = Path.Combine(carpetaEjemplos, rutaArchivo);

            if (!File.Exists(rutaCompleta))
            {
                MessageBox.Show("El archivo no existe en /Ejemplos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ext = Path.GetExtension(rutaCompleta).ToLower();
            List<Alumno> alumnos;
            GestorArchivos gestor = new GestorArchivos();

            switch (ext)
            {
                case ".txt":
                    alumnos = gestor.LeerTXT(rutaCompleta);
                    break;
                case ".csv":
                    alumnos = gestor.LeerCSV(rutaCompleta);
                    break;
                case ".json":
                    alumnos = gestor.LeerJSON(rutaCompleta);
                    break;
                case ".xml":
                    alumnos = gestor.LeerXML(rutaCompleta);
                    break;

                default:
                    MessageBox.Show("Formato no reconocido.", "Error");
                    return;
            }

            MostrarEnTabla(alumnos);
        }

        private void MostrarEnTabla(List<Alumno> alumnos)
        {
            StringBuilder sb = new StringBuilder();

            string linea = new string('=', 130);

 
            sb.AppendLine(linea);
            sb.AppendLine($"| {"Legajo",-10} | {"Apellido",-15} | {"Nombres",-20} | {"Documento",-15} | {"Email",-40} | {"Telefono",-12} |");
            sb.AppendLine(linea);

            int contador = 0;

            foreach (var a in alumnos)
            {
                sb.AppendLine(
                    $"| {a.Legajo,-10} | {a.Apellido,-15} | {a.Nombres,-20} | {a.NumeroDocumento,-15} | {a.Email,-40} | {a.Telefono,-12} |"
                );

                contador++;

                // PAGINACIÓN CADA 20
                if (contador % 20 == 0)
                {
                    sb.AppendLine(linea);
                    sb.AppendLine("Presione OK para continuar…");

                    txtResultado.Text = sb.ToString();
                    MessageBox.Show($"Mostrados {contador} registros...",
                                    "Paginación", MessageBoxButtons.OK);

                    // Reinicia la página
                    sb.Clear();
                    sb.AppendLine(linea);
                    sb.AppendLine($"| {"Legajo",-10} | {"Apellido",-15} | {"Nombres",-20} | {"Documento",-15} | {"Email",-40} | {"Telefono",-12} |");
                    sb.AppendLine(linea);
                }
            }

            // PIE DE TABLA
            sb.AppendLine(linea);
            sb.AppendLine($"Total de alumnos: {alumnos.Count}");

            txtResultado.Text = sb.ToString();
            txtResultado.Select(0, 0);

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
