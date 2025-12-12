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
using System.Net.Mail;

namespace PizzicattiValentino_GestorAlumos.Forms
{
    public partial class DatosAlumnos : Form
    {
        private string nombreArchivo;
        private string extensionArchivo;
        private int cantidadAlumnos;
        private int cantidadActual = 0;
        private List<Alumno> listaAlumnos = new List<Alumno>();
        public DatosAlumnos(string nombreArchivo, string extensionArchivo, int cantidadAlumnos)
        {
            InitializeComponent();
            this.nombreArchivo = nombreArchivo;
            this.extensionArchivo = extensionArchivo;
            this.cantidadAlumnos = cantidadAlumnos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Validar campos
            if (string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            if (!int.TryParse(txtLegajo.Text, out int legajo))
            {
                MessageBox.Show("El Legajo debe contener solo números.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (listaAlumnos.Any(a => a.Legajo == txtLegajo.Text))
            {
                MessageBox.Show("Ya existe un alumno con ese número de legajo.","Legajo repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número.", "Error", MessageBoxButtons.OK);
                return;
            }
            
            if (!int.TryParse(txtLegajo.Text, out int telefono))
            {
                MessageBox.Show("El numero de telefono debe contener solo numeros" , "Error", MessageBoxButtons.OK);
            }

            // verificar formato de mail con libreria System.net mail
            try
            {
                MailAddress mail = new MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("El Email ingresado no es válido.");
                return;
            }


            // Crear alumno
            Alumno nuevo = new Alumno(txtLegajo.Text, txtApellido.Text, txtNombre.Text, txtDni.Text, txtEmail.Text, txtTelefono.Text );

            listaAlumnos.Add(nuevo);
            cantidadActual++;

            // Limpiar campos
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();

            // Avisar progreso
            MessageBox.Show($"Alumno {cantidadActual}/{cantidadAlumnos} agregado.");

            // ¿Ya se completó la cantidad solicitada?
            if (cantidadActual == cantidadAlumnos)
            {
                GuardarArchivoYSalir();
            }
        }
        private void GuardarArchivoYSalir()
        {
            try
            {
                GestorArchivos gestor = new GestorArchivos();
                string ruta = nombreArchivo + extensionArchivo;

                switch (extensionArchivo)
                {
                    case ".txt":
                        gestor.GuardarTXT(ruta, listaAlumnos);
                        break;

                    case ".csv":
                        gestor.GuardarCSV(ruta, listaAlumnos);
                        break;

                    case ".json":
                        gestor.GuardarJSON(ruta, listaAlumnos);
                        break;

                    case ".xml":
                        gestor.GuardarXML(ruta, listaAlumnos);
                        break;
                }

                MessageBox.Show("Archivo guardado correctamente: " + ruta);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }


    }
}
