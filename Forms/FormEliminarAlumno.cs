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
    public partial class FormEliminarAlumno : Form
    {
        private string rutaArchivo;
        private List<Alumno> alumnosOriginal;
        private List<Alumno> alumnosActual;
        private Alumno alumnoEncontrado = null;

        public FormEliminarAlumno(List<Alumno> lista, string ruta)
        {
            InitializeComponent();

            rutaArchivo = ruta;

            // Crear copia profunda para alumnosOriginal (NO se modifica)
            alumnosOriginal = lista
                .Select(a => new Alumno(a.Legajo, a.Apellido, a.Nombres, a.NumeroDocumento, a.Email, a.Telefono))
                .ToList();

            // Esta es la lista editable
            alumnosActual = lista;

            // Configurar DataGrid
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAlumno.ClearSelection();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Ingrese un legajo.");
                return;
            }

            alumnoEncontrado = alumnosActual.FirstOrDefault(a => a.Legajo == txtLegajo.Text.Trim());

            if (alumnoEncontrado == null)
            {
                MessageBox.Show("No se encontró un alumno con ese legajo.");
                dgvAlumno.DataSource = null;
                return;
            }

            // Mostrar un solo alumno en la tabla
            dgvAlumno.DataSource = new List<Alumno> { alumnoEncontrado };
            dgvAlumno.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAlumno.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (alumnoEncontrado == null)
            {
                MessageBox.Show("Primero busque un alumno.");
                return;
            }

            var confirm = MessageBox.Show( "¿Seguro que desea eliminar este alumno?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning );

            if (confirm == DialogResult.No) return;

            // Eliminar de la lista en memoria
            alumnosActual.Remove(alumnoEncontrado);


            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
