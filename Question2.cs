using System;

public class Question2

{
    
    public void GetInput()
    {
        Console.WriteLine("Enter the first number");
         int Num1 = Convert.ToInt32(Console.ReadLine());



         Console.WriteLine("Enter the second number");
         int Num2 = Convert.ToInt32(Console.ReadLine());



         int  Sum = Num1 + Num2;

          Console.WriteLine($"The Sum of {Num1} and {Num2} is : {Sum}");
         


    }

    }