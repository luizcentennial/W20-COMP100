using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07_Example_02 {
	class Program {
		static void Main(string[] args) {
			/*
			 1.	Write a program to produce a table 
			 that starts at a Celsius value of -10 
			 and ends with a Celsius value of 60, in 
			 increments of ten degrees. 
			*/

			Console.WriteLine("-----------");
			Console.WriteLine("| CELSIUS |");
			Console.WriteLine("===========");

			for (int celsius = -10; celsius <= 60; celsius += 10) {
				if (celsius.ToString().Length == 1) {
					Console.WriteLine($"|    {celsius}    |");
				}
				else if (celsius.ToString().Length == 3) {
					Console.WriteLine($"|   {celsius}   |");
				}
				else {
					Console.WriteLine($"|    {celsius}   |");
				}
			}

			Console.WriteLine("===========");
		}
	}
}
