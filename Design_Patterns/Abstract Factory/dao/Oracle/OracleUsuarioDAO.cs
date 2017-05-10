using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Abstract_Factory.dto;
using System.Data;

namespace Design_Patterns.Abstract_Factory.dao.Oracle
{
    public class OracleUsuarioDAO:UsuarioDAO
    {
        public OracleUsuarioDAO() { }
        public int insertUsuario(Usuario objBE)
        {
            return 1;
        }
        public Usuario findUsuario(string nomber)
        {
            Usuario objBE = new Usuario();
            objBE.Codigo = 1;
            objBE.Nombres ="Felipe Luis";
            objBE.APellido = "Sanchez";
            objBE.Mensaje = "Datos optenido de Oracle data base";
            return objBE;
        }
        public bool updateUsuario(string codigo)
        {
            return true;
        }
        public DataTable selectUsuariosRS()
        {
            return null;
        }
    }
}
