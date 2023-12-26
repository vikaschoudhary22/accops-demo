using System;

namespace assignment3
{
    class BankAccount
    {
        // Private fields
        private double balance;
        private string accountNumber;

        // Constructor
        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        // Property for account number (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Property for balance (read-only)
        public double Balance
        {
            get { return balance; }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a BankAccount object
            BankAccount myAccount = new BankAccount("123456789");

            // Display initial balance
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

            // Deposit and withdraw money
            myAccount.Deposit(1000);
            myAccount.Withdraw(500);
            myAccount.Withdraw(800);

            // Display final balance
            Console.WriteLine($"Final Balance: ${myAccount.Balance}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}