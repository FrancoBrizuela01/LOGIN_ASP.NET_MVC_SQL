using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOGIN_ASP.NET_MVC_SQL.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }
    }
}