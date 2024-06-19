using System;

class Program
{
    static void Main()
    {
        // Input student name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // Declare course names
        string[] courseNames = new string[8];
        courseNames[0] = "OOP";
        courseNames[1] = "OOP Lab";
        courseNames[2] = "DataBase";
        courseNames[3] = "DataBase Lab ";
        courseNames[4] = "DLD ";
        courseNames[5] = "DLD Lab";
        courseNames[6] = "Discrete ";
        courseNames[7] = "Expository";

        int[] courseCredits = new int[8];
        int[] courseGrades = new int[8];

        // Grade values
        int gradeA = 4;
        int gradeB = 3;
        int gradeC = 2;
        int gradeD = 1;

        // Input course credits and grades
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Enter credit hours for {courseNames[i]}: ");
            courseCredits[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter grade ( A (4), B (3), C(2), D(1)) for {courseNames[i]}: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade == 4)
                courseGrades[i] = gradeA;
            else if (grade == 3)
                courseGrades[i] = gradeB;
            else if (grade == 2)
                courseGrades[i] = gradeC;
            else if (grade ==1)
                courseGrades[i]=gradeD;
            else
                Console.WriteLine("Invalid grade input. Only A (4), B (3), C(2), D(1) are allowed.");
        }

        // Calculate total credit hours and grade points
        int totalCreditHours = 0;
        int totalGradePoints = 0;

        for (int i = 0; i < 8; i++)
        {
            totalCreditHours += courseCredits[i];
            totalGradePoints += courseCredits[i] * courseGrades[i];
        }

        // Calculate GPA
        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        // Extract leading digit, first and second decimal places
        int leadingDigit = (int)gradePointAverage;
        int firstDigit = (int)(gradePointAverage * 10) % 10;
        int secondDigit = (int)(gradePointAverage * 100) % 10;

        // Output results
        Console.WriteLine($"\nStudent: {studentName}");
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine($"{courseNames[i]}: Grade {courseGrades[i]}, Credits {courseCredits[i]}");
        }

        Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
    }
}
