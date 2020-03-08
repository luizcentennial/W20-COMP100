using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07_Example_03 {
	class Program {
		static void Main(string[] args) {
			/*
			 3.	Write a C# program that converts gallons to liters.
			 The program should display gallons from 10 to 20 
			 in one-gallon increments and the corresponding liter’ 
			 equivalents. 
			 
			 Use the relationship that 1 gallon contains 
			 3.785 liters.
			*/

			double gallons = 10.0;
			double ratio = 3.785; // 1 gallon = 3.785 liters.

			Console.WriteLine($"{"GALLONS", -15} {"LITERS", -15}");
			Console.WriteLine("==========================");

			while (gallons <= 20.0) {
				double liters = ratio * gallons;

				Console.WriteLine($"{gallons,-15:F} {liters,-15:F}");
				gallons++;
			}
		}
	}
}
