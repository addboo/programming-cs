using System;
using System.Linq;

class MinMaxSum
{
    static void Main(string[] args)
    {
        int[] myNumbers = { 5, 1, 8, 9 };
        Console.WriteLine(myNumbers.Max());  // returns the largest value
        Console.WriteLine(myNumbers.Min());  // returns the smallest value
        Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

        Console.ReadKey();
    }
}
