using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Delegation
{
    public class EmpleadoTiendaCliente :Cliente
    {
        public Empleado emp;        
        public EmpleadoTiendaCliente() {
            emp = new Empleado();
        }

        

        /*
       public InterfaceDlgt getIntance(Int32 dbtype)
        {
            switch (dbtype)
            {
                case 1:
                    return new Cliente();
                case 2:
                    return new Empleado();                
                default:
                    return null;
            }
        }*/        
    }
}
