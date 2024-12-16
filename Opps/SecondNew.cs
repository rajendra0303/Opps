using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public static class secondNew
    {
        

        public static void Sub(this FirstOld op,int x,int y)
        {
            Console.WriteLine();
            Console.WriteLine("*****Second New Class Claculation*****");
            Console.WriteLine($"Substartion is  ={op.x-y}");
        }

        public static void Mul(this FirstOld op,int z)
        {
            Console.WriteLine($"Multiplication is ={op.x*z}");
        }

        public static void Div(this FirstOld op,int a)
        {
            Console.WriteLine($"Division is ={op.x/a}");
        }
    }
}