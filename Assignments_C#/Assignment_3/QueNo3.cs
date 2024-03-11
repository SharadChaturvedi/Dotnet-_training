using System;

 
public class Account
{
    private double balance;

    public Account(double initialBalance)
    {
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit successful. Current balance: " + balance);
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }
        balance -= amount;
        Console.WriteLine("Withdrawal successful. Current balance: " + balance);
    }
}

class ExceptionHandling
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Account account = new Account(initialBalance);

            Console.Write("Enter amount to deposit: ");
            double depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);
            Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            
        }
    }
}