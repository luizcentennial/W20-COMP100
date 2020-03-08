using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07 {
	class Program {
		static void Main(string[] args) {

			#region INTRO
			// Loops are control structures that allow for the repetition of code
			// without having to write the same lines over and over again.

			// Without loops, if we wanted to write a program that counts to 10:
			Console.WriteLine(1);
			Console.WriteLine(2);
			Console.WriteLine(3);
			Console.WriteLine(4);
			Console.WriteLine(5);
			Console.WriteLine(6);
			Console.WriteLine(7);
			Console.WriteLine(8);
			Console.WriteLine(9);
			Console.WriteLine(10);

			// This is not good!

			// Instead, we should be using loops.
			// There are 3 kinds of loops:
			// - Do-While
			// - While
			// - For
			#endregion

			#region DO-WHILE LOOP
			// Here is the syntax for a Do-While loop:
			/*
			
			do {
				// Do whatever is here
			}
			while (<CONDITION>); // While this condition is true.
			
			 */

			// If I wanted to re-write the program that counts to 10:
			int counter = 1;

			do {
				Console.WriteLine(counter);

				// I have to increment the counter, otherwise this loop will never end.
				counter = counter + 1;

				// There are other ways to increment a variable:
				// counter += 1;
				// counter++;
			}
			while (counter <= 10);
			#endregion

			#region WHILE LOOP
			// Here is the syntax for the While loop:
			/*
			 
			while (<CONDITION>) { // While this condition is true...
				// Do whatever I have here.
			}

			*/

			// Because the condition comes first, nothing will happen
			// if the condition is not true.

			// This is different than the Do-While, where the condition comes last.
			// This means that when using the Do-While loop, the code inside
			// the loop will run at least once.

			// Do-While: Is a post-processed loop.
			// While: Is a pre-processed loop.

			int anotherCounter = 1;

			while (anotherCounter <= 10) {
				Console.WriteLine(anotherCounter);

				anotherCounter += 1;
				// anotherCounter++;
			}

			#endregion

			#region COMPARING PRE VS POST PROCESSED
			int i = 10;

			// If i >= 10, the code inside the while loop will never run.
			while (i < 10) {
				Console.WriteLine(i);

				i++;
			}

			// However, the code inside the do while loop will run once.
			do {
				Console.WriteLine(i);

				i++;
			} while (i < 10);
			#endregion

			#region FOR LOOP
			// Here is the syntax for the For loop:

			// There are 3 parts to the For loop:\
			// 1. Counter declaration
			// 2. Condition
			// 3. Increment
			// Each part is separated by semi-colon ";"

			/*
			
			for (int counter = 0; counter < 10; counter++) {
				// Do something.
			}

			*/

			// Re-writing the same example:
			for (int j = 1; j <= 10; j++) {
				Console.WriteLine(j);

				// I do not have to increment my counter.
				// This is done on the header.
			}

			#endregion
		}
	}
}
