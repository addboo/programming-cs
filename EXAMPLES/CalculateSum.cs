using System;

// Program to calculate the sum of the non-zero numbers that have been entered
// Author:  Wayne Rippin
// Created; September 2010

class CalculateSum
{
    static void Main()
    {
        double sum = 0;
        double numberEntered;
        string inputNumber;

        Console.WriteLine("Program to calculate the sum of the non-zero numbers entered.");
        Console.WriteLine();
        
        Console.Write("Please enter the first number. Enter 0 to stop: ");
        inputNumber = Console.ReadLine();
        numberEntered = double.Parse(inputNumber);
        
        while (numberEntered != 0)
        {
            sum = sum + numberEntered;
            Console.Write("Please enter another number. Enter 0 to stop: ");
            inputNumber = Console.ReadLine();
            numberEntered = double.Parse(inputNumber);
        }
        
        Console.Write("The sum of the numbers is ");
        Console.WriteLine(sum);
    }
}
