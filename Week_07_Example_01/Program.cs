using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07_Example_01 {
	class Program {
		static void Main(string[] args) {
			// Write a program that displays all even numbers
			// between 0 and 100.
			
			for (int counter = 0;  counter <= 100; counter++) {
				// I can write if statements
				// inside loops
				if (counter % 2 == 0) {
					Console.WriteLine(counter);
				}
			}
		}
	}
}
