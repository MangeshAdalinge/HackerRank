using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCoding
{
    class Program
    {
        //Challenge 1: Array Left Rotation
        private static void leftRotation()
        {
             var tokens = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int n = tokens[0];
            int d = tokens[1];

            int[] arr = new int[n];
            var inputValues = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);           

                for (int shiftIndex = 0; shiftIndex < n-d; shiftIndex++)
                {
                    arr[shiftIndex] = inputValues[shiftIndex+d];
                }
                for (int shiftIndex = n-d; shiftIndex < n; shiftIndex++)
                {
                    arr[shiftIndex] = inputValues[shiftIndex-(n-d)];
                }

              

            for (int shiftIndex = 0; shiftIndex < n; shiftIndex++)
            {
                Console.Write(arr[shiftIndex] + " ");
            }

        }

        //Challenge 2: Making Anagrams
        private static void anagrams()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int sumEq = 0;

            foreach (char c in a)
            {
                int i = b.IndexOf(c);
                if (i > -1)
                {
                    sumEq++;

                    //remove matching letters in B to avoid counting repeted letters in A
                    b = b.Remove(i, 1);
                }
            }

            int sumDiff = a.Length - sumEq + b.Length;
            Console.WriteLine(sumDiff);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            //Challenge 1: Left Rotation
           // leftRotation();
            //Challenge 2: Making Anagrams
            anagrams();
        }
    }
}
