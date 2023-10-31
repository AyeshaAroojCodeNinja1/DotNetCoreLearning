using DotNetCoreLearningTask;
using DotNetCoreLearningTask.Interface;

class Program
{
    static void Main(string[] args)
    {
        ICalculate calculator = null;      
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int operation))
            {
                if (operation >= 1 && operation <= 4)
                {
                    Console.Write("Enter the first number: ");
                    if (int.TryParse(Console.ReadLine(), out int num1))
                    {
                        Console.Write("Enter the second number: ");
                        if (int.TryParse(Console.ReadLine(), out int num2))
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
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                else if (operation == 5)
                {
                    Console.WriteLine("--- Program Terminated ---");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
            }
        }
    }
}
