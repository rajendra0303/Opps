using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class MathodOverLoading
    {
        public void Show(String a, String b)
        {
            Console.WriteLine(a + b);
        }

        public void Show(String a, String b, string c)
        {


            Console.WriteLine(a + b + c);
        }
    }

    internal class CompileTime
    {
        static void Main(String[] args)
        {


            MathodOverLoading obj = new MathodOverLoading();
            Console.WriteLine("*********Example Of Method Overloading*********");
            obj.Show("Raju ", "More");
            obj.Show("Rajendra ","Tatyaso ","More");

        }
    }
}
