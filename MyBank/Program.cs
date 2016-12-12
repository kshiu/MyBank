using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Welcome to my bank!");
            var choice = "-1";
            while (choice != "0")
            {
                Console.WriteLine("Please select from the list of choices below: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all accounts");
                choice = Console.ReadLine(); //accepts input from user
                switch (choice)  //switch tab tab 
                {
                    case "0":
                        Console.WriteLine("Have a great day!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        var myAccount = Bank.CreateAccount(emailAddress, TypeOfAccounts.Checking);
                        //instantiating a class[a new Account]
                        //var checkingAccount = new Account();
                        //no longer able to use this line bc you should not be able to set AccountNumber -> checkingAccount.AccountNumber = 123;
                        //checkingAccount.EmailAddress = emailAddress;
                        //checkingAccount.AccountType = TypeOfAccounts.Checking; //enum list of options
                        // checkingAccount.Deposit(1002.50M); //use 'M' to specify decimal. M stands for Money
                        Console.WriteLine($"Account number: {myAccount.AccountNumber}, Balance: {myAccount.Balance:C}"); //C stands for currency
                        break;
                    case "2":
                        break;
                    case "4":
                        Bank.PrintAllAccounts();
                        break;
                    default:
                        break;
                }
            }

            /* var savingsAccount = new Account();
            savingsAccount.EmailAddress = "test2@test.com";
            savingsAccount.AccountType = TypeOfAccounts.Savings;
            savingsAccount.Deposit(200M);
            Console.WriteLine($"Account number: {savingsAccount.AccountNumber}, Balance: {savingsAccount.Balance:C}");
            */
        }
    }
}
