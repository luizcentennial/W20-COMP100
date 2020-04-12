using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10 {
	class Program {
		static void Main(string[] args) {
			// Methods can have optional parameters.
			// What that means is that the user may or may not
			// pass in a parameters.
			// When that is the case, your code should be smart to
			// understand that, and act appropriately.

			Greet("Luiz");

			DisplaySum(number2: 2, number1: 3);
		}

		// Method that takes in an optional parameter.
		// The user may or may not pass in the parameter.
		// The parameter's default value is null.
		public static void Greet(string name = null) {
			if (name == null)
				Console.WriteLine("Hello!");
			else
				Console.WriteLine($"Hello, {name}!");
		}

		// Method that takes in optional parameters.
		// The user may or may not pass in the parameters.
		// The parameters are not nullable.
		public static void DisplaySum(int number1 = 0, int number2 = 0) {
			if (number1 == 0 && number2 == 0)
				Console.WriteLine("You did not pass in any values.");
			else {
				Console.WriteLine($"Number 1: {number1}, Number 2: {number2}");
				Console.WriteLine($"The sum is {number1 + number2}.");
			}
		}
	}
}
