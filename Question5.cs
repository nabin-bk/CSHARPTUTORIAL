using System;

public class Question5
{
    public void SwapNumbers()
    {
        int Num1 = 10;
        int Num2 = 20;

        Console.WriteLine($"Before Swapping:");
        Console.WriteLine($"Num1 = {Num1}");
        Console.WriteLine($"Num2 = {Num2}");

    
        int Temporary = Num1;
        Num1 = Num2;
        Num2 = Temporary;

        Console.WriteLine($"After Swapping:");
        Console.WriteLine($"Num1 = {Num1}");
        Console.WriteLine($"Num2 = {Num2}");
    }
}