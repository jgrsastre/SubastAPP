using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BCrypt.Net;
using static System.Collections.Specialized.BitVector32;


namespace ServerLayer
{
    class Program
    {

        private const int Puerto = 12345;  // Puerto en el que el servidor escuchará
        private static TcpListener _listener;

        // Diccionario para almacenar las sesiones de los clientes logueados
        private static Dictionary<TcpClient, Session> clientesLogueados = new Dictionary<TcpClient, Session>();

        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            _listener = new TcpListener(IPAddress.Any, Puerto); // Puerto 12345
            _listener.Start();
            Console.WriteLine("Servidor iniciado...");

            while (true)
            {
                try
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    Console.WriteLine("Cliente conectado.");
                    var clientHandler = new ClienteHandler(client);
                    Thread clientThread = new Thread(clientHandler.HandleClient);
                    clientThread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al aceptar cliente: " + ex.Message);
                }
            }
        }

        // Función para agregar un cliente logueado al diccionario
        public static void AddClienteLogueado(TcpClient client, Session session)
        {
            lock (clientesLogueados)
            {
                clientesLogueados[client] = session;
            }
        }

        // Función para eliminar un cliente logueado del diccionario
        public static void RemoveClienteLogueado(TcpClient client)
        {
            lock (clientesLogueados)
            {
                clientesLogueados.Remove(client);
            }
        }

        // Función para verificar si un cliente está logueado
        public static bool IsClienteLogueado(TcpClient client)
        {
            lock (clientesLogueados)
            {
                return clientesLogueados.ContainsKey(client);
            }
        }

        // Función para obtener la sesión de un cliente
        public static Session GetClienteSession(TcpClient client)
        {
            lock (clientesLogueados)
            {
                return clientesLogueados.ContainsKey(client) ? clientesLogueados[client] : null;
            }
        }
    }
}
