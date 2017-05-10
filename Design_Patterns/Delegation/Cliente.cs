using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Delegation
{
    public class Cliente 
    {
        public string codigo { get; set; }
        public string Nombre { get;set;}
        public string Documento { get;set;}
        public string Direccion { get; set; }

        public string Consultar()
        {
            return "CLiente Consulta Precios";
        }        
        public string Comprar()
        {
            return "Cliente Compra Articulos";
        }
    }
}
