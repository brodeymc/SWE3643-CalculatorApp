
namespace CalculatorEngine;

public class Calculations {
    public static void Main(string[] args)
    {
        
    }

    public String Calculate(double input1, double input2, char operation)
    {
        switch (operation)
        {
            case '+':
                return Add(input1, input2);
            case '-':
                return Subtract(input1, input2);
            case '*':
                return Multiply(input1, input2);
            case '/':
                return Divide(input1, input2);
            case '=':
                return AreEqual(input1, input2);
            case '^':
                return Power(input1, input2);
            case 'l':
                return Logarithm(input1, input2);
            case 'r':
                return Root(input1, input2);
            case '!':
                return Factorial(input1);
            case 's':
                return Sine(input1);
            case 'c':
                return Cosine(input1);
            case 't':
                return Tangent(input1);
            case 'i':
                return Reciprocal(input1);
            default:
                throw new InvalidOperationException("Unknown operation.");
        }
    }
    public static string Add(double input1, double input2)
    {
        //preq-ENGINE-3
        double result = input1 + input2;
        return $"{input1} + {input2} \n= {result}";
    }

    public static string Subtract(double input1, double input2)
    {
        //preq-ENGINE-4
        double result = input1 - input2;
        return $"{input1} - {input2} = {result}";
    }

    public static string Multiply(double input1, double input2)
    {
        //preq-ENGINE-5
        double result = input1 * input2;
        return $"{input1} * {input2} = {result}";
    }

    public static string Divide(double input1, double input2)
    {
        //preq-ENGINE-7
        if (input2 == 0)
            return "Not a Number";
        
        double result = input1 / input2;
        return $"{input1} / {input2} = {result}";
    }

    public static string AreEqual(double input1, double input2)
    {
        //preq-ENGINE-8
        double tolerance = 1e-8;
        double difference = Math.Abs(input1 - input2);
        bool result = difference < tolerance;
        return $"{input1} == {input2} = {result}";
    }

    public static string Power(double input1, double input2)
    {
        //preq-ENGINE-9
        double result = Math.Pow(input1, input2);
        return $"{input1} ^ {input2} = {result}";
    }

    public static string Logarithm(double input1, double input2)
    {
        //preq-ENGINE-10
        if (input1 <= 0 || input2 <= 0)
            return "Not a Number";
        
        double result = Math.Log(input1, input2);
        return $"log_{input2}({input1}) = {result}";
    }

    public static string Root(double input1, double input2)
    {
        //preq-ENGINE-11
        if (input2 <= 0)
            return $"{input1} root {input2} =\n Not a Number";
        
        double result = Math.Pow(input1, 1 / input2);
        return $"{input1} root {input2} = {result}";
    }
    
    public static string Factorial(double input)
    {
        //preq-ENGINE-12
        if (input < 0 || input != (int)input)
            return $"{(int)input}! =\n Not a Number"; 
            
        int factorial = 1;
        for (int i = 2; i <= (int)input; i++)
            factorial *= i;

        return $"{(int)input}! = {factorial}";
    }

    
    public static string Sine(double input)
    {
        //preq-ENGINE-13
        double result = Math.Sin(input); // Assumes radians
        return $"sin({input}) = {result}";
    }

   
    public static string Cosine(double input)
    {
        //preq-ENGINE-14
        double result = Math.Cos(input); // Assumes radians
        return $"cos({input}) = {result}";
    }

    
    public static string Tangent(double input)
    {
        //preq-ENGINE-15
        if (Math.Abs(input % Math.PI) == Math.PI / 2)
            return "Not a Number"; // Tan undefined at odd multiples of π/2
            
        double result = Math.Tan(input);
        return $"tan({input}) = {result}";
    }

    
    public static string Reciprocal(double input)
    {
        //preq-ENGINE-16
        if (input == 0)
            return "Not a Number"; 
                        
        double result = 1 / input;
        return $"1/{input} = {result}";
    }
}