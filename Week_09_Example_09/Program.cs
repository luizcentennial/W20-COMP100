using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_09 {
	class Program {
		static void Main(string[] args) {
			/*
			 EXERCISE:
			 a) Write a method that generates a random array of integers.

			 b) Write a method that prints an array.
			 The method receives an array as an argument, and just prints it onto the Console.
			 */

			// a)
			int[] numbers = GenerateRandomArray(5);

			// b)
			PrintArray(numbers);
		}

		// a)
		public static int[] GenerateRandomArray(int size) {
			int[] result = new int[size];
			Random randomizer = new Random();

			for (int i = 0; i < size; i++) {
				result[i] = randomizer.Next(0, 10);
			}

			return result;
		}

		// b)
		public static void PrintArray(int[] array) {
			foreach (var element in array) {
				Console.Write($"{element} ");
			}

			Console.WriteLine();
		}
	}
}
