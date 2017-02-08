using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    class Program
    {
        //Arrays Reverse input Process
        private static void ArraysReverseProcess()
        {
            Console.WriteLine("Size of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array Space sperated: ");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Console.WriteLine("Result: ");
            for (int index = arr.Length - 1; index >= 0; index--)
            {
                Console.Write(arr[index] + " ");
            }
            Console.ReadLine();
        }

        //2D Array Hourglass Sum
        
        //private static void TwoDArrHourGlass()
        //{
        //    int maxVal = -999;
        //    int result = 0;
        //    for (int row = 0; row <= arr.Length - 3; row++)
        //    {
        //        for (int hIndex = 0; hIndex <= arr.Length - 3; hIndex++)
        //        {
        //            result = arr[row][hIndex] + arr[row][hIndex + 1] + arr[row][hIndex + 2]
        //                    + arr[row + 1][hIndex + 1]
        //                    + arr[row + 2][hIndex] + arr[row + 2][hIndex + 1] + arr[row + 2][hIndex + 2];
        //            if (maxVal < result)
        //            {
        //                maxVal = result;
        //            }

        //        }

        //    }
        //    Console.WriteLine(maxVal);
        //}

        //StaireCase

        private static void stairecase()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = n;

            while (s-- > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < s)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        //left rotation
        private static void leftRotation()
        {
            string s = "1 2";

            string[] s1 = s.Split(' ');
            int n = Convert.ToInt32(s1[0]);
            Console.WriteLine(n);
            //Console.WriteLine("Number of elements: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Number of rotations: ");
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine("Array Elements: ");
            //int[] arr;
            //arr = new int[n];
            //for (int index = 0; index < n; index++)
            //{
            //    arr[index] = int.Parse(Console.ReadLine()); 
            //}

            //while (d-- > 0)
            //{
            //    int temp = arr[0];

            //    for (int shiftIndex = 1; shiftIndex < n; shiftIndex++)
            //    {
            //        arr[shiftIndex - 1] = arr[shiftIndex];
            //    }
            //    arr[n-1] = temp;
            //}

            //for (int shiftIndex = 0; shiftIndex < n; shiftIndex++)
            //{
            //    Console.Write(arr[shiftIndex] + " ");
            //}

            //for (int shiftIndex = d; shiftIndex < n; shiftIndex++)
            //{
            //    Console.Write(arr[shiftIndex]+" ");
            //}
            //Console.WriteLine("Result: ");
            //for (int remIndex = 0; remIndex < d; remIndex++)
            //{
            //    Console.Write(arr[remIndex]+" ");
            //}

        }

        //Correct left rotation
        private static void leftRotation1()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            var tokens = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int n = tokens[0];
            int d = tokens[1];

            int[] arr = new int[n];
            var inputValues = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            for (int shiftIndex = 0; shiftIndex < n - d; shiftIndex++)
            {
                arr[shiftIndex] = inputValues[shiftIndex + d];
            }
            for (int shiftIndex = n - d; shiftIndex < n; shiftIndex++)
            {
                arr[shiftIndex] = inputValues[shiftIndex - (n - d)];
            }

            for (int shiftIndex = 0; shiftIndex < n; shiftIndex++)
            {
                Console.Write(arr[shiftIndex] + " ");
            }
        }

        static void Main(string[] args)
        {
            //Arrays Reverse
            // ArraysReverseProcess();

            //2D Array Hourglass Sum
            //TwoDArrHourGlass();

            //stairecase
            // stairecase();

            //left rotation
            leftRotation1();
            Console.ReadLine();

        }

    }

}