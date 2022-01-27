using System;
using NUnit.Framework;

[TestFixture]
public class BankAccountTestRefactored
{   
    private BankAccount _bankAccount;

    # region DSL
    private void CreateBankAccountWithInitialBalance(double initialBalance)
    {
        _bankAccount = new BankAccount(initialBalance);
    } 

    private void CreditMoneyToBankAccount(double creditAmmount)
    {
        _bankAccount.Credit(creditAmmount);
    }

    private void DebitMoneyFromBankAccount(double debitAmmount)
    {
        _bankAccount.Debit(debitAmmount);
    }

    private void CheckIfAccountHasExpectedBalance(double expectedBalance)
    {
        Assert.AreEqual(expectedBalance, _bankAccount.balance);
    }

    
    private void CheckIfCreditFailsWithInvalidAmmount(double creditAmmount)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Credit(creditAmmount));
    }

    private void CheckIfDebitFailsWithInvalidAmmount(double debitAmmount)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Debit(debitAmmount));
    }
    # endregion

    [Test]
    [TestCase(1000, 500, 500)]
    [TestCase(2000, 800, 1200)]
    public void DebitWithValidAmmountTest(double initialBalance, double debitAmmount, double expectedBalance)
    {
        CreateBankAccountWithInitialBalance(initialBalance);

        DebitMoneyFromBankAccount(debitAmmount);

        CheckIfAccountHasExpectedBalance(expectedBalance);
    }

    [Test]
    [TestCase(1000, -500)]
    [TestCase(2000, 5000)]
    [TestCase(500, 0)]
    public void DebitWithInvalidAmmountTest(double initialBalance, double debitAmmount)
    {
        CreateBankAccountWithInitialBalance(initialBalance);

        CheckIfDebitFailsWithInvalidAmmount(debitAmmount);
    }

    [Test]
    [TestCase(1000, 500, 1500)]
    [TestCase(1200, 800, 2000)]
    public void CreditWithValidAmmountTest(double initialBalance, double creditAmmount, double expectedBalance)
    {
        CreateBankAccountWithInitialBalance(initialBalance);

        CreditMoneyToBankAccount(creditAmmount);
        
        CheckIfAccountHasExpectedBalance(expectedBalance);
    }

    [Test]
    [TestCase(2000, -400)]
    [TestCase(500, 0)]
    public void CreditWithInvalidAmmountTest(double initialBalance, double creditAmmount)
    {
        CreateBankAccountWithInitialBalance(initialBalance);

        CheckIfCreditFailsWithInvalidAmmount(creditAmmount);
    }
}