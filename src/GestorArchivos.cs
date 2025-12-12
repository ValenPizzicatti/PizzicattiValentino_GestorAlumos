using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using PizzicattiValentino_GestorAlumos.src.Models;


namespace PizzicattiValentino_GestorAlumos.src
{
    public class GestorArchivos
    {
        private readonly string rutaBase;

        public GestorArchivos()
        {
            // Ruta absoluta a la carpeta Ejemplos dentro del proyecto
            rutaBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Ejemplos");
            rutaBase = Path.GetFullPath(rutaBase);

            // Crear carpeta si no existe
            if (!Directory.Exists(rutaBase))
                Directory.CreateDirectory(rutaBase);
        }

        // =====================
        // MÉTODO PRIVADO UTILIDAD
        // =====================
        private string RutaEnEjemplos(string nombreArchivo)
        {
            return Path.Combine(rutaBase, nombreArchivo);
        }

        // =====================
        // GUARDAR
        // =====================
        public void GuardarTXT(string nombreArchivo, List<Alumno> alumnos)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);

            using (StreamWriter sw = new StreamWriter(ruta))
                foreach (var a in alumnos)
                    sw.WriteLine(a.toTXT());
        }

        public void GuardarCSV(string nombreArchivo, List<Alumno> alumnos)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);

            using (StreamWriter sw = new StreamWriter(ruta))
                foreach (var a in alumnos)
                    sw.WriteLine(a.toCSV());
        }

        public void GuardarJSON(string nombreArchivo, List<Alumno> alumnos)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);

            string json = JsonSerializer.Serialize(alumnos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json);
        }

        public void GuardarXML(string nombreArchivo, List<Alumno> alumnos)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);

            XmlSerializer xml = new XmlSerializer(typeof(List<Alumno>));

            using (StreamWriter sw = new StreamWriter(ruta))
                xml.Serialize(sw, alumnos);
        }

        // =====================
        // LEER
        // =====================
        public List<Alumno> LeerTXT(string nombreArchivo)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);
            List<Alumno> lista = new List<Alumno>();

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var partes = linea.Split('|');

                if (partes.Length == 6)
                {
                    lista.Add(new Alumno(
                        partes[0], partes[1], partes[2],
                        partes[3], partes[4], partes[5]
                    ));
                }
            }

            return lista;
        }

        public List<Alumno> LeerCSV(string nombreArchivo)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);
            List<Alumno> lista = new List<Alumno>();

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var partes = linea.Split(',');

                if (partes.Length == 6)
                {
                    lista.Add(new Alumno(
                        partes[0], partes[1], partes[2],
                        partes[3], partes[4], partes[5]
                    ));
                }
            }

            return lista;
        }

        public List<Alumno> LeerJSON(string nombreArchivo)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);
            string contenido = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Alumno>>(contenido);
        }

        public List<Alumno> LeerXML(string nombreArchivo)
        {
            string ruta = RutaEnEjemplos(nombreArchivo);

            XmlSerializer xml = new XmlSerializer(typeof(List<Alumno>));

            using (StreamReader sr = new StreamReader(ruta))
                return (List<Alumno>)xml.Deserialize(sr);
        }
    }
}
