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
    public partial class FormSolicitarArchiv : Form
    {
        public FormSolicitarArchiv()
        {
            InitializeComponent();
        }


        private void btnContinuar_Click(object sender, EventArgs e)
       {
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del archivo con extensión.");
                return;
            }

            // Ruta correcta hacia /Ejemplos
            string carpetaEjemplos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Ejemplos");

            string ruta = Path.Combine(carpetaEjemplos, txtNombreArchivo.Text.Trim());

            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo no existe en la carpeta /Ejemplos.");
                return;
            }

            string extension = Path.GetExtension(ruta).ToLower();

            GestorArchivos gestor = new GestorArchivos();
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                switch (extension)
                {
                    case ".txt": alumnos = gestor.LeerTXT(ruta); break;
                    case ".csv": alumnos = gestor.LeerCSV(ruta); break;
                    case ".json": alumnos = gestor.LeerJSON(ruta); break;
                    case ".xml": alumnos = gestor.LeerXML(ruta); break;
                    default:
                        MessageBox.Show("Formato no soportado.");
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error leyendo archivo: " + ex.Message);
                return;
            }

            // Abrir submenú y pasar datos
            Submenu f = new Submenu(ruta, alumnos);
            f.ShowDialog();

        }
    }
}
