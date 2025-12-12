using PizzicattiValentino_GestorAlumos.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PizzicattiValentino_GestorAlumos.src
{
    public class GeneradorReportes
    {
        private GestorArchivos gestor = new GestorArchivos();

        // Lee cualquier archivo soportado y devuelve la lista de alumnos
        public List<Alumno> CargarArchivo(string ruta)
        {
            string ext = Path.GetExtension(ruta).ToLower();

            return ext switch
            {
                ".txt" => gestor.LeerTXT(ruta),
                ".csv" => gestor.LeerCSV(ruta),
                ".json" => gestor.LeerJSON(ruta),
                ".xml" => gestor.LeerXML(ruta),
                _ => throw new Exception("Formato no soportado.")
            };
        }

        // Genera el reporte en texto
        public string GenerarReporte(List<Alumno> alumnos)
        {
            if (alumnos == null || alumnos.Count == 0)
                throw new Exception("No hay alumnos para generar el reporte.");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("================================================================================");
            sb.AppendLine("                    REPORTE DE ALUMNOS POR APELLIDO");
            sb.AppendLine($"                    Fecha: {DateTime.Now}");
            sb.AppendLine("================================================================================");
            sb.AppendLine();

            var grupos = alumnos
                .OrderBy(a => a.Apellido)
                .GroupBy(a => a.Apellido);

            int totalAlumnos = alumnos.Count;
            int totalApellidos = grupos.Count();

            foreach (var grupo in grupos)
            {
                sb.AppendLine($"APELLIDO: {grupo.Key.ToUpper()}");
                sb.AppendLine("--------------------------------------------------------------------------------");

                foreach (var a in grupo)
                {
                    sb.AppendLine($"  Legajo: {a.Legajo}");
                    sb.AppendLine($"  Nombres: {a.Nombres}");
                    sb.AppendLine($"  Documento: {a.NumeroDocumento}");
                    sb.AppendLine($"  Email: {a.Email}");
                    sb.AppendLine($"  Teléfono: {a.Telefono}");
                    sb.AppendLine();
                }

                sb.AppendLine($"  → Subtotal {grupo.Key.ToUpper()}: {grupo.Count()} alumno(s)");
                sb.AppendLine();
            }

            sb.AppendLine("================================================================================");
            sb.AppendLine("                           RESUMEN GENERAL");
            sb.AppendLine("================================================================================");
            sb.AppendLine($"Total de Apellidos diferentes: {totalApellidos}");
            sb.AppendLine($"Total de Alumnos registrados: {totalAlumnos}");
            sb.AppendLine("================================================================================");

            return sb.ToString();
        }

        // Guardar en archivo TXT
        public void GuardarReporteTXT(string rutaDestino, string contenido)
        {
            File.WriteAllText(rutaDestino, contenido, Encoding.UTF8);
        }
    }
}

