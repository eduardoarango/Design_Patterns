using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class Sender
    {
        public String generateEmail(IEmail email, int sentType)
        {
            String emailText = "";

            switch (sentType)
            {
                case 1:
                    EmailDecorator d1 = new ExternalEmailDecorator(email);
                    emailText = d1.getContents();
                    break;
                case 2:
                    EmailDecorator d2 = new SecureEmailDecorator(email);
                    emailText = d2.getContents();
                    break;
                default:
                    break;
                
        }

            return emailText;
        }
    }
}
