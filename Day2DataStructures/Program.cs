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

        //Day 8 Dictionaries and Maps
        private void phoneBook()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            
            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                phoneBook.Add(input[0],Convert.ToInt32(input[1]));

            }
            string searchQuery = null;
            while ((searchQuery = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(searchQuery))
                {
                    Console.WriteLine(searchQuery + "=" + phoneBook[searchQuery]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

                Console.ReadLine();
        }


        //Day 9 Recursion
        private void factorialByRecursion()
        {
            int N = int.Parse(Console.ReadLine());
            int res = factorial(N);
            Console.WriteLine(res);


        }

        //Day 9 Factorial function
        private int factorial(int N)
        {
            
            if (N <= 1)
                return 1;
            else
            {
                return N * factorial(N - 1);
            }
            
        }


        // Day 10 Dec to Binary
        private void decToBinProcess()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int countOfOnes = 0, counter =0;
            while (n >= 1)
            {
                if (n % 2 == 1)
                {
                    counter++;
                    if (counter > countOfOnes)
                        countOfOnes = counter;
                }
                else
                {
                    counter = 0;
                }
                    
                n = n / 2;
            }
            Console.WriteLine(countOfOnes);

            
        }

        // Day 10 Dec to Binary
        private int  decToBin(int n,int countOfOnes)
        {            

            if (n % 2 == 1)            
                countOfOnes++;
            if(n/2 > 1)
             decToBin(n / 2, countOfOnes);
            return countOfOnes;
            
        }

        //Day 12 Inheritance
        private void studentGrades()
        { 
            string[] inputs = Console.ReadLine().Split();
		    string firstName = inputs[0];
	  	    string lastName = inputs[1];
		    int id = Convert.ToInt32(inputs[2]);
		    int numScores = Convert.ToInt32(Console.ReadLine());
		    inputs = Console.ReadLine().Split();
	  	    int[] scores = new int[numScores];
		    for(int i = 0; i < numScores; i++){
			    scores[i]= Convert.ToInt32(inputs[i]);
		    }            
            
		    Student s = new Student(firstName, lastName, id, scores);
		    s.printPerson();
		    Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }


        //Day 13 
        private void book()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

        //Day 14 Scope
    //     public Difference(int[] a)
    //    {
    //    elements = a;
    //    maximumDifference = 0;
    //}

    //public void computeDifference()
    //    {
    //    int diff = 0;
    //    for(int i=0; i< elements.Length - 1; i++)
    //        {
    //        for(int j = i + 1; j < elements.Length; j++)
    //            {
    //            diff = Math.Abs(elements[i] - elements[j]);
    //            if(diff > maximumDifference)
    //                {
    //                maximumDifference = diff;
    //            }
    //        }
    //    }

       
    //Day 15 Linked list 
        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                Node element = new Node(data);                
                return element;
            }
            else
            {
                Node currentElement = head;
                Node newElement = new Node(data);
                while (currentElement.next != null)
                {
                    currentElement = currentElement.next;
                }
                currentElement.next = newElement;
                newElement.next = null;
                return head;
            }

        }

        public void linkedList()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            displayLinkedList(head);        
        }

        public static void displayLinkedList(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        //Day 16 Execption Handling
        public void exception()
        {
            string s = Console.ReadLine();

            try
            {                
                Console.WriteLine(Convert.ToInt32(s));
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }
        }


        //Merge sort
        public int[] mergeSort(int[] a, int[] b)
        {
            int[] res = new int[8];
            if (a == null && b == null)
                return null;
            if (a == null)
                return a;
            if (b == null)
                return b;

            //if (a <= b)
            //{ 
                
            //}


            return null;
        }

        private void process()
        {
            Program p = new Program();
            //totalMealCost();
            //p.conditionalStatements();
            //Day 5 Loops
            //p.loops()
            //p.review();
            //p.reverseString();
            //p.phoneBook();
            //p.factorialByRecursion();
            //p.decToBinProcess();
            //p.studentGrades();
            //p.book();
            //p.linkedList();
            //p.exception();
            int[] a = {1,3,7,9}, b= {2, 4, 10,5};
            p.mergeSort(a,b);

        }

        static void Main(string[] args)
        {
            //Program p = new Program();            
            //p.process();
            //Console.ReadLine();
            string s = "abcd";
            Console.WriteLine(s[0]);
            Console.ReadLine();
        }
    }
}
