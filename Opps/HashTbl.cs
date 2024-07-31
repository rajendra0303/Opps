using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class HashTbl
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            //key and value pairing
            //Add Key value pair
            ht.Add(1, "English");
            ht.Add(2, "Hindi");
            ht.Add(3, "Marathi");
            ht.Add(4, "Telagu");
            ht.Add(5, "Tamil");



            Console.WriteLine("Element of HashTable:");

            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }

            ht.Remove(1);

            Console.WriteLine("After Removeing element on HashTable");
            ;
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }

            //Delect hash table
            ht.Clear();


            Console.WriteLine("After Deleteing  HashTable");
            ;
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
        }
    }
}
