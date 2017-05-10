using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public class AlarmaLibro:Subject
    {
        private static List<ILibroEstado> observadores = new List<ILibroEstado>();

        public void attach(ILibroEstado observado)
        {
            observadores.Add(observado);
        }
        public void dettach(ILibroEstado observado)
        {
            observadores.Add(observado);
        }
        public List<string> notifyObservers()
        {
            List<string> listado=new List<string>();
            foreach (var item in observadores)
            {
                item.Actualizar();
                listado.Add(item.Actualizar()+Environment.NewLine);
            }
            return listado;
        }
    }
}

