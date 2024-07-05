using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class String1
    {
        static void Main()
        {
            //string
            string msg = "Rajendra";

            msg += " More";
            Console.WriteLine(msg);


            //string Builder
            Console.WriteLine("*******Append String**********");
            StringBuilder sb = new StringBuilder("Hard Work is");
            sb.Append(" Key of Great Success");
            Console.WriteLine(sb.ToString());
            Console.WriteLine();

            Console.WriteLine("*******Success Replaced by Achievement******");
            Console.WriteLine();
            sb.Replace("Success", "Achievement");
            Console.WriteLine(sb.ToString());

            Console.WriteLine() ;
            Console.WriteLine("********Great is Removed by using remove Method*********");
            sb.Remove(19,6);

            Console.WriteLine(sb.ToString());

        }
    }
}
