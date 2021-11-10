using System;

class CalculateArea
{
    static void Main()
    {
        double length;
        double width;
        double area;
        string inputString;

        Console.WriteLine("Program to calculate the area of a rectangle");
        Console.WriteLine();
        
        Console.Write("Please enter the length of the rectangle: ");
        inputString = Console.ReadLine();
        length = double.Parse(inputString);
        
        while (length <= 0)
        {
            Console.WriteLine("The length must be greater than 0");
            Console.Write("Please enter a valid value for the length: ");
            inputString = Console.ReadLine();
            length = double.Parse(inputString);
        }
        
        Console.Write("Please enter the width of the rectangle: ");
        inputString = Console.ReadLine();
        width = double.Parse(inputString);
        
        while (width <= 0)
        {
            Console.WriteLine("The width must be greater than 0");
            Console.Write("Please enter a valid value for the width: ");
            inputString = Console.ReadLine();
            width = double.Parse(inputString);
        }        
        
        area = length * width;
        
        Console.Write("The area of the rectangle is ");
        Console.WriteLine(area);
    }
}
