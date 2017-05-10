using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Design_Patterns.Abstract_Factory;
using Design_Patterns.Abstract_Factory.dto;

namespace Design_Patterns
{
    public partial class AbstractFactory : Form
    {
        public AbstractFactory()
        {
            InitializeComponent();

            DataTable dtCombo = new DataTable();
            dtCombo.Clear();
            dtCombo.Columns.Add("codigo");
            dtCombo.Columns.Add("tipo");
            DataRow _ravi = dtCombo.NewRow();
            _ravi["codigo"] = "0";
            _ravi["tipo"] = "Elegir Base de Datos";
            dtCombo.Rows.Add(_ravi);

            _ravi = dtCombo.NewRow();
            _ravi["codigo"] = "1";
            _ravi["tipo"] = "MYSQL";
            dtCombo.Rows.Add(_ravi);

            _ravi = dtCombo.NewRow();
            _ravi["codigo"] = "2";
            _ravi["tipo"] = "ORACLE";
            dtCombo.Rows.Add(_ravi);
            _ravi = dtCombo.NewRow();
            _ravi["codigo"] = "3";
            _ravi["tipo"] = "SQLSERVER";
            dtCombo.Rows.Add(_ravi);
            _ravi = dtCombo.NewRow();
            _ravi["codigo"] = "4";
            _ravi["tipo"] = "POSTGRESQL";
            dtCombo.Rows.Add(_ravi);
            
            this.ddlTpoDataBase.DataSource = dtCombo;
            this.ddlTpoDataBase.DisplayMember = "tipo";
            this.ddlTpoDataBase.ValueMember = "codigo";


        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {/*
            string codigo = this.ddlTpoDataBase.SelectedValue.ToString();

            DAOFactory cloudscapeFactory = DAOFactory.getDAOFactory(Convert.ToInt32(codigo));
            UsuarioDAO UsuDAO = cloudscapeFactory.getUsuarioDAO();
            Usuario objBE = new Usuario();

            objBE = UsuDAO.findUsuario("");

            this.txtCodigo.Text = objBE.Codigo.ToString();
            this.txtNombres.Text = objBE.Nombres;
            this.txtAPellidos.Text = objBE.APellido;
            this.txtMensaje.Text = objBE.Mensaje;
            */

        }

        private void ddlTpoDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = this.ddlTpoDataBase.SelectedIndex.ToString();
            if (Convert.ToInt32(codigo) > 0)
            {
                DAOFactory cloudscapeFactory = DAOFactory.getDAOFactory(Convert.ToInt32(codigo));
                UsuarioDAO UsuDAO = cloudscapeFactory.getUsuarioDAO();
                Usuario objBE = new Usuario();

                objBE = UsuDAO.findUsuario("");

                this.txtCodigo.Text = objBE.Codigo.ToString();
                this.txtNombres.Text = objBE.Nombres;
                this.txtAPellidos.Text = objBE.APellido;
                this.txtMensaje.Text = objBE.Mensaje;
            }
        }

        private void ddlTpoDataBase_SelectedValueChanged(object sender, EventArgs e)
        {
           /* string codigo = this.ddlTpoDataBase.SelectedValue.ToString();
            if (codigo != null)
            {
                DAOFactory cloudscapeFactory = DAOFactory.getDAOFactory(Convert.ToInt32(codigo));
                UsuarioDAO UsuDAO = cloudscapeFactory.getUsuarioDAO();
                Usuario objBE = new Usuario();

                objBE = UsuDAO.findUsuario("");

                this.txtCodigo.Text = objBE.Codigo.ToString();
                this.txtNombres.Text = objBE.Nombres;
                this.txtAPellidos.Text = objBE.APellido;
                this.txtMensaje.Text = objBE.Mensaje;
            }*/
        }
    }
}
