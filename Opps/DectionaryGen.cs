using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class DectionaryGen
    {
        static void Main()
        { 
            //initilize Dictionary
          Dictionary<string,int> dict = new Dictionary<string,int>();

            //add key Pairs

            dict.Add("Rajendra", 1);
            dict.Add("Ravi", 2);
            dict.Add("Akash", 3);
            dict.Add("Sangram",4);
            dict.Add("Aditya", 5);
            dict.Add("Raju", 6);
            dict.Add("Ajit", 7);
            dict.Add("Rahul", 8);
            dict.Add("Sandip", 9);
            dict.Add("Ram", 10);


            //Diplay all dictionry

            Console.WriteLine("***All elements in the Dictionary***");

            foreach(KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            dict.Remove("Ravi");
            dict.Remove("Sandip");
            dict.Remove("Rahul");

            Console.WriteLine("***Removed elements in the Dictionary***");

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            dict["Rajendra"] = 13;
            dict["Akash"] = 14;

            Console.WriteLine("***Modify elements in the Dictionary***");

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            dict.Clear();


            Console.WriteLine("***Clear elements in the Dictionary***");

            Console.WriteLine(dict.Count);
        }
    }
}
