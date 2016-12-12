using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public static class Bank
    {
        #region Fields
        private static List<Account> accounts = new List<Account>();
        #endregion
        public static Account CreateAccount(string emailAddress, TypeOfAccounts accountType)
        {
            var account = new Account();
            account.AccountType = accountType;
            account.EmailAddress = emailAddress;
            accounts.Add(account);
            return account;
        }

        public static void PrintAllAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Email Address: {account.EmailAddress}, Account Type: {account.AccountType}, Balance: {account.Balance:C}");
            }
        }
    }
}
