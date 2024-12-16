using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{

    //abstract Class
    public abstract class Shape
    {

        //abstract method
        public abstract void CalculateArea();

        //non-abstract method
            public void ClaArea()

        {
            Console.WriteLine("Calculate the Area ");
        }
    }

    //derived class 1
    public class Circle:Shape
    {
        public override void CalculateArea()
        {

            double r = 3.4;
            Console.WriteLine("Area of Circle = " + (3.14*(r*r)));
        }
    }

    //Derived class 2
    public class Rectangle1:Shape
    {
        public override void CalculateArea()
        {
            double l = 2.5;
            double w = 2.4;
            Console.WriteLine("Area of Ractangle = "+(l*w));
        }
    }
    internal class AbstractClass
    {
        static void Main()
        {
            //object Creation of Circle class

            Circle circle = new Circle();
            circle.ClaArea();
            circle.CalculateArea();
        
            //object creation Rectangle class
            Rectangle1 rect1 = new Rectangle1();
            rect1.CalculateArea();







        }
    }
}
