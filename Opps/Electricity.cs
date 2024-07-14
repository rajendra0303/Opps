using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    class Electricity
        {
            static double CalculateBill(double units)
            {
                double totalBill = 0.0;

                // Calculate the bill for the first 50 units
                if (units <= 50)
                {
                    totalBill = units * 0.50;
                }
                else
                {
                    totalBill = 50 * 0.50;
                    units -= 50;

                    // Calculate the bill for the next 100 units
                    if (units <= 100)
                    {
                        totalBill += units * 0.75;
                    }
                    else
                    {
                        totalBill += 100 * 0.75;
                        units -= 100;

                        // Calculate the bill for the next 100 units
                        if (units <= 100)
                        {
                            totalBill += units * 1.20;
                        }
                        else
                        {
                            totalBill += 100 * 1.20;
                            units -= 100;

                            // Calculate the bill for units above 250
                            totalBill += units * 1.50;
                        }
                    }
                }

                // Add a surcharge of 20% to the total bill
                totalBill += totalBill * 0.20;

                return totalBill;
            }

            static void Main(string[] args)
            {
                Console.Write("Enter the number of units consumed: ");
                double units = Convert.ToDouble(Console.ReadLine());
                double bill = CalculateBill(units);
                Console.WriteLine($"The total electricity bill is: Rs. {bill:F2}");
            }
        }
    
}
