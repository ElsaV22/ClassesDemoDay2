using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciating a customer = creating a variable of the Customer data type
            Customer customer1 = new Customer();

            //getting user input
            Console.WriteLine("Please give me your first name:");
            customer1.FirstName = Console.ReadLine();

            Console.WriteLine("Please give me your last name:");
            customer1.LastName = Console.ReadLine();

            //printing customer info
            Console.WriteLine($"Hello, {customer1.FirstName} {customer1.LastName}");
            Console.WriteLine("Please enter your age:");
            customer1.Age = int.Parse(Console.ReadLine());

            if (customer1.Age < 18)
            {
                Console.WriteLine("You're too young to have a bank account.");
            }

            else
            {
                //Instanciating a checking account
                CheckingAccount checkingAccount = new CheckingAccount();

                //settting properties for the checking account
                checkingAccount.RoutingNumber = "654000457";
                checkingAccount.AccountNumber = "2541234";
                //***seting the owner proper to the instance of the customer we created
                checkingAccount.Owner = customer1;

                //printing the values of the account
                Console.WriteLine($"Your checking account number is: {checkingAccount.AccountNumber}");

                //Console.WriteLine($"The owner of the account is: {customer1.FirstName} {customer1.LastName}");
                Console.WriteLine($"The owner of the account is: {checkingAccount.Owner.FirstName} {checkingAccount.Owner.LastName}");

            }

        }
    }
}
