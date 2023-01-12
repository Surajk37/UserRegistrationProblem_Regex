namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To User Registration Problem using Regex\n");
            Console.WriteLine("Please Select option from below List");
            Console.WriteLine("\n1. Validate First Name \n2. Validate Last Name \n3. To Validate Email \n4. Mobile Number Format Validate \n5. Validate Password");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\t  Enter First Name");
                    Console.WriteLine("\t--------------------");
                    string firstName = Console.ReadLine();
                    bool firstNameResult = UserRegistration.ValidateFirstName(firstName);
                    UserRegistration.PrintResult(firstNameResult);
                    break;
                case 2:
                    Console.WriteLine("\t  Enter Last Name");
                    Console.WriteLine("\t--------------------");
                    string LastName = Console.ReadLine();
                    bool lastNameResult = UserRegistration.ValidateLastName(LastName);
                    UserRegistration.PrintResult(lastNameResult);
                    break;
                case 3:
                    Console.WriteLine("\t  Enter Email Address ");
                    Console.WriteLine("\t--------------------");
                    string Email = Console.ReadLine();
                    bool emailResult = UserRegistration.ToValidateAEmail(Email);
                    UserRegistration.PrintResult(emailResult);
                    break;
                case 4:
                    Console.WriteLine("\t  Enter Mobile Number ");
                    Console.WriteLine("\t--------------------");
                    string Mobile = Console.ReadLine();
                    bool mobileResult = UserRegistration.ToValidateMobileNumber(Mobile);
                    UserRegistration.PrintResult(mobileResult);
                    break;
                case 5:
                    Console.WriteLine("\t  Enter Password ");
                    Console.WriteLine("\t--------------------");
                    string Password = Console.ReadLine();
                    bool passwordResult3 = UserRegistration.ValidatePassword(Password);
                    UserRegistration.PrintResult(passwordResult3);
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Number");
                    break;
            }
              Console.ReadLine();
        }
    }
}