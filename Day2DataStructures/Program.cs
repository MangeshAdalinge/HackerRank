using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class Program
    {
        
        
        //Day 2 Operator
        private void totalMealCost()
        {
            ModelClass obj = new ModelClass();
            double mealCost = double.Parse(Console.ReadLine());
            double percentTip = double.Parse(Console.ReadLine());
            double percentTax = double.Parse(Console.ReadLine()); 
            int totalMealCost = obj.TotalMealCost(mealCost, percentTip, percentTax);
            Console.WriteLine(totalMealCost);
            Console.ReadLine();
        }

        //Day 3 Conditional Statements
        private void conditionalStatements()
        {
            ModelClass obj = new ModelClass();
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.conditionalStatements(N));
            Console.ReadLine();
        }

        //Day 4 Class vs. Instance
        //Class Person

        //Day 5 Loops
        private void loops()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }

        //Day 6: Let's Review: Devide String
        private void review()
        { 
            //no of strings
            Console.WriteLine("No of Strings: ");
            int noOfStrings = int.Parse(Console.ReadLine());
            string[] arrString = new string[noOfStrings];
            ModelClass obj = new ModelClass();
            
            for (int index = 0; index < noOfStrings; index++)
            {
                Console.WriteLine("Strings " + index +" : ");                
                arrString[index] = Console.ReadLine();
            }
            for (int index = 0; index < arrString.Length; index++)
            {
                obj.devideString(arrString[index]);
            }
            Console.ReadLine();
        }

        //Day 7 Reverse String
        private void reverseString()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
            
        }



        private void process()
        {
            Program p = new Program();
            //totalMealCost();
            //p.conditionalStatements();
            //Day 5 Loops
            //p.loops()
            //p.review();
            p.reverseString();
        }

        static void Main(string[] args)
        {
            Program p = new Program();            
            p.process();   
        }
    }
}
