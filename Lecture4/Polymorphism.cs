using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class PaymentProcessor
    {
        // Method for processing credit card payments
        public void ProcessPayment(double amount, string cardNumber)
        {
            Console.WriteLine($"Processing credit card payment of ${amount} using card number {cardNumber}.");
        }

        // Method for processing PayPal payments
        public void ProcessPayment(double amount, string paypalEmail, string password)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount} using email {paypalEmail}.");
        }

        // Method for processing bank transfer payments
        public void ProcessPayment(double amount, string accountNumber, int bankCode)
        {
            Console.WriteLine($"Processing bank transfer payment of ${amount} to account number {accountNumber} at bank {bankCode}.");
        }
    }

    class PaymentMethod
    {
        // Virtual method to process payment (can be overridden by subclasses)
        public virtual void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} using a generic payment method.");
        }
    }

    // Derived class for CreditCard payment
    class CreditCard : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} using a credit card.");
        }
    }

    // Derived class for PayPal payment
    class PayPal : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} using PayPal.");
        }
    }

    // Derived class for BankTransfer payment
    class BankTransfer : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} via bank transfer.");
        }
    }


    // Main program to demonstrate method overloading
    class TestPoly
    {
        static void Main1(string[] args)
        {
            // Create a payment processor object
            PaymentProcessor processor = new PaymentProcessor();

            // Using overloaded methods for different payment types
            processor.ProcessPayment(100, "1234-5678-9012-3456"); // Credit card payment
            processor.ProcessPayment(200, "user@example.com", "password123"); // PayPal payment
            processor.ProcessPayment(300, "987654321", 123); // Bank transfer payment

            // Creating different payment method objects
            PaymentMethod payment;

            payment = new CreditCard();
            payment.ProcessPayment(100); // Output: Processing payment of $100 using a credit card.

            payment = new PayPal();
            payment.ProcessPayment(200); // Output: Processing payment of $200 using PayPal.

            payment = new BankTransfer();
            payment.ProcessPayment(300); // Output: Processing payment of $300 via bank transfer.
        }
    
    }

}
