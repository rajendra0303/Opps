using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class EvenOddArray
    {

        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            for (int j = 0; j < a.Length; j++)
            {


                Console.Write(a[j]);

                Console.WriteLine();
            }
            //Even Number
            Console.WriteLine("Even Number is :");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write("  " + a[i]);
                }
            }

            Console.WriteLine();


            //Odd Number

            Console.WriteLine("Odd Number is :");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write("  " + a[i]);

                }
            }

            Console.WriteLine();
        }

    }
}
