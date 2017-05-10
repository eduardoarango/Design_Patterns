using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Design_Patterns.Abstract_Factory.dao.SqlServer;

namespace Design_Patterns.Abstract_Factory
{
    class msqlDAOFactory : DAOFactory 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override UsuarioDAO getUsuarioDAO()
        {
            return new SqlServerUsuarioDAO();
        }

    }
}
