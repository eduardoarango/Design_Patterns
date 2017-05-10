using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class Email : IEmail
    {
        private String content;
        public Email(String content)
        {
            this.content = content;
        }
        public string getContents()
        {
            return content;
        }
    }
}
