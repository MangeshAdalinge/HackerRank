using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class ModelClass
    {
        //Day 2 Operator
        public int TotalMealCost(double mealCost, double  percentTip, double percentTax)
        {
            int res = 0;            
            res = Convert.ToInt32(mealCost + (double)(mealCost * (percentTip / 100)) + (double)(mealCost * (percentTax / 100)));
            return res;
        }


        //Day 3 Conditional Statements
        public string conditionalStatements(int n)
        {
            if (n % 2 == 0)
            {
                if (n >= 6 && n <= 20)
                {
                    return "Wiered";
                }
                else
                    return "Not Wiered";
            }
            else
                return "Wiered";
            
        }

        public static void day1()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int iPlus = int.Parse(Console.ReadLine()); ;
            double dPlus = double.Parse(Console.ReadLine());
            string sConcat = Console.ReadLine();
            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + iPlus);

            // Print the sum of the double variables on a new line.

            Console.WriteLine(string.Format("{0:0.0}", (double)(d + dPlus)));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + sConcat);
            Console.ReadLine();
        }
        
    }
}
