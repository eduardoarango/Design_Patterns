using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Proxy
{
    public class GuardarDiscoExterno:IGuardar
    {

        public string Guardar(List<string> datosGuardar)
        {
            return "Guardando Datos en Disco Externo....";
        }

    }
}
