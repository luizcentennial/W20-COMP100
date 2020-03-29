using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_Example_02 {
	class Program {
		static void Main(string[] args) {
			// The code below will only print the main diagonal.

			for (int line = 0; line < 10; line++) {
				for (int column = 0; column < 10; column++) {
					if (line == column) {
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
