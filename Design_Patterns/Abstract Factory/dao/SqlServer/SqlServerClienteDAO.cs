using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao.SqlServer
{
    public class SqlServerClienteDAO:ClienteDAO
    {

        public int insertCliente(Cliente objBE)
        {
            throw new NotImplementedException();
        }

        public Cliente findCliente(string nomber)
        {
            throw new NotImplementedException();
        }

        public bool updateCliente(string codigo)
        {
            throw new NotImplementedException();
        }

        public DataTable selectClientesRS()
        {
            throw new NotImplementedException();
        }
    }
}
