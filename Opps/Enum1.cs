using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    using System;

    public enum Year
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public class Enum1
    {
        public static string FindMonth(Year month)
        {
            switch (month)
            {
                case Year.January:
                    return "January is the starting month of the year.";
                    
                case Year.December:
                    return "December is the ending month of the year.";
                default:
                    return $"{month} is a month in the year.";
            }
        }

        public static void Main()
        {
            Console.WriteLine(FindMonth(Year.January));
            Console.WriteLine(FindMonth(Year.December));
            Console.WriteLine(FindMonth(Year.August));
        }
    }
}
