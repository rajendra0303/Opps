using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{

    class  Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }

    class circle:Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Second class");
        }
    }
    class Rectangle:Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Third Class");
        }
    }
    internal class DynamicPolymorphism
    {

        static void Main()
        {

            Console.WriteLine("****** Assignment No 2 *******");
            Animal obj = new Animal();
            Animal obj2 = new circle();
            Animal rect = new Rectangle();
            obj.Draw();
            obj2.Draw();
            rect.Draw();

        }
    }
}
