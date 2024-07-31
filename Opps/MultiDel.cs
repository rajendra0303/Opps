using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public delegate void  Calculation(int a, int b);

    class MyDel1
    {
        public void Add1(int a, int b)
        {
            Console.WriteLine("Addition of two No : "+(a+b));
        }
        public void Sub1(int a, int b)
        {
            Console.WriteLine("Subtraction of two No : "+(a-b));
        }
        public void Mul1(int a, int b)
        {
            Console.WriteLine("Multiplication of two No : "+(a*b));
        }
    }

    internal class MultiDel
    {
        static void Main()
        {

            Console.WriteLine("******Multicat Delegate*****");

        MyDel1 my = new MyDel1();
            Calculation cl = my.Add1;
            Calculation cl2 = my.Sub1;
            Calculation cl3 = my.Mul1;
            cl(10, 20);
            cl2(20, 10);
            cl3(20, 10);


        }
    }
}
