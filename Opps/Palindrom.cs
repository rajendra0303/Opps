using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class Palindrom
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            
            int temp = num, rev = 0;

            while(temp > 0)
            {
                int rem = temp % 10;
                rev = rev * 10 + rem;
                temp /= 10;
            }
            if(rev== num)
            {
                Console.WriteLine("No is Palindrom");

            }
            else
            {
                Console.WriteLine("No is not Palindrom");
            }
        }

       
    }
   
}
