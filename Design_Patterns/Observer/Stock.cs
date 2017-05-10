using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Stock:ILibroEstado
    {
        public string Actualizar()
        {
            return "Stock ==> Le doy de Baja";
        }


    }
}
