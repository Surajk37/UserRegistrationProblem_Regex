namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To User Registration Problem using Regex\n");
            Console.WriteLine("Please Select option from below List");
            Console.WriteLine("\n1. Validate First Name ");
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
                default:
                    Console.WriteLine("Please Enter Valid Number");
                    break;
            }
            Console.ReadLine();
        }
    }
}