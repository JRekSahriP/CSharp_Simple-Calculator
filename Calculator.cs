using System;

namespace Program;

public class Calculator
{
    public static int num1;
    public static int num2;

    public static int process(int option)
    {
        switch (option) {
            case 1:{return addition();}
            case 2:{return subtraction();}
            case 3:{return multiplication();}
            case 4:{return division();}
            default:{
                Console.WriteLine("Option not found");
                return 0;
            }
        }
    }

    private static int addition()
    {
        return num1 + num2;
    }
    
    private static int subtraction()
    {
        return num1 - num2;
    }

    private static int multiplication()
    {
        return num1 * num2;
    }

    private static int division()
    {
        if(num2 == 0)
        {
            Console.WriteLine("Cannot divide by Zero");
            return -1;
        }
        return num1 / num2;
    }
}