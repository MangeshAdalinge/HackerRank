using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            processInput();
        }

        private static void processInput()
        {
            Console.WriteLine("Please enter number of strings: ");
            var noQueries = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter " + noQueries + " input strings ");
            while(noQueries --> 0)
            {
                var input = Console.ReadLine();
                Console.WriteLine("Input: "+input);
                getsub1(input);
                //Dictionary<int, List<string>> subStrings = getsub1(input);
                //foreach (var item in subStrings)
                //{
                //   List<string> output = new List<string> { };
                //    output = subStrings[Convert.ToInt32(item)];
                //    Console.WriteLine();
                //}
                
                Console.ReadLine();
            }
        }


        static void getsub1(string str)
        {
            
            var items = Enumerable
                .Range(0, str.Length)
                .SelectMany(i => Enumerable.Range(1, str.Length - i ).Select(j => str.Substring(i, j)))
                .Distinct()
                .OrderBy(s => s.Length);
            foreach (var s in items)
            {
                Console.WriteLine(s);
            }
        
        }



        static Dictionary<int, List<string>> getsub(string str1)
        {
            Dictionary<int, List<string>> ret = new Dictionary<int, List<string>> { };

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i; j < str1.Length; j++)
                {
                    List<string> x = new List<string> { };
                    x.Add(str1.Substring(i, j + 1));
                    if (!ret.ContainsKey(str1.Substring(i, j + 1).Length))
                    {
                        ret.Add(str1.Substring(i, j + 1).Length, x);
                    }
                    else
                        ret.Add(str1.Substring(i, j + 1).Length, x);
                }
            }

            return ret;
        }


    }
}
