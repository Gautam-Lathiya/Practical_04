using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    /// <summary>
    /// Enum representing different menu options.
    /// </summary>
    enum Options { Aggregate = 1, MinMark = 2, MaximumMark = 3, Grade = 4 }

    class Program
    {
        /// <summary>
        /// The main method that executes the program.
        /// It prompts the user for student details, takes marks input,
        /// and provides a menu to choose different calculations such as
        /// average marks, minimum marks, maximum marks, and grade calculation.
        /// </summary>
        static void Main()
        {
            Student student = new Student();

            // Taking student name input
            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            // Taking marks input
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                student.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Aggregate (Average Marks)");
            Console.WriteLine("2 - MinMark (Minimum Marks)");
            Console.WriteLine("3 - MaximumMark (Maximum Marks)");
            Console.WriteLine("4 - Grade (Calculate Grade)");

            if (Enum.TryParse(Console.ReadLine(), out Options choice))
            {
                switch (choice)
                {
                    case Options.Aggregate:
                        Console.WriteLine($"{student.Name}: Average Marks = {student.CalculateAverageMarks():F2}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"Minimum Marks: {student.Marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"Maximum Marks: {student.Marks.Max()}");
                        break;
                    case Options.Grade:
                        decimal avgMarks = student.CalculateAverageMarks();
                        string grade = student.CalculateGrade(avgMarks);
                        Console.WriteLine($"Grade: {grade}");
                        break;
                    default:
                        Console.WriteLine("Wrong option chosen.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
            }
        }
    }

}
