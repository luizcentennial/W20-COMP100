using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_08 {
	class Program {
		static void Main(string[] args) {
			// Calling the method:
			int x = 1;
			int y = 2;

			int result = Sum(x, y);

			Console.WriteLine(result);

			// Same as:
			Console.WriteLine(Sum(1, 2));
		}

		// This method is not "void". It returns an "int".
		// I must use the "return" keyword in the method body to return the result.
		public static int Sum(int number1, int number2) {
			return number1 + number2;
		}
	}
}
