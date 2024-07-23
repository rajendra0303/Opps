using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class Shape2
    {
        protected string color = "Red";
        protected double r = 2.2;
        protected double h = 3;
        protected double w = 2;
    }

    class Circle2 : Shape2
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Property of Circle");
            Console.WriteLine($"Color of Circle :{color}");
            Console.WriteLine("Area of Circle = " + (3.14 * r * r));
        }
    }

    class Rectangle2 : Shape2
    {
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Property of Rectangle ");
            Console.WriteLine($"Color of Rectangle :{color}");
            Console.WriteLine("Area of Rectangle = " + (h * w));
        }
    }

    internal class HierarchicalInheritance
    {
        static void Main()
        {
            Circle2 circle = new Circle2();
            Rectangle2 rectangle = new Rectangle2();
            
            circle.DisplayDetails();
            rectangle.Show();
                

        }
    }
}
