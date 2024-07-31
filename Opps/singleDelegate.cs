using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public delegate void Addition(int a, int b);
    public delegate void Subtraction(int c, int d);

    class MyDel
    {
        public void Add(int a, int b)
        {

            Console.WriteLine("Addition of two no : "+(a + b));
        }
        public void Sub(int c, int d)
        {
            Console.WriteLine("Subtraction of two no :"+(c - d));
        }
    }
    internal class singleDelegate
    {
        static void Main()
        {
            Console.WriteLine("*****Singlecast Delegate*****");
            Console.WriteLine();
            MyDel md = new MyDel();
            Addition ad = new Addition(md.Add);
            ad(20, 30);

            Subtraction sb = new Subtraction(md.Sub);
            sb(50, 30);

        }

    }
}
