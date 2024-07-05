using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class ArraySearch
    {

        static void Main()
        {
            string[] array = { "Alice", "Bob", "Charlie", "David", "Emily" };

            string nameSearch = "David";

            Console.WriteLine("*********Search the name array string******");
            Console.WriteLine();

           bool res = array.Contains(nameSearch);
            if (res)
            {
                Console.WriteLine("David will be found");
            }
            else
            {
                Console.WriteLine("David will not be Found");
            }
        }
    }
}
