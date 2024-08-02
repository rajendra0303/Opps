using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class OutKeyWord
    {
        static void Main()
        {

            InitializeValue(out int no, out string str);

            Console.WriteLine("Print integer value : " + no);
            Console.WriteLine("Print String value : " + str);

        }

        static void InitializeValue(out int Number ,out string text)
        {
            Number = 500;
            text = "ajit Yadav";
        }
    }
}
