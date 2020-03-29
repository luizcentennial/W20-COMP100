using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_Example_07 {
	class Program {
		static void Main(string[] args) {
			// This is an array of size 10.
			// Its elements go from index 0 to index 9.
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// You can use the for loop to print each element individually.
			// That is because a simple Console.WriteLine(numbers) would not work.
			for (int i = 0; i < numbers.Length; i++) {
				Console.Write(numbers[i] + " ");
			}

			Console.WriteLine();

			// There is a "better" way:
			// We can use the FOREACH loop.

			foreach (int element in numbers) {
				// I called it "element", but any word works.
				Console.Write(element + " ");
			}

			Console.WriteLine();

			// BONUS: LINQ
			numbers.ToList().ForEach(element => Console.Write(element + " "));

			Console.WriteLine();
		}
	}
}
