class BankAccount
{
    private string accountNumber;
    private double balance;

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        balance = initialBalance;
    }

    // Method to deposit money (public)
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money (public)
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Method to get the balance (public)
    public double GetBalance()
    {
        return balance;
    }
}

// Main method to demonstrate access modifiers
class TestBankAccount
{
    static void Main1(string[] args)
    {
        BankAccount myAccount = new BankAccount("12345ABC", 1000);

        // Deposit and withdraw money
        myAccount.Deposit(200); // Output: Successfully deposited 200. New balance: 1200
        myAccount.Withdraw(300); // Output: Successfully withdrew 300. Remaining balance: 900

        // Trying to access balance directly (not allowed)
        // myAccount.balance = 500; // This line will cause a compilation error due to 'private' access

        // Correct way to get the balance
        Console.WriteLine($"Current balance: {myAccount.GetBalance()}"); // Output: Current balance: 900
    }
}
