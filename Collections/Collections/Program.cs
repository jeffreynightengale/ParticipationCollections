using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            Dictionary<double, int> examGrades = new Dictionary<double, int>();

            string answer;
            
            do
            {
                Console.WriteLine("Please enter your exam grade. >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                grades.Add(grade);

                if (examGrades.ContainsKey(grade) == false)
                {
                    examGrades.Add(grade, 1);
                }
                else
                {
                    examGrades[grade] = examGrades[grade] + 1;
                }

                Console.WriteLine("Do you have another grade to enter? Yes or No.");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');

            double min = grades[0];
            double max = grades[0];
            double sum = 0; //accumulator to add all of our #'s
            int maxOccurences = 0;
            double mode = 0;

            foreach (double grade in grades)
            {
                if (grade < min)
                {
                    min = grade;
                }
                if (grade > max)
                {
                    max = grade;
                }

                sum = sum + grade / grades.Count;
            }

                foreach (double key in examGrades.Keys)
            {
                double grade = key;
                if (examGrades[grade] > maxOccurences)
                {
                    maxOccurences = examGrades[grade];
                    mode = key;
                }
            }
            foreach (double key in examGrades.Keys)
            {
                double grade = key;
                if (examGrades[grade] == maxOccurences)
                {
                    Console.WriteLine($"The grade that appears the most times is {grade} x {maxOccurences}.");
                }
            }

            Console.WriteLine($"Your minimum is {min.ToString("N2")}");
            Console.WriteLine($"Your maximum is {max.ToString("N2")}");
            Console.WriteLine($"Your average is {sum.ToString("N2")}");
            Console.WriteLine($"Your mode is {mode.ToString("N2")}");

            /*foreach (double grade in grades) //This will give the grades out in a list
            {
                Console.WriteLine(grade);
            }*/
        }
    }
}
