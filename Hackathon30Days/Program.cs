using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon30Days
{
    class Program
    {
        public class HashedAnagramString
        {
            /*
             * Make sure that two anagram strings will have some hashed code
             * 
             * @frequencyTable - Dictionary<char, int>
             * The frequency table has to be sorted first and then construct 
             * a string with each char in alphabetic numbers concatenated by 
             * its occurrences. 
             * 
             */
            public static int GetHashedAnagram(Dictionary<char, int> frequencyTable)
            {
                // build frequency table dynamically, how many time? O(n*n), n 
                // is the string's length
                StringBuilder key = new StringBuilder();

                foreach (var item in frequencyTable.OrderBy(s => s.Key))
                {
                    key.Append(item.Key + item.Value.ToString());
                }

                return key.ToString().GetHashCode();
            }
        }

        static void Main(String[] args)
        {
          //  ProcessInput();
            RunSampleTestcase();
            Console.ReadLine();
        }

        public static void RunSampleTestcase()
        {
            var hashedAnagramsDictionary = ConstructHashedAnagramsDictionary("abba");

            var pairs = CalculatePairs(hashedAnagramsDictionary);


            Debug.Assert(pairs == 4);
        }

        public static void ProcessInput()
        {
            
            var queries = int.Parse(Console.ReadLine());

            while (queries-- > 0)
            {
                var input = Console.ReadLine();

                var hashedAnagramsDictionary = ConstructHashedAnagramsDictionary(input);

                Console.WriteLine(CalculatePairs(hashedAnagramsDictionary));
            }
        }

        /*
         * What should be taken cared of in the design? 
         * Time complexity: 
         * 3 for loops 
         * first loop, loop on the substring's length
         * second loop, loop on the substring's start position
         * third loop, go over each char in the substring to build a 
         * frequency table first; and then
         * update hashed anagram counting dictionary - a statistics, basically 
         * tell the fact like this:
         * For example, test case string abba, 
         * substring ab -> hashed key a1b1, value is 2, because there are 
         * two substrings: "ab","ba" having hashed key: "a1b1"
         * Here are all possible hashed keys: 
         * a1   - a, a, 
         * b1   - b, b
         * a1b1 - ab, ba
         * b2   - bb
         * a1b2 - abb, bba
         * a2b2 - abba
         * 
         */
        public static Dictionary<int, int> ConstructHashedAnagramsDictionary(string input)
        {
            var hashedAnagramsDictionary = new Dictionary<int, int>();

            var length = input.Length;

            for (var substringLength = 1; substringLength < length; substringLength++)
            {
                for (var index = 0; index <= length - substringLength; index++)
                {
                    var frequencyTable = new Dictionary<char, int>();

                    // build frequency table dynamically, how many time? O(n*n), 
                    // n is the string's length
                    for (var start = index; start < index + substringLength; start++)
                    {
                        char c = input[start];
                        if (frequencyTable.ContainsKey(c))
                        {
                            frequencyTable[c]++;
                        }
                        else
                        {
                            frequencyTable.Add(c, 1);
                        }
                    }

                    var key = HashedAnagramString.GetHashedAnagram(frequencyTable);

                    if (hashedAnagramsDictionary.ContainsKey(key))
                    {
                        hashedAnagramsDictionary[key]++;
                    }
                    else
                    {
                        hashedAnagramsDictionary.Add(key, 1);
                    }
                }
            }

            return hashedAnagramsDictionary;
        }

        /*
         * The formula to calculate pairs
         * For example, test case string abba, 
         * substring ab -> hashed key a1b1, value is 2, because there are 
         * two substrings: "ab","ba" having hashed key: "a1b1"
         * Here are all possible hashed keys: 
         * a1   - a, a, 
         * b1   - b, b
         * a1b1 - ab, ba
         * b2   - bb
         * a1b2 - abb, bba
         * a2b2 - abba
         * So, how many pairs? 
         * should be 4, from 4 hashed keys: a1, b1, a1b1 and a2b2
         */
        public static int CalculatePairs(Dictionary<int, int> hashedAnagrams)
        {
            // get pairs
            int anagrammaticPairs = 0;

            foreach (var count in hashedAnagrams)
            {
                anagrammaticPairs += count.Value * (count.Value - 1) / 2;
            }

            return anagrammaticPairs;
        }
    }
}
