// Declare variables for principal, rate, and time, then calculate simple interest.
using System;

public class Question8
{
    public void SimpleInterest()
    {
        int principal = 1000;
        int rate = 5;
        int time = 2;

        int simpleintrest = (principal * rate * time) / 100;

        Console.WriteLine($"Simple Interest = {simpleintrest}");
    }
}