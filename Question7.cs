//Store the length and breadth of a rectangle and calculate the perimeter.
using System;

public class Question7
{
    public void Perimeter()
    {
        int length = 10;
        int breadth = 5;


        int perimeter = 2 * (length + breadth);

        Console.WriteLine($"Length = {length}");
        Console.WriteLine($"Breadth = {breadth}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}