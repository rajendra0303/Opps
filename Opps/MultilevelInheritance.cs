using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class Person1
    {
        protected String Name = "Rajendra More";
        protected int RNo = 55;
    }

    class Teacher : Person1
    {
        
        
           protected int Marks = 91;
        
    }

    class Principle:Teacher
    {
        public void Display()
        {
            char grade = 'A';

            Console.WriteLine($"All Information For Person: \nName ={Name},\nRNo ={RNo},\nMarks={Marks},\nGrade ={grade} ");

        }
    }
    internal class MultilevelInheritance

    {
        static void Main()
        {
            Principle principle = new Principle();
            principle.Display();
        }

    }
    
}
