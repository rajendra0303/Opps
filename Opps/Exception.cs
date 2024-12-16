using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class Exception1
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                char operation = Convert.ToChar(Console.ReadLine());

                int result ;

                switch (operation)
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
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Overflow occurred.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format.");
            }
           
        }
    }
}
