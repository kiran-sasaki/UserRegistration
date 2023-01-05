using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationAssignment
{
    public class UserDetials
    {
        //Regular Expression For FirstName Validation
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFirstname(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);

        }
    }
}
