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
        //Regular Expression For PassWord Validation
        public static string REGEX_PASSWORD = "(?=.*?[A-Z])(?=.*?[a-z])(?=.*[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

        public bool ValidateFirstName(List<string> firstName)
        {
            try
            {
                Regex pattern = new Regex(REGEX_FIRSTNAME);
                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Name should not be empty");
                }
                bool result = firstName.Any(str => pattern.IsMatch(str));
                return result;
            }
            catch (Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "FirstName is Invalid");
            }
        }
        public bool ValidateLastName(List<string> lastName)
        {
            try
            {
                Regex pattern = new Regex(REGEX_FIRSTNAME);
                if (lastName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Name should not be empty");
                }
                bool result = lastName.Any(str => pattern.IsMatch(str));
                return result;
            }
            catch (Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "LastName is Invalid");
            }
        }
        public bool ValidateEmailAddress(List<string> email)
        {
            try
            {
                Regex pattern = new Regex(REGEX_EMAIL_ADDRESS);
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                bool result = email.Any(str => pattern.IsMatch(str));
                return result;
            }
            catch (Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL_ADDRESS, "EMail is Invalid");
            }

        }

        public bool ValidatePhoneNumber(List<string> mobile)
        {
            try
            {
                Regex pattern = new Regex(REGEX_PHONENUMBER);
                if (mobile.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "mobile number should not be empty");
                }
                bool result = mobile.Any(str => pattern.IsMatch(str));
                return result;
            }
            catch (Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PHONENUMBER, "Mobile number is Invalid");
            }
        }

        public bool ValidatePassword(List<string> password)
        {
            try
            {
                Regex pattern = new Regex(REGEX_PASSWORD);
                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "password should not be empty");
                }
                bool result = password.Any(str => pattern.IsMatch(str));
                return result;
            }
            catch (Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Passoword is Invalid");
            }
        }
    }
}
