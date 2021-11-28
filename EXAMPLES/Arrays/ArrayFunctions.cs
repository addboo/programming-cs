using System;

public class Program
{
	public static void Main()
	{
		int[] nums = { 10, 15, 16, 8, 6 };

		Console.WriteLine("Original Array");

		foreach (var element in nums)
			Console.WriteLine(element);

		Array.Sort(nums);

		Console.WriteLine("Sorted Array");

		foreach (var element in nums)
			Console.WriteLine(element);

		Array.Reverse(nums);

		Console.WriteLine("Reversed Array");

		Array.ForEach<int>(nums, n => Console.WriteLine(n));

		Console.WriteLine(Array.BinarySearch(nums, 15));

		Console.ReadKey();
	}
}
