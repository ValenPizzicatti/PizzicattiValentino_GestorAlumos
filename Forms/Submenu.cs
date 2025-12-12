using PizzicattiValentino_GestorAlumos.src;
using PizzicattiValentino_GestorAlumos.src.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzicattiValentino_GestorAlumos.Forms
{

    public partial class Submenu : Form
    {
        private List<Alumno> alumnosActual;
        private List<Alumno> alumnosOriginal;
        private string rutaArchivo;
        private string extensionArchivo;
        public Submenu(string ruta, List<Alumno> lista)
        {
            InitializeComponent();

            rutaArchivo = ruta;
            extensionArchivo = Path.GetExtension(ruta).ToLower();

            alumnosOriginal = lista; // esta es la lista real del archivo

            // copia profunda para modificaciones temporales
            alumnosActual = lista.Select(a => new Alumno(a.Legajo, a.Apellido,a.Nombres,a.NumeroDocumento,a.Email,a.Telefono)).ToList();
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno f = new FormAgregarAlumno(alumnosActual, rutaArchivo);

            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Alumno agregado al archivo!");
            }
           
        }

        private void btnModificarArchivo_Click(object sender, EventArgs e)
        {
            FormModificarAlumno mod = new FormModificarAlumno(alumnosActual, rutaArchivo);
            mod.ShowDialog();
            
        }


        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            FormEliminarAlumno eliminar = new FormEliminarAlumno(alumnosActual, rutaArchivo);
            eliminar.ShowDialog();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                //  Crear backup
                string backup = rutaArchivo + ".bak";

                if (File.Exists(backup))
                    File.Delete(backup);

                File.Copy(rutaArchivo, backup);

                GestorArchivos gestor = new GestorArchivos();
                switch (extensionArchivo)
                {
                    case ".txt":
                        gestor.GuardarTXT(rutaArchivo, alumnosActual);
                        break;

                    case ".csv":
                        gestor.GuardarCSV(rutaArchivo, alumnosActual);
                        break;

                    case ".json":
                        gestor.GuardarJSON(rutaArchivo, alumnosActual);
                        break;

                    case ".xml":
                        gestor.GuardarXML(rutaArchivo, alumnosActual);
                        break;
                }

                MessageBox.Show("Cambios guardados correctamente.\nSe creó un backup del archivo original.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            alumnosActual.Clear();

            foreach (var a in alumnosOriginal)
            {   
                alumnosActual.Add(new Alumno( a.Legajo,a.Apellido, a.Nombres, a.NumeroDocumento, a.Email, a.Telefono));
            }

            MessageBox.Show("Cambios descartados. Volviendo al menú principal.");

            Close();
        }
    }
}
