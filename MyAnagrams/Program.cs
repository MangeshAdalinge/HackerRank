using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnagrams
{
    class Program
    {

        static Dictionary<int, string> res = new Dictionary<int, string>();
        static int cnt = 0;
        
        // Construct dictionary of all substrings
        private static Dictionary<int, List<string>> allSubStrings(string input)
        {
            Dictionary<int, List<string>> subStringsDictionary = new Dictionary<int, List<string>>();
            

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j <= input.Length; j++)
                {
                    List<string> allSubStringsList = new List<string>();
                    if (input.Substring(i, j - i).Length < input.Length)
                    {
                        if (subStringsDictionary.ContainsKey(input.Substring(i, j - i).Length))
                        {
                            subStringsDictionary[input.Substring(i, j - i).Length].Add(input.Substring(i, j - i));
                        }
                        else
                        {
                            allSubStringsList.Add(input.Substring(i, j - i));
                            subStringsDictionary.Add(input.Substring(i, j - i).Length, allSubStringsList);
                        }
                    }
                    
                }
            }
            return subStringsDictionary;
        }

        //anagrams
        private static bool anagrams(string s1, string s2)
        {
            foreach (char c in s1)
            {
                int ix = s2.IndexOf(c);

                if (ix == -1)
                    return false;
            }

            return true;
        
        }

        // Find anagrams
        private static void findAnagrams(List<string> listToFindAnagrams)
        {   
            listToFindAnagrams.Sort();
            //Console.WriteLine("Sorted List: ");
            for (int listIndex = 0; listIndex < listToFindAnagrams.Count-1; listIndex++)
            {
                //Console.Write(listToFindAnagrams[listIndex] + " ");
                for (int i = listIndex+1; i < listToFindAnagrams.Count; i++)
                {
                    if (anagrams(listToFindAnagrams[listIndex], listToFindAnagrams[i]))
                    {

                        res.Add(++cnt, listToFindAnagrams[listIndex]);
                    }
                }
               

            }

            
        }

        private static void processInput()
        {
            Console.WriteLine("Please enter number of strings: ");
            int noQueries = int.Parse(Console.ReadLine());
            string[] input = new string[noQueries];
            Console.WriteLine("Please enter " + noQueries + " input strings ");
            for (int index = 0; index < noQueries; index++)
            {
                input[index] = Console.ReadLine();
                Console.WriteLine("Input " + index + " : " + input[index]);
            }

            for (int index = 0; index < noQueries; index++)
            {
                
               // Console.WriteLine("All substrings for :: Input " + index);
                Dictionary<int, List<string>> allSubStringsDictionary = allSubStrings(input[index]);
                foreach (KeyValuePair<int, List<string>> pair in allSubStringsDictionary)
                {
                    //Console.WriteLine(pair.Key);
                   findAnagrams(pair.Value);
                }
                Console.WriteLine("No of anagrams: " + res.Count);
                Console.WriteLine("Anagrams are: ");
                foreach (KeyValuePair<int, string> pair in res)
                {   Console.WriteLine(pair.Value);
                }
            }

        }
        static void Main(string[] args)
        {
            processInput();
            Console.ReadLine();
        }

       


       


    }
}
