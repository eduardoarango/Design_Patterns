using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Design_Patterns
{
    public partial class MainPrincipal : Form
    {
        private int childFormNumber = 0;

        public MainPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            AbstractFactory childForm = new AbstractFactory();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            AbrirVentana(childForm.GetType());
        }

       
        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void singletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singletonfrm childForm = new Singletonfrm();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            AbrirVentana(childForm.GetType());
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decoratorform childForm = new Decoratorform();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            AbrirVentana(childForm.GetType());
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObserverFrm childForm = new ObserverFrm();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            AbrirVentana(childForm.GetType());
        }

        private void facadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacadeForm childForm = new FacadeForm();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            AbrirVentana(childForm.GetType());
        }


        public Hashtable instancias = new Hashtable();

        public Form AbrirVentana(Type tipo)
        {
            return AbrirVentana(tipo.FullName);
        }

        public Form AbrirVentana(string tipo)
        {
            try
            {
                Form formulario = instancias[tipo] as Form; // Recuperar la instancia, si existe
                if (formulario == null || formulario.IsDisposed)
                {
                    // Usar Reflection para crear una instancia
                    formulario = (Form)Activator.CreateInstance(null, tipo).Unwrap();
                    instancias[tipo] = formulario;
                }
                if (this.IsMdiContainer)
                    formulario.MdiParent = this;

                formulario.Activate();
                formulario.WindowState = FormWindowState.Normal;
                formulario.Show();
                return formulario;
            }
            catch (Exception ex)
            {
                // Procesar el error
                throw ex; // return null;
            }
        }


    }
}
