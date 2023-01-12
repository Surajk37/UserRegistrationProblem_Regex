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
            string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";   //regex patern

            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        //Method to test Mobile Format
        public static bool ToValidateMobileNumber(string mobile)
        {
            string REGEX_Mobile = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";

            return Regex.IsMatch(mobile, REGEX_Mobile);
        }

        //Method to test Password
        public static bool ValidatePassword(string password)
        {
            //string REGEX_PASSWORD = "^[a-zA-Z0-9]{8,}$";   //rule number 1 applied minimum 8 character
            string REGEX_PASSWORD = "^[A-Z]{1,}[a-zA-Z0-9]{7,}$";   //rule number 2 applied minimum 8 character at least 1 uper case

            return Regex.IsMatch(password , REGEX_PASSWORD);
        }

        //To print the result
        public static void PrintResult(bool result)
        {
           if (result)
           {
             Console.WriteLine(" Valid Input");
           }
           else
           {
             Console.WriteLine(" Invalid Input ");
           }
        }
    }
}
