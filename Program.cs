using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number score you have in a class");
        int score = int.Parse(Console.ReadLine());
        string letterGrade;
        if (score >= 100)
        {
            Console.WriteLine("Wow! 100... That's impressive");
            letterGrade = "A+";
        }
        else if (score >= 90)
        {
            Console.WriteLine("Very nice!");
            letterGrade = "A";
        }
        else if (score >= 80)
        {
            Console.WriteLine("Keep it up!");
            letterGrade = "B";
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got thism keep working!");
            letterGrade = "C";
        }
        else if (score >= 60){
            Console.WriteLine("Keep trying!");
            letterGrade = "D";
        }else {
            Console.WriteLine("Don't give up!");
            letterGrade = "E";
        }
        Console.WriteLine($"Letter Grade:{letterGrade}");
    }
}