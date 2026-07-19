// Create variables for five subject marks and calculate the average.
using System;

public class Question9
{
    public void AverageMarks()
    {
        int subject1 = 10;
        int subject2 = 20;
        int subject3 = 30;
        int subject4 = 15;
        int subject5 = 25;

        int average = (subject1 + subject2 + subject3 + subject4 + subject5) / 5;

        Console.WriteLine("Average Marks = " + average);
    }
}