using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class arrayMinMax
    {

        static void Main()
        {
            int[] array = { 50, 30, 80, 10, 40 };
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("  "+ array[i]);
            }
            Console.WriteLine();

            Console.WriteLine();

            //maximum value of array
            int maxValue = array.Max();
            Console.WriteLine("Maximum Values of Array :" + maxValue);

            Console.WriteLine();
            //Minimum value of array
            int minValue = array.Min();
            Console.WriteLine("Minimum  value of array :" + minValue);

        }
    }
}
