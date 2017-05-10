using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorator
{
    public abstract class EmailDecorator :IEmail
    {
       public IEmail originalEmail;

        public string getContents()
        {
            return originalEmail.getContents();
        }
    }

}
