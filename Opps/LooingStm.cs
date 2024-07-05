using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal class LooingStm
    {

        static void Main()
        {
            int i;
            for(i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 1;
            while(j<5)
            {
                Console.WriteLine("Iteration "+j);
            }
        }
    }
}
