using System;
using NUnit.Framework;

[TestFixture]
public class CalculatorTestRefactored
{
    private readonly Calculator _calculator;

    public CalculatorTestRefactored()
    {
        _calculator = new Calculator();
    }

    [Test]
    [TestCase(10, 2, 12)]
    [TestCase(3, 5, 8)]
    public void TestAddMethod(int firstNumber, int secondNumber, int expectedResult)
    {
        int result = _calculator.Add(firstNumber, secondNumber);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase(10, 2, 8)]
    [TestCase(12, 6, 6)]
    public void TestSubstractMethod(int firstNumber, int secondNumber, int expectedResult)
    {
        int result = _calculator.Substract(firstNumber, secondNumber);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase(10, 2, 20)]
    [TestCase(3, 2, 6)]
    public void TesMultiplyMethod(int firstNumber, int secondNumber, int expectedResult)
    {
        int result = _calculator.Multiply(firstNumber, secondNumber);

        Assert.AreEqual(expectedResult, result);
    }
    
    [Test]
    [TestCase(4, 2, 2)]
    [TestCase(8, 2, 4)]
    public void TestDivideMethod(int firstNumber, int secondNumber, int expectedResult)
    {
        int result = _calculator.Divide(firstNumber, secondNumber);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase(4)]
    [TestCase(8)]
    public void TestDivideMethodThrowsExveption(int number)
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(number, 0));
    }
}