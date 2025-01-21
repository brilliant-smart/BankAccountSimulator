using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Simulator
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }
        private List<string> _transactionHistory;


        //constructor
        public BankAccount(int accountNumber, string accountName, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = initialBalance;
            _transactionHistory = new List<string>();
        }

        //methods

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;

                _transactionHistory.Add($"₦{amount} Deposited Successfully");

                Console.WriteLine($"₦{amount} successfully deposited");
            }
            else
            {
                Console.WriteLine("Deposite amount must be positive");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= AccountBalance)
            {
                AccountBalance -= amount;

                _transactionHistory.Add($"₦{amount} Withdrawn successfully");

                Console.WriteLine($"₦{amount} is withdrawn successfully");
            }
            else if(amount > AccountBalance)
            {
                Console.WriteLine("Insufficient Fund");
            }
            else
            {
                Console.WriteLine("Please enter a valid amount that is greater than zero");
            }
        }

        public decimal GetBalance()
        {
            return AccountBalance;

        }

        public void GetTransactionHistory()
        {
            foreach (var transaction in _transactionHistory)
            {
                Console.Write(transaction);
            }
        }

    }
}