using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Proxy
{
    public class GuardarDatos:IGuardar
    {

        public string Guardar(List<string> datosGuardar)
        {
            if (ConnectionManager.HayConexion())
            {
               return new GuardarDiscoExterno().Guardar(datosGuardar);
            }
            else {
                return new GuardarDiscoDuro().Guardar(datosGuardar);
            }
        }
    }
}
