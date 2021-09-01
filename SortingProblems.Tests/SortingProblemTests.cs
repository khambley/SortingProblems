using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;


namespace SortingProblems.Tests
{
	public class SortingProblemTests
	{
		private readonly ITestOutputHelper _output;

		public SortingProblemTests(ITestOutputHelper output)
		{
			_output = output;
		}

		#region 2 Sum In A Sorted Array
		[Fact]
		public void pair_sum_sorted_array_test1()
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 5, 10 };
			int target = 7;

			Solutions solutionTest = new Solutions(numbers, target);

			var result = solutionTest.pair_sum_sorted_array();

			var expected = new List<int>() { 1, 3 };

			Assert.Equal(expected, result);

			DisplayOutput(numbers, expected, result, target);
			
		}
		#endregion

		#region 2 Sum In An Array (unsorted)
		[Fact]
		public void pair_sum_sorted_array_test2()
		{
			List<int> numbers = new List<int>() { 5, 3, 10, 45, 1 };
			int target = 6;

			Solutions solutionTest = new Solutions(numbers, target);

			var result = solutionTest.pair_sum_sorted_array();

			var expected = new List<int>() { 0, 4 };

			Assert.Equal(expected, result);

			DisplayOutput(numbers, expected, result, target);

		}
		#endregion

		public void DisplayOutput(List<int> numbers, List<int> expected, List<int> result, int target)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				_output.WriteLine(numbers[i] + " ");
			}
			_output.WriteLine("The target is " + target);
			_output.WriteLine("The expected output is: " + expected[0] + " and " + expected[1]);
			_output.WriteLine("The actual output is: " + result[0] + " and " + result[1]);
		}
	}
}
