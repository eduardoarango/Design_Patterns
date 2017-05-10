using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Builder
{
    public abstract class GenerarInformeBuilder
    {
        protected Informe info;
        public Informe GetInforme() {
            return info;
        }

        public abstract void DefinirStyle();
        public abstract void ConstruirHeader();
        public abstract void Construirheader2();
        public abstract void Construirheader3();
        public abstract void ConstruirCuerpo();
        public abstract void Construirfooter();
        
    }
}
