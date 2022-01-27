using System;
using NUnit.Framework;

[TestFixture]
public class BankAccountTest
{    
    [Test]
    [TestCase(1000, 500, 500)]
    [TestCase(2000, 800, 1200)]
    public void DebitWithValidAmmountTest(double initialBalance, double debitAmmount, double expectedBalance)
    {
        BankAccount bankAccount = new BankAccount(initialBalance);

        bankAccount.Debit(debitAmmount);
        
        // Assert.True(bankAccount.balance >= 0);
        Assert.AreEqual(expectedBalance, bankAccount.balance);
    }

    [Test]
    [TestCase(1000, -500)]
    [TestCase(2000, 5000)]
    [TestCase(500, 0)]
    public void DebitWithInvalidAmmountTest(double initialBalance, double debitAmmount)
    {
        BankAccount bankAccount = new BankAccount(initialBalance);

        Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Debit(debitAmmount));
    }

    [Test]
    [TestCase(1000, 500, 1500)]
    [TestCase(1200, 800, 2000)]
    public void CreditWithValidAmmountTest(double initialBalance, double creditAmmount, double expectedBalance)
    {
        BankAccount bankAccount = new BankAccount(initialBalance);

        bankAccount.Credit(creditAmmount);

        Assert.AreEqual(expectedBalance, bankAccount.balance);
    }

    [Test]
    [TestCase(2000, -400)]
    [TestCase(500, 0)]
    public void CreditWithInvalidAmmountTest(double initialBalance, double creditAmmount)
    {
        BankAccount bankAccount = new BankAccount(initialBalance);

        Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Credit(creditAmmount));
    }
}