using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_01 {
	class Program {
		static void Main(string[] args) {
			// We can combine our knowledge about arrays and loops to
			// perform mathematical operations:

			/*
			EXERCISE 01: 
			a) Write a program that creates an array of size 10,
			populated with random integers. Print the resulting array onto the Console.
			 
			b) Implement code to sum all values in this array, and return the result.
			Print the result onto the Console.
			*/

			// a)
			int[] array = new int[10];
			Random randomizer = new Random();

			for (int i = 0; i < array.Length; i++) {
				array[i] = randomizer.Next(0, 10);
			}

			foreach (int number in array) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();

			// b)
			int counter = 0;

			foreach (int number in array) {
				counter += number;
				// same as counter = counter + number;
			}

			Console.WriteLine($"The sum is {counter}.");
		}
	}
}
