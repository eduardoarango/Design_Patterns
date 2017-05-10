using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory
{
    public interface UsuarioDAO
    {
         int insertUsuario(Usuario objBE);
         Usuario findUsuario(string nomber);
         bool updateUsuario(string codigo);
         DataTable selectUsuariosRS();  
       
    }
}
