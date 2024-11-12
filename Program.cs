using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operator (+, -, *, /):");
                string ? operatorInput = Console.ReadLine();

                if (string.IsNullOrEmpty(operatorInput) || operatorInput.Length != 1)
                {
                    Console.WriteLine("Invalid operator input. Please enter a single operator (+, -, *, /).");
                    return;
                }

                char op = operatorInput[0];

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please use one of the following: +, -, *, /.");
                        return;
                }

                Console.WriteLine("The result is: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format. Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
