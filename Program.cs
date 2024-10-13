using System;

namespace Program;

public class Program
{
    public static void Main(String[] args)
    {
        int exit = 0;
        do
        {
            setNumbers();
            
            int result = Calculator.process(getOption());
            Console.WriteLine("Result: " + result);
            Console.WriteLine();

            Console.WriteLine("Exit?");
            Console.WriteLine("[0] : No");
            Console.WriteLine("[1] : Yes");
            exit = getNumberFromUser();
            Console.WriteLine();
        } while(exit == 0);

        Console.ReadKey();
    }


    private static void setNumbers()
    {
        Calculator.num1 = getNumberFromUser("Choose the first number: ");
        Calculator.num2 = getNumberFromUser("Choose the second number: ");
    } 

    private static int getOption()
    {
        int option;

        do
        {
            Console.WriteLine("Choose the operator");
            Console.WriteLine("[1] : +");
            Console.WriteLine("[2] : -");
            Console.WriteLine("[3] : *");
            Console.WriteLine("[4] : /");
            option = getNumberFromUser();
        } while(option < 1 || option > 4);

        return option;
    }
    private static int getNumberFromUser() => getNumberFromUser("");
    private static int getNumberFromUser(String message)
    {
        while(true)
        {
            Console.Write(message);
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                return number;
            } 
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

}
