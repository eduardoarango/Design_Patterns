using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Abstract_Factory.dao;
using Design_Patterns.Abstract_Factory.dao.PostGresql;

namespace Design_Patterns.Abstract_Factory
{
    public class gresqlDAOFactory: DAOFactory
    {
              
       public override UsuarioDAO getUsuarioDAO()
       {
           return new PostGresqlUsuarioDAO();
       }
       


    }
}
