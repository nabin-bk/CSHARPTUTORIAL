// Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.
using System;

public class Question3
{
    public void CalculateMarks()
    {
        
        int Physics = 80;
        int Chemistry = 75;
        int Mathematics = 90;


        int Total = Physics + Chemistry + Mathematics;

        
        Console.WriteLine($"The Physics marks is {Physics}");
        Console.WriteLine($"The Chemistry marks is {Chemistry}");
        Console.WriteLine($"The Mathematics marks is {Mathematics}");
        Console.WriteLine($"The Total marks is {Total}");
    }
}
