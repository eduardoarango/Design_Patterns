using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Administracion:ILibroEstado
    {

        public string Actualizar()
        {
            return "Administracion ==> Envio una queja formal";
        }
    }
}
