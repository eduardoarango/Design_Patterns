using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Compras:ILibroEstado
    {
        public string Actualizar()
        {
            return "Compras ==> Solicito Nueva Cotización";
        }

    }
}
