using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08 {
	class Program {
		static void Main(string[] args) {
			#region MORE ON LOOPS
			// There are keywords that we can use to better control the flow of the code.

			// KEYWORDS:
			// - break
			// - continue
			// - return

			// When used in a loop, the break keyword will force the code to jump out of loop.

			for (int i = 0; i < 10; i++) {
				// I can use the break to stop the loop execution if a condition is met:
				if (i == 5) {
					break;
				}

				Console.WriteLine(i);
			}

			for (int i = 0; i < 10; i++) {
				// I can use the continue to skip the current loop execution if a condition is met:
				if (i == 5) {
					continue;
				}

				Console.WriteLine(i);
			}

			for (int i = 0; i < 10; i++) {
				// I can use the return to stop the code execution if a condition is met:
				if (i == 5) {
					return;
				}

				Console.WriteLine(i);
			}

			#endregion

			#region NESTED LOOPS
			/*
				 We can execute loops inside loops.
				 These are called NESTED LOOPS.

				 The INNER LOOP will run as many times as its definition,
				 but it will also repeat based on the OUTER LOOP's definition.
				 */

			// This loop will print LINES.
			for (int line = 0; line < 10; line++) {
				// This loop will print COLUMNS.
				for (int column = 0; column < 10; column++) {
					// This code will repeat 100 times (10 * 10).	
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			#endregion

			#region ARRAYS
			// Arrays are much like variables.
			// However, so far we have only worked with variables that are able to hold
			// ONE value at a time.
			// Arrays are capable of holding multiple values at the same time.

			// A simple variable:
			int number = 2;

			// With arrays, I am able to determine multiple values.
			// This is how I can declare an array variable:
			int[] numbers;
			string[] strings;

			// Sometimes, you do not know the values, but you do know the size.
			numbers = new int[5];

			// This is how an array variable is initialized.
			// If you know the array values upfront:
			int[] moreNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Another way would be by using indexes:
			// This requires you to initialize your array.
			numbers[0] = 1;
			numbers[1] = 2;

			#endregion
		}
	}
}
