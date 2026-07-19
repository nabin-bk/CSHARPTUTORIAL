//Store the temperature in Celsius and convert it to Fahrenheit.
using System;

public class Question10
{
    public void Temperature()
    {
        double celsius = 25;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Celsius = {celsius}");
        Console.WriteLine($"Fahrenheit = {fahrenheit}");
    }
}