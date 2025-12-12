using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzicattiValentino_GestorAlumos.src.Models
{
    public class Alumno
    {
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Alumno(string legajo, string apellido, string nombres, string numeroDocumento, string email, string telefono)
        {
            Legajo = legajo;
            Apellido = apellido;
            Nombres = nombres;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
        }
        public Alumno() // Este constructor lo requiere xml para funcionar
        {

        }

        public string toTXT()
        {
            return $"{Legajo}|{Apellido}|{Nombres}|{NumeroDocumento}|{Email}|{Telefono}";
        }
        public string toCSV()
        {
            return $"{Legajo},{Apellido},{Nombres},{NumeroDocumento},{Email},{Telefono}";
        }
     
    }
}


