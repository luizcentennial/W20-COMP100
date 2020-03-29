using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08_Example_05 {
	class Program {
		static void Main(string[] args) {
			for (int line = 0; line < 10; line++) {
				for (int column = 0; column < 10; column++) {
					if (line + column == 9
						|| line == column) {
						Console.Write($"{line}{column} ");
					}
					else if (line == 0
							|| line == 9
							|| column == 0
							|| column == 9) {
						Console.Write("** ");
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
