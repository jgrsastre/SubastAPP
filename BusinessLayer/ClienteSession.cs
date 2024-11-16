using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class ClienteSession
    {
        // La conexión del cliente es estática para que pueda ser accesible desde cualquier parte de la aplicación
        private static ClienteConexion _conexionCliente;

        // Propiedad para acceder a la conexión (solo lectura)
        public static ClienteConexion ConexionCliente
        {
            get { return _conexionCliente; }
        }

        // Método para iniciar la sesión (conectar al servidor)
        public static bool IniciarSesion(string direccionServidor, int puerto)
        {
            try
            {
                _conexionCliente = new ClienteConexion(direccionServidor, puerto);
                return true;  // Si la conexión fue exitosa
            }
            catch (Exception ex)
            {
                // Si no se puede conectar, devolver false
                MessageBox.Show("Error al conectar al servidor: " + ex.Message);
                return false;
            }
        }

        // Método para cerrar la sesión (desconectar del servidor)
        public static void CerrarSesion()
        {
            if (_conexionCliente != null)
            {
                _conexionCliente.CerrarConexion();
                _conexionCliente = null;
                MessageBox.Show("Desconectado exitosamente.");
            }
        }
    }
}
