using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    //Creating the PrintTable Class
    public class PrintTable
    {
        public string CourseTitle;
        public int CourseUnit;
        public int CourseScore;
        public string Grade;
        public int GradeUnit;
        public int WeightPt;
        public string Remark;
        public double totalCourseUnitReg;
        public double totalCourseUnitPassed;
        public double totalWeightPt;
        public double GPA;
        public string allCourseTotal;

        public void myEntry()
        {
            //Welcome, and asking the user for the number of courses offered
            Console.WriteLine("Welcome to GPA Calculator\n");
            Console.WriteLine("How many courses do you offer");
            int Course = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            // A loop to recieve the course details for the n number of courses
            for (int i = 0; i < Course; i++)
            {
                Console.WriteLine("Enter a Course Title");
                string courseTitle = Console.ReadLine();

                Console.WriteLine("Enter a Course Unit");
                int CourseUnit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a Score");
                int CourseScore = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //An if statement to check the Course score, Grade and assign various remarks
                if (CourseScore >= 70 && CourseScore <= 100)
                {
                    GradeUnit = 5;
                    Grade = "A";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Excellent";
                }
                else if (CourseScore >= 60 && CourseScore <= 69)
                {
                    GradeUnit = 4;
                    Grade = "B";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Very Good";
                }
                else if (CourseScore >= 50 && CourseScore <= 59)
                {
                    GradeUnit = 3;
                    Grade = "C";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Good";
                }
                else if (CourseScore >= 45 && CourseScore <= 49)
                {
                    GradeUnit = 2;
                    Grade = "D";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Fair";
                }
                else if (CourseScore >= 40 && CourseScore <= 44)
                {
                    GradeUnit = 1;
                    Grade = "E";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Pass";
                }
                else if (CourseScore <= 39 && CourseScore >= 0)
                {
                    GradeUnit = 0;
                    Grade = "F";
                    WeightPt = CourseUnit * GradeUnit;
                    Remark = "Fail";
                }
                else
                {
                    Console.WriteLine("No Input Found");

                }

                //An interpolation to represent the courses on the table
                allCourseTotal += $"| {CourseTitle,-13} | {CourseUnit,-11} | {Grade,-5} | {GradeUnit, -13}|  {WeightPt,-9} | {Remark,-6} |\n";

                //Calculation for the total inputs entered
                totalCourseUnitReg += CourseUnit;
                totalCourseUnitPassed += GradeUnit;
                WeightPt = CourseUnit * GradeUnit;
                totalWeightPt += WeightPt;
                GPA = totalWeightPt / totalCourseUnitPassed;

            }

            //Representing the courses in a tabular form
            Console.WriteLine("Below is your Score\n");
            Console.WriteLine("\n| --------------| ------------| ------| -------------| -----------| ---------|");
            Console.WriteLine("| COURSE & CODE | COURSE UNIT | GRADE | GRADE - UNIT | WEIGHT Pt. | REMARK   |");
            Console.WriteLine("| --------------| ------------| ------| -------------| -----------| ---------|");
            Console.WriteLine(allCourseTotal);
            Console.WriteLine("| --------------| ------------| ------| -------------| -----------| ---------|");

            //Summary for the GPA
            Console.WriteLine($"\nTotal Course Unit Register is: {totalCourseUnitReg}");
            Console.WriteLine($"Total Course Unit Passed is: {totalCourseUnitPassed}");
            Console.WriteLine($"Total Weight Point is: {totalWeightPt}");
            Console.WriteLine($"Your GPA is {GPA:F2}");
            Console.ReadKey();


        }
    }
}

