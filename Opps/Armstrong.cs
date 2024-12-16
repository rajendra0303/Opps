using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class Armstrong
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());

            int rem, temp = num, sum=0;

            while(temp>0)
            {
                rem = temp % 10;
                sum += rem * rem * rem;
                temp /= 10;
            }
            if(sum==num)
            {
                Console.WriteLine("arm");
            }
            else
            {
                Console.WriteLine("not arm");
            }

        }
    }
}
