using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Design_Patterns.Singleton
{
    public class dbConexionSingleto
    {
        #region atributos estativos

        private static SqlConnection instancia = null;
        private static readonly object padlock = new object();

        #endregion

        #region contructor

        private dbConexionSingleto()
        {
        }
        #endregion

        #region defincion de la instancia unica

        public static SqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new SqlConnection();
                        instancia.ConnectionString = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
                    }
                    return instancia;
                }
            }
        }

        #endregion
        public static void Open()
        {
            if (instancia != null)
                instancia.Open();
        }

        public static void Close()
        {
            if (instancia != null)
                instancia.Close();
        }

    }
}
