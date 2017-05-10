using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Abstract_Factory.dao.PostGresql
{
    public class PstGresqlClienteDAO:ClienteDAO
    {
        public int insertCliente(dto.Cliente objBE)
        {
            throw new NotImplementedException();
        }

        public dto.Cliente findCliente(string nomber)
        {
            throw new NotImplementedException();
        }

        public bool updateCliente(string codigo)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable selectClientesRS()
        {
            throw new NotImplementedException();
        }
    }
}
