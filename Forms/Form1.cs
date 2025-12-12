using PizzicattiValentino_GestorAlumos.Forms;
using PizzicattiValentino_GestorAlumos.src;

namespace PizzicattiValentino_GestorAlumos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            CrearArchivo crearArchivo = new CrearArchivo();
            crearArchivo.ShowDialog();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerArchivo leer = new LeerArchivo();
            leer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSolicitarArchiv Solicitar = new FormSolicitarArchiv();
            Solicitar.ShowDialog();
        }

        private void btnEliminarArchivo_Click(object sender, EventArgs e)
        {
            EliminarArchivoSolicitarArchivo form = new EliminarArchivoSolicitarArchivo();
            form.ShowDialog();
        }

        private void txtConvertir_Click(object sender, EventArgs e)
        {
            FormConvertir convertir = new FormConvertir();
            convertir.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte reporte = new FormReporte();
            reporte.ShowDialog();
        }
    }
}
