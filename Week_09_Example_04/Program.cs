using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_04 {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 5, 2, 7, 9, 1, 0, 4, 2, 6, 8, 9, 2, 1 };

			// The Array.Sort method orders an array.
			// This will order the array object without generating a new one.
			Array.Sort(numbers);

			// The Reverse method will generate a new array with the same elements,
			// but in reverse order.
			// You need a new variable to store the newly generated array.
			var reversed = numbers.Reverse();

			foreach (var number in reversed) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();
		}
	}
}
