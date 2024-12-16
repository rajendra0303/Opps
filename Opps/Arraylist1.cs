using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class Arraylist1
    {
        static void Main()
        {
            //creating an Array List

            ArrayList list = new ArrayList();

            //add element in array list

            list.Add(1);
            list.Add("raju");
            list.Add('A');
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("Apple");
            list.Add("Mango");
            list.Add("Banana");
            list.Add('B');



            //access element

            Console.WriteLine("Element of ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove(2);
            list.Remove(3);
            



            Console.WriteLine("After Removeing Element of ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

           

            list.Clear();

            Console.WriteLine("After Deleteing Element of ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }

}
