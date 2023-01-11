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
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";   //regex pattern to get minimum 3 character at least 1 capital letter

           //Method to test first name
        public static bool ValidateFirstName(string firstName)
        {
           return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
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
