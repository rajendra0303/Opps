using System;

namespace Opps

{
    // Define custom exception class
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Negative number entered. Please enter a positive integer.") { }
    }

    class CustomExc
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive integer: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new NegativeNumberException();
                }
                Console.WriteLine($"You entered a positive integer: {num}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}
