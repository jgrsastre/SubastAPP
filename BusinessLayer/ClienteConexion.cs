using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ClienteConexion
    {
        private TcpClient _cliente;
        private NetworkStream _stream;

        // Constructor que establece la conexión al servidor
        public ClienteConexion(string direccionServidor, int puerto)
        {
            _cliente = new TcpClient(direccionServidor, puerto);
            _stream = _cliente.GetStream();
        }

        // Método para enviar datos al servidor y obtener la respuesta
        public string EnviarMensaje(string mensaje)
        {
            try
            {
                MessageBox.Show("ENVIANDOMENSAJE"+mensaje);
                // Convertir el mensaje a bytes y enviarlo
                byte[] data = Encoding.UTF8.GetBytes(mensaje);
                _stream.Write(data, 0, data.Length);

                // Leer la respuesta del servidor
                byte[] buffer = new byte[1024];
                int bytesLeidos = _stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesLeidos);
            }
            catch (Exception ex)
            {
                return "Error de conexión: " + ex.Message;
            }
        }

        // Método para cerrar la conexión cuando ya no sea necesaria
        public void CerrarConexion()
        {
            _stream.Close();
            _cliente.Close();
        }
    }
}
