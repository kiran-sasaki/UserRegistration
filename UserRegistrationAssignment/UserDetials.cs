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
        public static string REGEX_EMAIL_ADDRESS = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        //Regular Expression For PhoneNumber Validation
        public static string REGEX_PHONENUMBER = "^[9]{1}[1]{1}\\s[0-9]{10}$";
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
        public bool validatephonenumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
    }
}
