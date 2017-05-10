using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao
{
    public interface ClienteDAO
    {
         int insertCliente(Cliente objBE);
         Cliente findCliente(string nomber);
         bool updateCliente(string codigo);
         DataTable selectClientesRS();          
    }
}
