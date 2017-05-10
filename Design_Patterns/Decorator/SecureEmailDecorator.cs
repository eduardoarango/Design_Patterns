using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorator
{
    public class SecureEmailDecorator: EmailDecorator
    {
        private String content;

        public SecureEmailDecorator(IEmail basicEmail)
        {
            originalEmail = basicEmail;
        }

        
    public String getContents()
        {
            content = encrypt(originalEmail.getContents());
            return content;
        }

        private String encrypt(String message)
        {
            string encryptedMessage = "";
            return encryptedMessage;
        }
    }
}
