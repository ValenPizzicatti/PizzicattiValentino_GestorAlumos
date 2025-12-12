using PizzicattiValentino_GestorAlumos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzicattiValentino_GestorAlumos.src
{
    public partial class CrearArchivo : Form
    {
        public CrearArchivo()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("No puede dejar el texto vacio!");
                return;
            }

            string extension = "";
            if (rdbCsv.Checked) extension = ".csv";
            else if (rdbTxt.Checked) extension = ".txt";
            else if (rdbJson.Checked) extension = ".json";
            else if (rdbXml.Checked) extension = ".xml";

            if (string.IsNullOrEmpty(extension))
            {
                MessageBox.Show("Seleccione un formato!");
                return;
            }
            if (!int.TryParse(txtCantidadAlumnos.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (solo números enteros mayores a 0).");
                return;
            }


            DatosAlumnos datos = new DatosAlumnos(txtNombreArchivo.Text, extension, cantidad);
            datos.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
