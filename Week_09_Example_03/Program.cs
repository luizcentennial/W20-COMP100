using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_03 {
	class Program {
		static void Main(string[] args) {
			/*
			EXERCISE 03: 
			a) Write a program that creates an array of size 10,
			populated with random integers. Print the resulting array onto the Console.

			b) Implement code to check if the array contains at least one number 7.
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
			//bool hasSeven = false;

			//foreach (var number in array) {
			//	if (number == 7) {
			//		hasSeven = true;
			//	}
			//}

			//if (hasSeven) { // Same as if (hasSeven == true)
			//	Console.WriteLine("The array has a number 7.");
			//}
			//else {
			//	Console.WriteLine("The array does not have a number 7.");
			//}

			//Console.WriteLine();

			// There is a better way!
			// The Contains method returns true if the argument is found on the array.
			// It returns false if not found.
			bool hasSeven = array.Contains(7);

			if (hasSeven) { // Same as if (hasSeven == true)
				Console.WriteLine("The array has a number 7.");
			}
			else {
				Console.WriteLine("The array does not have a number 7.");
			}
		}
	}
}
