using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Observer
{
    public interface Subject
    {
        void attach(ILibroEstado observador);
        void dettach(ILibroEstado observador);
        List<string> notifyObservers();
    }
} 
