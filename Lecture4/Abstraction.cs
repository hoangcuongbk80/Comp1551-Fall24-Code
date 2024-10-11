using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class BankAccount
    {
        // Private attribute: The balance is hidden from the outside world
        private double balance;

        // Constructor to initialize the account with a balance
        public BankAccount(double initialBalance)
        {
            if (initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else
            {
                balance = 0;
            }
        }

        // Public method to deposit money (abstracted interaction)
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Public method to withdraw money (abstracted interaction)
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. Remaining balance: ${balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        // Public method to check the current balance (abstracted interaction)
        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }
    }

    // Main method to demonstrate abstraction
    class TeskBAnkAccount
    {
        static void Main1(string[] args)
        {
            // Creating a bank account with an initial balance of $500
            BankAccount myAccount = new BankAccount(500);

            // Abstracted interactions: Deposit, Withdraw, and CheckBalance
            myAccount.CheckBalance();  // Output: Your current balance is: $500
            myAccount.Deposit(150);    // Output: Successfully deposited $150. New balance: $650
            myAccount.Withdraw(100);   // Output: Successfully withdrew $100. Remaining balance: $550
            myAccount.CheckBalance();  // Output: Your current balance is: $550
        }
    }

}
