using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_01 {
	class Program {
		static void Main(string[] args) {
			// Here is where the magic happens.

			// DISPLAYING MESSAGES TO THE USER

			// The method "Write" writes a line to the console.
			// But it keeps the message on the same line.
			//Console.Write("Hello World!");

			// The method "WriteLine" adds a linebreak at the end of the message.
			//Console.WriteLine("Hello World Again!");


			// READ INPUTS FROM THE USER

			// In order to get an input value, a question could be asked to the user.

			// STEP 1: Asking the user a question.
			Console.WriteLine("What is your name?");

			// STEP 2: Collect user input.
			// There are several types of data:
			// 1. string: Used to store text. Uses double quotes "".
			// 2. double: Used to store numbers with decimals.
			// 3. int: Used to store whole numbers (positive and negative).
			// 4. bool: Used to store binary data (i.e. true or false).
			// 5. char: Used to store single digits (i.e. 'a'). Uses single quotes ''.
			// 6. var: Used to store everything.

			// This is how we declare a variable:
			string name;

			// This is how we initialize a variable:
			name = "Luiz";

			// This is how we declare and initialize a variable at the same time:
			string userName = Console.ReadLine();

			// We can use interpolation to print complex strings.
			Console.WriteLine($"Hello { userName }! This is { name }'s program");
		}
	}
}
