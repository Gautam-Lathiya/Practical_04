using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    /// <summary>
    /// Represents a student with marks and provides methods for calculations.
    /// </summary>
    class Student
    {
        public string Name { get; set; }
        public decimal[] Marks { get; set; } = new decimal[5];
        public static decimal AverageMarks;

        /// <summary>
        /// Calculates the average marks of the student.
        /// </summary>
        /// <returns>The average marks as a decimal.</returns>
        public decimal CalculateAverageMarks()
        {
            AverageMarks = Marks.Average();
            return AverageMarks;
        }

        /// <summary>
        /// Determines the grade based on the given marks using switch case.
        /// </summary>
        /// <param name="marks">The marks to evaluate.</param>
        /// <returns>A string representing the grade.</returns>
        public string CalculateGrade(decimal marks)
        {
            switch ((int)marks / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                default:
                    return "D";
            }
        }
    }
}
