using CalculatorEngine;

namespace CalculatorEngineUnitTests;

public class Tests
{
    private Calculations _calculations;

    [SetUp]
    public void Setup()
    {
        _calculations = new Calculations();
    }

    [Test]
    public void Add_ValidInput_ReturnsSum()
    {
        //preq-UNIT-TEST-2

        //arrange
        double a = 2;
        double b = 3;

        //act
        var result = _calculations.Calculate(a, b, '+');

        //assert
        Assert.AreEqual("2 + 3 = 5", result);
    }

    [Test]
    public void Subtract_ValidInput_ReturnsDifference()
    {
        //preq-UNIT-TEST-3

        //arrange
        double a = 5;
        double b = 3;

        //act
        var result = _calculations.Calculate(a, b, '-');

        //assert
        Assert.AreEqual("5 - 3 = 2", result);
    }

    [Test]
    public void Multiply_ValidInput_ReturnsProduct()
    {
        //preq-UNIT-TEST-4

        //arrange
        double a = 2;
        double b = 4;

        //act
        var result = _calculations.Calculate(a, b, '*');

        //assert
        Assert.AreEqual("2 * 4 = 8", result);
    }

    [Test]
    public void Divide_ValidInput_ReturnsQuotient()
    {
        //preq-UNIT-TEST-5

        //arrange
        double a = 10;
        double b = 2;

        //act
        var result = _calculations.Calculate(a, b, '/');

        //assert
        Assert.AreEqual("10 / 2 = 5", result);
    }

    [Test]
    public void Divide_ByZero_ReturnsError()
    {
        //preq-UNIT-TEST-6

        //arrange
        double a = 10;
        double b = 0;

        //act
        var result = _calculations.Calculate(a, b, '/');

        //assert
        Assert.AreEqual("10 / 0 = Not a Number", result);
    }

    [Test]
    public void AreEqual_ValidInput_ReturnsTrue()
    {
        //preq-UNIT-TEST-7

        //arrange
        double a = 10;
        double b = 10;

        //act
        var result = _calculations.Calculate(a, b, '=');

        //assert
        Assert.AreEqual("10 == 10 = True", result);
    }

    [Test]
    public void Power_ValidInput_ReturnsResult()
    {
        //preq-UNIT-TEST-8

        //arrange
        double a = 2;
        double b = 3;

        //act
        var result = _calculations.Calculate(a, b, '^');

        //assert
        Assert.AreEqual("2 ^ 3 = 8", result);
    }

    [Test]
    public void Logarithm_ValidInput_ReturnsLog()
    {
        //preq-UNIT-TEST-9

        //arrange
        double baseNumber = 2;
        double input = 8;

        //act
        var result = _calculations.Calculate(input, baseNumber, 'l');

        //assert
        Assert.AreEqual("log_2(8) = 3", result);
    }

    [Test]
    public void Logarithm_NegativeBase_ReturnsError()
    {
        //preq-UNIT-TEST-10

        //arrange
        double baseNumber = 2;
        double input = -1;

        //act
        var result = _calculations.Calculate(input, baseNumber, 'l');

        //assert
        Assert.AreEqual("log_2(-1) = Not a Number", result);
    }

    [Test]
    public void Logarithm_ZeroBase_ReturnsError()
    {
        //preq-UNIT-TEST-11

        //arrange
        double baseNumber = 0;

        //act
        var result = _calculations.Calculate(1, baseNumber, 'l');

        //assert
        Assert.AreEqual("log_0(1) = Not a Number", result);
    }

    [Test]
    public void Root_ValidInput_ReturnsRoot()
    {
        //preq-UNIT-TEST-12

        //arrange
        double a = 8;
        double b = 3;

        //act
        var result = _calculations.Calculate(a, b, 'r');

        //assert
        Assert.AreEqual("8 root 3 = 2", result);
    }

    [Test]
    public void Root_Zero_ReturnsError()
    {
        //preq-UNIT-TEST-13

        //arrange
        double a = 8;
        double b = 0;

        //act
        var result = _calculations.Calculate(a, b, 'r');

        //assert
        Assert.AreEqual("8 root 0 = Not a Number", result);
    }

    [Test]
    public void Factorial_Positive_ReturnsFactorial()
    {
        //preq-UNIT-TEST-14

        //arrange
        double a = 5;

        //act
        var result = _calculations.Calculate(a, 0, '!');

        //assert
        Assert.AreEqual("5! = 120", result);
    }

    [Test]
    public void Factorial_Negative_ReturnsError()
    {
        //arrange
        double a = -1;

        //act
        var result = _calculations.Calculate(a, 0, '!');

        //assert
        Assert.AreEqual("-1! = Not a Number", result);
    }

    [Test]
    public void Factorial_Convention_ReturnsFactorial()
    {
        //preq-UNIT-TEST-15

        //arrange
        double a = 0;

        //act
        var result = _calculations.Calculate(a, 0, '!');

        //assert
        Assert.AreEqual("0! = 1", result);
    }

    [Test]
    public void Sine_ValidInput_ReturnsSin()
    {
        //preq-UNIT-TEST-16

        //arrange
        double a = 360;

        //act
        var result = _calculations.Calculate(a, 0, 's');

        //assert
        Assert.AreEqual("sin(360) = 0", result);
    }

    [Test]
    public void Cosine_ValidInput_ReturnsCos()
    {
        //preq-UNIT-TEST-17

        //arrange
        double a = 360;

        //act
        var result = _calculations.Calculate(a, 0, 'c');

        //assert
        Assert.AreEqual("cos(360) = 1", result);
    }

    [Test]
    public void Tangent_ValidInput_ReturnsTan()
    {
        //preq-UNIT-TEST-18

        //arrange
        double a = 360;

        //act
        var result = _calculations.Calculate(a, 0, 't');

        //assert
        Assert.AreEqual("tan(360) = 0", result);
    }

    [Test]
    public void Tangent_OddMultipleOfPiOver2_ReturnsNaN()
    {
        //arrange
        double a = Math.PI / 2;

        //act
        var result = _calculations.Calculate(a, 0, 't');

        //assert
        Assert.AreEqual($"tan({a}) = Not a Number", result);
    }

    [Test]
    public void Reciprocal_ValidInput_ReturnsReciprocal()
    {
        //preq-UNIT-TEST-19

        //arrange
        double a = 8;

        //act
        var result = _calculations.Calculate(a, 0, 'i');

        //assert
        Assert.AreEqual("1/8 = 0.125", result);
    }

    [Test]
    public void Reciprocal_Zero_ReturnsError()
    {
        //preq-UNIT-TEST-20

        //arrange
        double a = 0;

        //act
        var result = _calculations.Calculate(a, 0, 'i');

        //assert
        Assert.AreEqual("1/0 = Not a Number", result);
    }
    
    [Test]
    public void Calculate_InvalidOperation_ReturnsError()
    {
        //arrange
        double a = 0;

        //act
        var result = _calculations.Calculate(a, 0, 'h');

        //assert
        Assert.AreEqual("Unknown operation.", result);
    }
}