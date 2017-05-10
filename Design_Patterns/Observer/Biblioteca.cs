using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Biblioteca
    {
        public List<string> devuelveLibro(Libro libro) {
            List<string> lista = new List<string>();
            if (libro.Estado.Equals("MAL")) {
                AlarmaLibro alarm = new AlarmaLibro();
                lista=alarm.notifyObservers();            
            }
            return lista;
        }
    }
}
