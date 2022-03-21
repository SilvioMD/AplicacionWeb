using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLogin.Models.Entity
{
    public class UsuarioE
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}