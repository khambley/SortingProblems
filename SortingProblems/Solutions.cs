using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
	public class Solutions
	{
		private List<int> _numbers;
		public int _target;
		public Solutions(List<int> numbers, int target = 0)
		{
			_numbers = numbers;
			_target = target;
		}
		public List<int> pair_sum_sorted_array() //List<int> numbers, int target
		{
			var left = 0;
			var right = _numbers.Count - 1;

			while (left < right)
			{
				if (_numbers[left] + _numbers[right] == _target)
				{
					return new List<int> { left, right };
				}
				else if (_numbers[left] + _numbers[right] > _target)
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
