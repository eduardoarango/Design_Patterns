using System;
using System.Collections.Generic;
using System.Text;

using Design_Patterns.Abstract_Factory.dao;
using Design_Patterns.Abstract_Factory.dao.Oracle;

namespace Design_Patterns.Abstract_Factory
{
    public class jdbcDAOFactory: DAOFactory
    {
        
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns> 
          
          public override UsuarioDAO getUsuarioDAO()
          {
              return new OracleUsuarioDAO();
          }
          

    }
}
