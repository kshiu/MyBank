using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*multiple lines of comments
 *
*/

//single line comment
namespace MyBank
{
    public enum TypeOfAccounts
    {
        Checking,
        Savings,
    }
    /// <summary>
    /// This class describes a bank account
    /// This is an xml comment style
    /// </summary>
    public class Account
    {
        #region Statics
            private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Account number of the account
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Email address of the user
        /// </summary>
        public string EmailAddress { get; set; }
        public decimal Balance { get;
            private set; }
        public TypeOfAccounts AccountType { get; set; }  //only want 2 options to be given (Checking and Savings accounts)
        #endregion

        #region Constructors
        public Account()
        {
            //lastAccountNumber += 1;
            //AccountNumber = lastAcccountNumber; 
            AccountNumber = ++lastAccountNumber;   //This is a post increment operator vs the preincrement of lastAccountNumber++
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns>The updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            return Balance;
        }
        #endregion
    }
}
