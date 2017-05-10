using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Abstract_Factory.dao;

namespace Design_Patterns.Abstract_Factory
{
    public abstract class DAOFactory
    {
        public const int MYSQL = 1;
        public const int ORACLE = 2;
        public const int SQLSERVER = 3;
        public const int POSTGRESQL = 4;

        public abstract UsuarioDAO getUsuarioDAO();
       

        public static DAOFactory getDAOFactory(Int32 dbtype)
        {
            switch (dbtype)
            {
                case MYSQL:
                    return new mysqlDAOFactory();
                case ORACLE:
                    return new jdbcDAOFactory();
                case SQLSERVER:
                    return new msqlDAOFactory();
                case POSTGRESQL:
                    return new gresqlDAOFactory();
                default:
                    return null;
            }
        }
    }

   
    
}
