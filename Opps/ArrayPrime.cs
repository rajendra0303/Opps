using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    using System;

    class ArrayPrime
    {
        static void Main()
        {
            int[] numbers = { 91,92,17,94,95,19,97,13,99 };

            Console.WriteLine("Given Array is :");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("  "+numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Prime numbers in the array are:");
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.Write("  "+number);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
