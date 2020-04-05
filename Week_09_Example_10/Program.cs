using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_10 {
	class Program {
		static void Main(string[] args) {
			/*
			EXERCISE:

			a) Write a method that prompts the user for the size of an array.
			After prompting for the size, the user must be asked if he/she wants a
			random array, or an array that is manually defined.

			b) Write a method that writes an array to the Console, following the
			pattern:
			[ 1, 2, 3, 4, 5 ]
			*/

			// a)
			int[] array = CreateArray();

			Console.WriteLine();

			// b)
			PrintArray(array);
		}

		// a)
		public static int[] CreateArray() {
			// Declaring variables
			int size;
			string type;
			bool isRandom;
			Random randomizer = new Random();
		
			// Gathering inputs
			Console.WriteLine("Please input the size: ");
			size = int.Parse(Console.ReadLine());

			Console.WriteLine("Is this a random array? (Y/N) ");
			type = Console.ReadLine().ToLower();
			isRandom = type == "y" ? true : false;

			// Logic
			int[] result = new int[size];

			if (isRandom) {
				for (int i = 0; i < size; i++) {
					result[i] = randomizer.Next(0, 10);
				}
			}
			else {
				for (int i = 0; i < size; i++) {
					Console.WriteLine($"Please input element {i}: ");
					result[i] = int.Parse(Console.ReadLine());
				}
			}

			return result;
		}

		// b)
		public static void PrintArray(int[] array) {
			string result = string.Join(", ", array);

			Console.WriteLine($"[ {result} ]");
		}
	}
}
