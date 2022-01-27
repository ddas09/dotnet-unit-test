using System;

public class BankAccount
{
    public double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Debit(double amount)
    {
        if (amount > balance)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        balance -= amount; 
    }

    public void Credit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        balance += amount;
    }
}
