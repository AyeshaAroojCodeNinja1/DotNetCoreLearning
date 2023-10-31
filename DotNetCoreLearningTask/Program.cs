using DotNetCoreLearningTask;
using DotNetCoreLearningTask.Interface;

class Program
{
    static void Main(string[] args)
    {
        ICalculate calculator = null;      
        while (true)
        {
            DisplayMenu();

            if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 5)
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
            }
            else if (operation == 5)
            {
                Console.WriteLine("--- Program Terminated ---");
            }
            else if (Helper.ValidateValidInput(out int num1, "Enter the first number: ") && Helper.ValidateValidInput(out int num2, "Enter the second number: "))
            {
                try
                {
                    switch (operation)
                    {
                        case 1:
                            calculator = new Add();
                            Console.WriteLine($"Result: {calculator.Calculate(num1, num2)}");
                            break;
                        case 2:
                            calculator = new Subtract();
                            Console.WriteLine($"Result: {calculator.Calculate(num1, num2)}");
                            break;
                        case 3:
                            calculator = new Multiply();
                            Console.WriteLine($"Result: {calculator.Calculate(num1, num2)}");
                            break;
                        case 4:
                            calculator = new Divide();
                            Console.WriteLine($"Result: {calculator.Calculate(num1, num2)}");
                            break;
                            }
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }               
            }
           
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit");
        Console.Write("Please choose an option (1-5): ");
    }
}
