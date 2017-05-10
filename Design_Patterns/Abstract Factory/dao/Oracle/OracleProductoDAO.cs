using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao.Oracle
{
    public class OracleProductoDAO:ProductoDAO
    {

        public int insertProducto(Producto objBE)
        {
            throw new NotImplementedException();
        }

        public Producto findProducto(string nomber)
        {
            throw new NotImplementedException();
        }

        public bool updateProducto(string codigo)
        {
            throw new NotImplementedException();
        }

        public DataTable selectCustomersRS()
        {
            throw new NotImplementedException();
        }
    }
}
