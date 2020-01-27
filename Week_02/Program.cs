using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			// Solving Exercise 01 from file
			// Wk02_IPO_charts_ASSIGNMENT.docx
			Console.WriteLine("EXERCISE 01");

			// STEP 1: Declare variables
			double avgLength;
			int houses;
			double totalWire;

			// STEP 2: Prompt the user for input
			Console.WriteLine("Input the average length: ");
			avgLength = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Input the number of houses: ");
			houses = Convert.ToInt32(Console.ReadLine());

			// Step 3: Calculate the result using the formula
			totalWire = avgLength * houses;

			// STEP 4: Print out the result
			string message = "The result is " + totalWire;

			Console.WriteLine(message);


			// =========================================================

			// Exercise 02
			Console.WriteLine("\n\nEXERCISE 02");

			// STEP 1: Declare variables
			double kgPerHectar;
			double pricePerKg;
			double size;
			double cost;

			// STEP 2: Prompt the user for input
			Console.WriteLine("Input the kg per hectar: ");
			kgPerHectar = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Input the price per kg: ");
			pricePerKg = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Input the size of the land: ");
			size = Convert.ToDouble(Console.ReadLine());

			// STEP 3: Calculate the result
			cost = kgPerHectar * pricePerKg * size;

			// STEP 4: Display result
			message = $"The result is ${ cost }.";

			Console.WriteLine(message);

			// STEP 5: Be happy it worked!
		}
	}
}
