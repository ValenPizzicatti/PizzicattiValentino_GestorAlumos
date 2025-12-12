using PizzicattiValentino_GestorAlumos.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzicattiValentino_GestorAlumos.src
{
    public class Conversor
    {
        private GestorArchivos gestor = new GestorArchivos();

        // Detecta la extensión y lee el archivo original
        public List<Alumno> Leer(string ruta)
        {
            string ext = Path.GetExtension(ruta).ToLower();

            switch (ext)
            {
                case ".txt":
                    return gestor.LeerTXT(ruta);

                case ".csv":
                    return gestor.LeerCSV(ruta);

                case ".json":
                    return gestor.LeerJSON(ruta);

                case ".xml":
                    return gestor.LeerXML(ruta);

                default:
                    throw new Exception("Formato no soportado para lectura.");
            }
        }

        // Guarda una lista de alumnos en el formato elegido
        public void Guardar(string rutaDestino, string formatoDestino, List<Alumno> alumnos)
        {
            formatoDestino = formatoDestino.ToLower();

            switch (formatoDestino)
            {
                case "txt":
                    gestor.GuardarTXT(rutaDestino, alumnos);
                    break;

                case "csv":
                    gestor.GuardarCSV(rutaDestino, alumnos);
                    break;

                case "json":
                    gestor.GuardarJSON(rutaDestino, alumnos);
                    break;

                case "xml":
                    gestor.GuardarXML(rutaDestino, alumnos);
                    break;

                default:
                    throw new Exception("Formato no soportado para guardar.");
            }
        }

        // Obtiene extensión del archivo origen como texto (txt, csv, json, xml)
        public string DetectarFormato(string ruta)
        {
            return Path.GetExtension(ruta).Replace(".", "").ToLower();
        }
    }


}
