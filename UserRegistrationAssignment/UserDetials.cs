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
        //Regular Expression For LastName Validation
        public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        //Regular Expression For Email Validation
        public static string REGEX_EMAIL_ADDRESS = "^[A-Za-z0-9]([-_+.]{0,1}[A-Za-z0-9])*[@]${1}[A-Za-z0-9]{1,}[.]{1}[A-Za-z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}";
        public bool ValidateFirstname(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);

        }
        public bool ValidateLastname(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_LASTNAME);
        }
        public bool validateEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, REGEX_EMAIL_ADDRESS);
        }
    }
}
