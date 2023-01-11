using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemRegex
{
    class UserRegistration
    {
        //Method to test first name
        public static bool ValidateFirstName(string firstName)
        {
            string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";   //regex pattern to get minimum 3 character at least 1 capital letter

            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }

        //Method to test Last name
        public static bool ValidateLastName(string lastName)
        {
            string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";   //regex pattern to get minimum 3 character at least 1 capital letter

            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
        //Method to test Email
        public static bool ToValidateAEmail(string email)
        {
            string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";   

            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        //To print the result
        public static void PrintResult(bool result)
        {
           if (result)
           {
             Console.WriteLine("Valid.");
           }
           else
           {
             Console.WriteLine("Invalid.");
           }
        }
    }
}
