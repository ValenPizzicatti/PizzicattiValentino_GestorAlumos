using PizzicattiValentino_GestorAlumos.src;
using PizzicattiValentino_GestorAlumos.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzicattiValentino_GestorAlumos.Forms
{
    public partial class FormModificarAlumno : Form
    {private List<Alumno> alumnosOriginal;
     private List<Alumno> alumnosActual;
        private string rutaArchivo;
        private string extensionArchivo;
        private GestorArchivos gestor = new GestorArchivos();
        public FormModificarAlumno(List<Alumno> lista, string ruta)
        {
            InitializeComponent();

            rutaArchivo = ruta;
            extensionArchivo = Path.GetExtension(ruta).ToLower();

            // Crear copia profunda (NO se modifica nunca)
            alumnosOriginal = lista
                .Select(a => new Alumno(a.Legajo, a.Apellido, a.Nombres, a.NumeroDocumento, a.Email, a.Telefono))
                .ToList();

            // Esta SÍ se modifica en memoria
            alumnosActual = lista;

 
        }
        private Alumno alumnoEncontrado;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string legajo = txtLegajoBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(legajo))
            {
                MessageBox.Show("Ingrese un legajo.");
                return;
            }

            alumnoEncontrado = alumnosActual.FirstOrDefault(a => a.Legajo == legajo);

            if (alumnoEncontrado == null)
            {
                MessageBox.Show("No existe un alumno con ese legajo.");
                groupDatos.Enabled = false;
                return;
            }

            // Cargar los datos en los campos
            txtLegajo.Text = alumnoEncontrado.Legajo;
            txtApellido.Text = alumnoEncontrado.Apellido;
            txtNombre.Text = alumnoEncontrado.Nombres;
            txtDocumento.Text = alumnoEncontrado.NumeroDocumento;
            txtEmail.Text = alumnoEncontrado.Email;
            txtTelefono.Text = alumnoEncontrado.Telefono;

            // Habilitar edición
            groupDatos.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (alumnoEncontrado == null)
            {
                MessageBox.Show("Debe buscar un alumno primero.");
                return;
            }

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!txtDocumento.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de documento debe ser numérico.");
                return;
            }

            if (!txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe ser numérico.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formato de email inválido.");
                return;
            }

            // --- ACTUALIZAR EN MEMORIA ---
            alumnoEncontrado.Apellido = txtApellido.Text.Trim();
            alumnoEncontrado.Nombres = txtNombre.Text.Trim();
            alumnoEncontrado.NumeroDocumento = txtDocumento.Text.Trim();
            alumnoEncontrado.Email = txtEmail.Text.Trim();
            alumnoEncontrado.Telefono = txtTelefono.Text.Trim();

            MessageBox.Show(
                "Modificación realizada en memoria.\nPara aplicarla al archivo use 'GUARDAR CAMBIOS'.",
                "Modificación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
