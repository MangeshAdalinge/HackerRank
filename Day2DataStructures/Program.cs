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
        private void process()
        {
            Program p = new Program();
            //totalMealCost();
            p.conditionalStatements();
        }

        static void Main(string[] args)
        {
            Program p = new Program();            
            p.process();   
        }
    }
}
