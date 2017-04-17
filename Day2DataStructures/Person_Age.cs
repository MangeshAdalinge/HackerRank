using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class Person_Age
    {
        public int age;
        public Person_Age(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
            {
                age = initialAge;
            }

        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 

            if (age < 13)
                Console.WriteLine("You are young.");
            else
            {
                if (age >= 13 && age < 18)
                    Console.WriteLine("You are a teenager.");
                else
                {
                    if (age >= 18)
                        Console.WriteLine("You are old.");
                }
            }


        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age = age + 1;
        }
    }

}