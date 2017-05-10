using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Delegation
{
    public class Empleado 
    {
        public double Sueldo { get ;set;}

        public string CobrarSueldo() {
            return "He Cobrado mi Sueldo " + Sueldo;
        }
        public string Consultar()
        {
            return "Empleado da información";
        }       

        public string Comprar()
        {
            return "Empleado Comprar artículo a un precio especial";
        }
    }
}
