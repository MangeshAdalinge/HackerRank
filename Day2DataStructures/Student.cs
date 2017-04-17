using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class Student : Person
    {
        private int[] testScores;
        

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        Student()
        { }
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.id = id;
            this.testScores = scores;

        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            int sum = 0;
            char res = ' ';
            for (int i = 0; i < testScores.Length; i++)
            {
                sum = sum + testScores[i];
            }
            int avg = 0;
            avg = sum / testScores.Length;
            if (avg >= 90 && avg <= 100)
            {
                res = 'O';
            }
            else
                if (avg >= 80 && avg < 90)
                {
                    res = 'E';
                }
                else
                    if (avg >= 70 && avg < 80)
                    {
                        res = 'A';
                    }
                    else
                        if (avg >= 55 && avg < 70)
                        {
                            res = 'P';
                        }
                        else
                            if (avg >= 40 && avg < 55)
                            {
                                res = 'D';
                            }
                            else
                                if (avg < 40)
                                {
                                    res = 'T';
                                }

            return res;
        }
    }
}
