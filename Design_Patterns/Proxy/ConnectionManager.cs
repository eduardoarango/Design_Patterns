using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Proxy
{
    public class ConnectionManager
    {
        private static bool Conexion;

        public ConnectionManager() {
            Conexion = false;
        }
        public static void conectate() {
            Conexion = true;
        }
        public static void desconectate()
        {
            Conexion = false;
        }

        public static bool HayConexion() {
            return Conexion;
        }
        ///http://migranitodejava.blogspot.pe/2011/06/proxy.html


    }
}
