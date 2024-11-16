using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLayer
{
    internal class Session
    {
        public string ClienteId { get; set; }  // El identificador único del cliente
        public DateTime LoginTime { get; set; } // Hora de inicio de sesión
        public bool IsLoggedIn { get; set; }    // Estado de la sesión (logueado o no)
    }
}
