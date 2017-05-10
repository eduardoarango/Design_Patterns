using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao
{
    public interface ProductoDAO
    {
         int insertProducto(Producto objBE);
         Producto findProducto(string nomber);
         bool updateProducto(string codigo);
         DataTable selectCustomersRS();  
    }
}
