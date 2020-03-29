using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_Example_01 {
	class Program {
		static void Main(string[] args) {
			// The code below writes a two-dimensional matrix-like output.
			// The OUTER LOOP is responsible for writing LINES.
			// The INNER LOOP is responsible for writing COLUMNS.

			for (int line = 0; line < 20; line++) {
				for (int column = 0; column < 20; column++) {
					Console.Write($"{line}{column} ");
				}
				Console.WriteLine();
			}
		}
	}
}
