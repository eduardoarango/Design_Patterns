using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Design_Patterns.Observer;

namespace Design_Patterns
{
    public partial class ObserverFrm : Form
    {
        public ObserverFrm()
        {
            InitializeComponent();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AlarmaLibro alarm = new AlarmaLibro();
            alarm.attach(new Compras());
            alarm.attach(new Administracion());
            alarm.attach(new Stock());
            Libro libro = new Libro();
            libro.Estado = "MAL";

            Biblioteca biblio=new Biblioteca();
            List<string> lista = new List<string>();
            lista=biblio.devuelveLibro(libro);
            foreach (var item in lista)
            {
                this.textBox1.Text += item;
                
            }

        }
    }
}
