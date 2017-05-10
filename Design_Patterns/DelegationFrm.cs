using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Design_Patterns.Delegation;

namespace Design_Patterns
{
    public partial class DelegationFrm : Form
    {
        public DelegationFrm()
        {
            InitializeComponent();
        }

        private void btnDelegator_Click(object sender, EventArgs e)
        {
            EmpleadoTiendaCliente delegator = new EmpleadoTiendaCliente();
            delegator.emp.Sueldo=5000;
            this.txtMensaje.Text = delegator.emp.CobrarSueldo() + Environment.NewLine + delegator.emp.Comprar() + Environment.NewLine + delegator.emp.Consultar();                       
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            EmpleadoTiendaCliente delegator = new EmpleadoTiendaCliente();
            this.txtMensaje.Text = delegator.Consultar() + Environment.NewLine + delegator.Comprar();            
           
        }
    }
}
