using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class RefKeyWord
    {
        static void Main()
        {
            int incNo = 500;

            Console.WriteLine("Before increament value : " + incNo);

            incrementVal(ref incNo);

            Console.WriteLine("After increament value : " + incNo);

           
        }
        public static void incrementVal(ref int Number)
        {
            Number++;
        }
    }
}
