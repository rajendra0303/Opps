using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class ControlStatement
    {

        static void Main()
        {
            //if Statement
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }

            //if-else statement

            if (number > 0)
            {
                Console.WriteLine("The Number is Greater than zero");

            }

            else
            {
                Console.WriteLine("The Number is Lesser than zero");
            }

            //if else if statement

            int grade = 95;
            if(grade >90)
            {
                Console.WriteLine("A Grade");
            }
            else if(grade > 80)
            {
                Console.WriteLine("B Grade");

            }
            else if (grade >70)
            {
                Console.WriteLine("C Grade");
            }
            else if(grade <60)
            {
                Console.WriteLine("D Grade");
            }
            else if(grade>50)
            {
                Console.WriteLine("E Grade");
            }

            //Switch statement

            
            
        }
    }
}
