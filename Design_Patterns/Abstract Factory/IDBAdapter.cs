using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace Design_Patterns.Abstract_Factory
{
    interface IDBAdapter
    {
        /*clase que implementa la conxion a base de datos*/
        object obj= Singleton.dbConexionSingleto;
    }
}
