using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public class FirstOld
    {
        public int x = 10;
        public void Add(int d)
        {
            Console.WriteLine("***First Base Class Calculation****");
            Console.WriteLine($"Addition is={this.x + d}");
        }

    }
}