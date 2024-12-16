using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class NonGenStack
    {
        //LIFO - last in first out

        static void Main()
        {
            Stack st = new Stack();

            //Add Element in stack

            st.Push(".net");
            st.Push("Java");
            st.Push("React");
            st.Push("Angular");
            st.Push("Html");

            //Display the element of stack
            Console.WriteLine("Element of stak:");

            foreach (var item in st)
            {

                Console.WriteLine(item);
            }

            //use pop opration

            st.Pop();

            Console.WriteLine("After remove of Element in Stack :");

            foreach (var item in st)
            {

                Console.WriteLine(item);
            }


        }
    }
}
