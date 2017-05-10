using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Design_Patterns
{
    public partial class Singletonfrm : Form
    {
        public Singletonfrm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //instanciamos el singleton
            

            this.txtMensaje.Text += string.Format(" Instancia {0} creada a las {1}",  Environment.NewLine);

        }
    }
}
