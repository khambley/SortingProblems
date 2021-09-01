using System;
using System.Collections.Generic;

namespace SortingProblems
{
	class Program
	{
		static void Main(string[] args)
		{
			//List<int> numbersList = new List<int>() { 1, 2, 3, 5, 10};
			//int target = 7;
			List<int> numbersList = new List<int>() { 5, 3, 10, 45, 1 };
			int target = 6;
			Console.WriteLine("The length of array is: " + numbersList.Count);
			Console.WriteLine("The elements of the array are: ");
			foreach(var number in numbersList)
			{
				Console.Write(number + " ");
			}
			Console.WriteLine();
			Console.WriteLine("The target number is: " + target);
			var outputList = pair_sum_sorted_array(numbersList, target);
			Console.WriteLine("The indices of the two values from the array that sum up to target: " + target + " are " + outputList[0] + " " + outputList[1]);

		}
		// start at leftmost number and rightmost number, add together, if sum = 7, return list with left and right, you found the indexes.
		// if the sum of the numbers is greater than 7, move right point to the left (decrement),
		// if the sum of the numbers is less than 7, move left point to the right (increment).
		public static List<int> pair_sum_sorted_array(List<int> numbers, int target)
		{
			var left = 0;
			var right = numbers.Count - 1;

			while(left < right)
			{
				if(numbers[left] + numbers[right] == target)
				{
					return new List<int> { left, right };
				} 
				else if (numbers[left] + numbers[right] > target)
				{
					right--;
				} 
				else
				{
					left++;
				}
			}
			return new List<int> { -1, -1 };
		}
	}
}
