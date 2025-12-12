using PizzicattiValentino_GestorAlumos.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzicattiValentino_GestorAlumos.Forms
{
    using System.Text.RegularExpressions;
    using System.Text.Json;
    using System.Xml.Serialization;

    public partial class FormAgregarAlumno : Form
    {
        private List<Alumno> alumnosOriginal;
        private List<Alumno> alumnosActual;
        private string rutaArchivo;
        private string extensionArchivo;

        public Alumno AlumnoCreado { get; private set; }  // ✔ NECESARIO

        public FormAgregarAlumno(List<Alumno> lista, string ruta)
        {
            InitializeComponent();

            alumnosActual = lista;
            rutaArchivo = ruta;
            extensionArchivo = Path.GetExtension(ruta).ToLower();

            // Copia profunda de respaldo (para cancelar si hiciera falta)
            alumnosOriginal = lista
                .Select(a => new Alumno(a.Legajo, a.Apellido, a.Nombres, a.NumeroDocumento, a.Email, a.Telefono))
                .ToList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Validar legajo repetido
            if (alumnosActual.Any(a => a.Legajo == txtLegajo.Text.Trim()))
            {
                MessageBox.Show("El legajo ya existe. Ingrese uno diferente.");
                return;
            }

            // Validar documento numérico
            if (!txtDocumento.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de documento debe ser numérico.");
                return;
            }

            // Validar teléfono numérico
            if (!txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe ser un número.");
                return;
            }

            // Validar email
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formato de email inválido.");
                return;
            }

            // Crear alumno
            AlumnoCreado = new Alumno(
                txtLegajo.Text.Trim(),
                txtApellido.Text.Trim(),
                txtNombre.Text.Trim(),   // O txtNombres según tu form
                txtDocumento.Text.Trim(),
                txtEmail.Text.Trim(),
                txtTelefono.Text.Trim()
            );

            alumnosActual.Add(AlumnoCreado);

            

            MessageBox.Show("Alumno agregado correctamente.");

            DialogResult = DialogResult.OK;  // ✔ SOLO UNA VEZ
            Close();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
