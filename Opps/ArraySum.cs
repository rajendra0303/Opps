using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Opps
{
    internal class ArraySum
    {

        static void Main()
        {
            int[] arr = { 50,60,70,80,20 ,};
            int[] arr1 = { 10, 20, 30, 40, 50 };
           

            int sum = 0;
            int k = 0;
            int l = 0;
           

            


           for(int i = 0; i < arr.Length; i++) 
            {
               for(int j = 0;j < arr1.Length;j++) 
                
                
                {
                    if (arr[i] % 2 == 0)
                    {
                        k = arr[i];

                    }

                    if (arr1[j]%2==0) 
                    { 
                        l = arr1[j];
                    
                    }


                    sum = k + l;
                
                }

              
            }

                Console.WriteLine("Array sum  ="+sum);


        }


       
    }
}
