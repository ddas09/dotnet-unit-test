using System;
using NUnit.Framework;

[TestFixture]
public class CalculatorTest
{
    [Test]
    public void TestAddMethod()
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Add(2, 3);
        int result2 = calculator.Add(2, 9);

        Assert.AreEqual(5, result1);
        Assert.AreEqual(11, result2);
    }

    [Test]
    public void TestSubstractMethod()
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Substract(4, 3);
        int result2 = calculator.Substract(6, 3);

        Assert.AreEqual(1, result1);
        Assert.AreEqual(3, result2);
    }

    [Test]
    public void TesMultiplyMethod()
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Multiply(2, 3);
        int result2 = calculator.Multiply(2, 9);

        Assert.AreEqual(6, result1);
        Assert.AreEqual(18, result2);
    }
    
    [Test]
    public void TestDivideMethod()
    {
        Calculator calculator = new Calculator();

        int result1 = calculator.Divide(12, 3);

        Assert.AreEqual(4, result1);
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(2, 0));
    }
}