using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class ExternalEmailDecorator:EmailDecorator
    {
        private String content;
        public ExternalEmailDecorator(IEmail basicEmail)
        {
            originalEmail = basicEmail;
        }

 
    public String getContents()
        {
            content = addDisclaimer(originalEmail.getContents());
            return content;
        }

        private String addDisclaimer(String message)
        {
            return message + "\n Disclaimer";
        }

    }
}
