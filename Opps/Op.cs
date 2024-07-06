using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class Op
    {
        static void Main()
        {
            Console.WriteLine("Arithmetic Oprator");

            Console.WriteLine();
            //Arithmetic OPrator
        int A = 100;
        int B = 10;
       

           Console.WriteLine("Addition of two No ="+(A + B));
           Console.WriteLine("Subtraction of two No =" + (A - B));
           Console.WriteLine("Multiplication of two No =" + (A * B));
           Console.WriteLine("Division of two No =" + (A / B));
           Console.WriteLine("Remindder of two No =" + (A % B));

            //conditional oprator

            Console.WriteLine();
            Console.WriteLine("conditional oprator");
            Console.WriteLine();
            int C = 20;
            int D = 10;

            String result = (C > D) ? "C is Greater " : "D is Greater";
            Console.WriteLine(result);


            //Relational oprator
            Console.WriteLine();
            Console.WriteLine("Relational oprator");
            Console.WriteLine();
            int E = 13;
            int F = 14;

            bool isEqual = (E == F);
            Console.WriteLine("The Oprator is = "+isEqual);

            bool isNotEqual = (E != F);
            Console.WriteLine("The Oprator is = " + isNotEqual);

            bool isGreater = (E > F);
            Console.WriteLine("The Oprator is = " + isGreater);

            bool isLess = (E < F);
            Console.WriteLine("The Oprator is = " + isLess);

            bool isGreaterOrEqual = (E >= F);
            Console.WriteLine("The Oprator is = " + isGreaterOrEqual);

            bool isLessOrEqual = (E <= F);
            Console.WriteLine("The Oprator is = " + isLessOrEqual);


            //Logical oprator
            Console.WriteLine();
            Console.WriteLine("Logical oprator");
            Console.WriteLine();
            //!
            bool R = false;
            R = !R;

            Console.WriteLine("Logical oprator is = "+R); 

            //&&

            bool R1 = true;
            bool R2 = true;

            if(R1&&R2)
            {
                Console.WriteLine("R1 and R2 are same");
                
            }

            //||

            if(R1||R2)
            {
                Console.WriteLine("Excute only statement");
            }

        }
    }
}
