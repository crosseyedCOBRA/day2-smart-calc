using System.Globalization;

class Program
{
    static void Main()
    {
        while (ShowMenu())
        {

            int a = GetNumber("Enter your first number and press Enter: ");
            string op = GetOperator("Choose Operator");
            int b = GetNumber("Enter your second number and press Enter: ");

            double result = Calculate(a, b, op);

            DisplayResult(a, b, op, result);

        }
    }

    static bool ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Would you like to continue or exit the calculator? Enter 1 to continue or 2 to exit. ");

            string input = Console.ReadLine();


            if (input == "1")
            {
                return true;
            }
            else if (input == "2")
            {
                Console.WriteLine("The program has exited.");
                return false;

            }
            else
            {
                Console.WriteLine("Input Invalid. Input either 1 or 2.");
            }
        }
    }

    static int GetNumber(string message)
    {
        int num;
        Console.Write("Enter your number and press Enter:  ");
        while (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Invalid Input. Please enter a valid number.");

        }
        return num;
    }

    static string GetOperator(string message)
    {
        int action;

        while (true)
        {
            Console.WriteLine("Please enter the corresponding number to the action you want to take.");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");

            if (!int.TryParse(Console.ReadLine(), out action))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (action == 1)
            {
                return "+";
            }
            else if (action == 2)
            {
                return "-";
            }
            else if (action == 3)
            {
                return "*";
            }
            else if (action == 4)
            {
                return "/";
            }
            else
            {
                Console.WriteLine("Invalid selection. Try again.");
            }
        }
    }

    static double Calculate(int a, int b, string op)
    {
        if (op == "+")
        {
            return a + b;
        }
        else if (op == "-")
        {
            return a - b;
        }
        else if (op == "*")
        {
            return a * b;
        }
        else if (op == "/")
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot Divide by Zero.");
                return 0;
            }
            return (double)a / b;
        }
        else
        {
            Console.WriteLine("Invalid Operator.");
            return 0;
        }
    }

    static void DisplayResult(int a, int b, string op, double result)
    {
        Console.WriteLine($"{a} {op} {b} = {result}");
    }
}