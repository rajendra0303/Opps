using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class ArrayRev
    {

        static void Main()
        {
            string str = "CODEMIND TECHNOLOGY PUNE";

            Console.WriteLine("GIVEN STRING IS :"+str);

            string rev = " ";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine("GIVEN STRING IS REVERSED :" + rev);
        }
    }
}
