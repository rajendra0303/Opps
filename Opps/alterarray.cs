using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class alterarray
    {
        static void Main()

        {

            int[] arr = { 50, 45, 12, 13, 64, 95, 36 };
            Console.WriteLine("********Given Array is*********");
            Console.WriteLine();
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write("  "+arr[i]);
            }

            Console.WriteLine();
            //how many number array
            int numberOfArray = arr.Length;
            Console.WriteLine("Number Element in Array : " + numberOfArray);

            Console.WriteLine();


            //alternate number in array
            Console.WriteLine("******Alternate Number In Array********");
            

            for (int i = 0; i < arr.Length; i += 2)
            {

                Console.Write("  " + arr[i]);
            }

            //smaller element in array
            Console.WriteLine();

            Console.WriteLine("*********Smallest and Largest Value in Arrray*********");
            int smallVal = arr.Min();
            Console.WriteLine("Smaller value of array : " + smallVal);

            //larger element in array

            Console.WriteLine();
            int largerval = arr.Max();
            Console.WriteLine("larger element in Array : " + largerval);

        }


    }
}
