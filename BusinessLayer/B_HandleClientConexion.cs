using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class B_HandleClientConexion
    {
        public void ClientConexion(string ServerAddres, int Port)
        {
            D_HandleClientConexion _objDHandleClientConexion = new D_HandleClientConexion(ServerAddres,Port);
        }
    }
}
