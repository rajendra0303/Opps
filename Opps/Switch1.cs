using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class Switch1
    {

        static void Main()
        {

            Console.WriteLine("1:Pizza");
            Console.WriteLine("2:Burger");
            Console.WriteLine("3:Salad");
            Console.WriteLine();
            Console.WriteLine("Enter Menu of Food");
            int choice = 3;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1:Pizza");
                    break;
                case 2:
                    Console.WriteLine("2:Burger");
                    break;
                case 3:
                    Console.WriteLine("3:Salad");
                    break;
                default:
                    Console.WriteLine("Worng Input");
                    break;

            }
        }
    
    }
}
