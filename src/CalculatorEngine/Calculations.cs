public class Calculations {
    public static void Main(string[] args)
    {
        
    }

    public static float Calculate(float input1, float input2, char operation)
    {
        switch (operation)
        {
            case '+':
                return input1 + input2;
            case  '-':
                return input1 - input2;
            case '*':
                return input1 * input2;
            case '/':
                return input1 / input2;
            case '=':
                if (input1 == input2)
                {
                    return 1;
                }
                else return 0;
            case '^':
                return (float)Math.Pow(input1, input2);
            case 'l':
                return (float)Math.Log(input1, input2);
            case 'r':
                return (float)Math.Pow(input1, 1 / input2);
        }
        
        
        return 0;
    }
}

