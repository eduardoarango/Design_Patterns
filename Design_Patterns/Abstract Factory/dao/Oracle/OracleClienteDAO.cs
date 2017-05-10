using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao.Oracle
{
    public class OracleClienteDAO :ClienteDAO
    {

        int ClienteDAO.insertCliente(Cliente objBE)
        {
            throw new NotImplementedException();
        }

        Cliente ClienteDAO.findCliente(string nomber)
        {
            throw new NotImplementedException();
        }

        bool ClienteDAO.updateCliente(string codigo)
        {
            throw new NotImplementedException();
        }

        DataTable ClienteDAO.selectClientesRS()
        {
            throw new NotImplementedException();
        }
    }
}
