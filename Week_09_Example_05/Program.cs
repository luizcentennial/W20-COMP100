using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_05 {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 5, 2, 7, 9, 1, 0, 4, 2, 6, 8, 9, 2, 1 };

			// Binary Search:
			// It is a more efficient way of searching for specific values.
			// The first step when using Binary Search is sorting the array.
			// Otherwise, the answer will not make sense.

			Array.Sort(numbers);

			foreach (var number in numbers) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();

			int index = Array.BinarySearch(numbers, 7);

			Console.WriteLine(index);
		}
	}
}
