using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class B_SocketClient
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public void Connect(string serverAddress, int port)
        {
            _client = new TcpClient(serverAddress, port);
            _stream = _client.GetStream();
        }

        public void SendMessage(string message)
        {
            if (_stream == null) return;

            byte[] data = Encoding.UTF8.GetBytes(message);
            _stream.Write(data, 0, data.Length);
        }

        public string ReceiveMessage()
        {
            if (_stream == null) return null;

            byte[] buffer = new byte[1024];
            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }

        public void Disconnect()
        {
            _stream?.Close();
            _client?.Close();
        }
    }
}
