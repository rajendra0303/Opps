using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Person
    {
       protected string Name = "Rajendra";
        protected int Age = 22;
    }

    public class Student:Person
    {
        public void Display()
        {
            int  StdId = 132;

            Console.WriteLine($"students info:\nName={Name},\nAge:{Age},\nStdId={StdId}");



        }
    }
    internal class SimpleInheritance
    {

       static void Main()
        {
            Student student = new Student();
            student.Display();
           

           

        }
       
    }
}
