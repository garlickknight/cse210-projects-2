using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignments assignment = new Assignments();

        assignment.getStudentName("Joseph Garlick");
        assignment.gettopic("Physical Education");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathA = new MathAssignment();
        mathA.SetAttrubutes( mathA,"Section 7.3", "problems 8-19" );
        mathA.getStudentName("Mei Ling");
        mathA.gettopic("Weight Lifting");
        mathA.GetSummary();
        Console.WriteLine(mathA.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment();
        writing.titleConstructor("Joe Garlick", "Writing 101", "Your Mom Went to College");
        Console.WriteLine(writing.GetWritingAssignment());

    }
}