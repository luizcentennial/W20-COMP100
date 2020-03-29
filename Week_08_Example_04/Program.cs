using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_Example_04 {
	class Program {
		static void Main(string[] args) {
			// The code below uses combined conditions to print desired elements.
			// This uses the knowledge learned in the "Compound Conditionals" class.

			for (int line = 0; line < 10; line++) {
				for (int column = 0; column < 10; column++) {
					if (line + column == 9 
						|| line == column
						|| line == 0
						|| line == 9
						|| column == 0
						|| column == 9) {
						Console.Write($"{line}{column} ");
					}
					else {
						Console.Write("   ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
