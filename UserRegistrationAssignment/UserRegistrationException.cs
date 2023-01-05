using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationAssignment
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,INVALID_FIRSTNAME,INVALID_LASTNAME,INVALID_PHONENUMBER,INVALID_EMAIL_ADDRESS,INVALID_PASSWORD
        }
        public ExceptionType Type;
        public UserRegistrationException(ExceptionType type,string message):base(message)
        {
            this.Type=type;
        }
    }
}
