using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter then number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = ""; //string.Empty(); is also possible

            string[] studentNames = new string[numberOfStudents];
            double[] grades = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter the name of student number {i+1} name");
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine($"Enter the grade for student number {i+1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }

            }

            averageGrade = averageGrade / numberOfStudents;
            Console.WriteLine($"The average grade of the class is {averageGrade}");
            Console.WriteLine($"The highest grade of the class is {highestGrade}");
            Console.WriteLine($"The highest grade of the class is {highestGradeName}");

            Console.ReadLine();
        }
    }
}
