using System;

namespace gradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = {4,73,67,38,33};
            int[] result = GradeRounder(grades);
            System.Console.WriteLine(string.Join("\n", result));
        }

        static int[] GradeRounder(int[] grades)
        {
            //for loop
            //for each val, check is above 40 and mod5 < 3
            for(int i = 0; i < grades.Length; i++)
            {
                if(grades[i] > 37 && grades[i] % 5 > 2)
                {
                    grades[i] += (5 - (grades[i] % 5));
                }
            }
            return grades;
        }
    }
}
