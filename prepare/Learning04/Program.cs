using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Reese", "Multiplication", "1.2", "10-56");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();

        WritingAssignments writingAssignment = new WritingAssignments("Reese", "Instructional Writing", "Coding for newbs");
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInfo();

        
    }
}