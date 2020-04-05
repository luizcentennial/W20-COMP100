using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_02 {
	class Program {
		static void Main(string[] args) {
			/*
				EXERCISE 02: 
				a) Write a program that creates an array of size 10,
				populated with random integers. Print the resulting array onto the Console.

				b) Implement code to double the value of each array element.
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
			for (int i = 0; i < array.Length; i++) {
				array[i] *= 2;
				//array[i] = array[i] * 2;
			}

			foreach (var number in array) {
				Console.Write($"{number} ");
			}

			Console.WriteLine();
		}
	}
}
