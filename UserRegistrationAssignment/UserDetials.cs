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
        public bool ValidateFirstname(string firstname)
        {
            try
            {
                if (firstname.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "FirstName should not be empty");
                }
                else
                {
                    return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
                }
            }
            catch(Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Firstname is invalid");
            }
        }
        public bool ValidateLastname(string lastname)
        {
            try
            {
                if (lastname.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "LastName should not be empty");
                }
                else
                {
                    return Regex.IsMatch(lastname, REGEX_LASTNAME);
                }
            }
            catch(Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Lastname is invalid");
            }
        }
        public bool ValidateEmailAddress(string emailAddress)
        {
            try
            {
                if (emailAddress.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "EmailAddress should not be Empty");
                }
                else
                {
                    return Regex.IsMatch(emailAddress, REGEX_EMAIL_ADDRESS);
                }
            }
            catch(Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL_ADDRESS, "EmailAddress is Invalid");
            }
        }
        public bool Validatephonenumber(string phonenumber)
        {
            try
            {
                if(phonenumber.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "PhoneNumber should not be Empty");
                }
                else
                {
                    return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
                }
            }
            catch(Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PHONENUMBER, "PhoneNumber is invalid");
            }
        }
        public bool Validatepassword(string password)
        {
            try
            {
                if(password.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_MESSAGE, "Password should not be Empty");
                }
                else
                {
                    return Regex.IsMatch(password, REGEX_PASSWORD);
                }
            }
            catch(Exception)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
            }
        }
    }
}
