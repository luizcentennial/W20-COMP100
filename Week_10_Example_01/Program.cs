using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Example_01 {
	class Program {
		static void Main(string[] args) {
			/*
			 Write a method that draws a geometric form onto the Console.
			*/

			DrawSquare(10);
		}

		public static void DrawSquare(int size = 5) {
			for (int lines = 0; lines < size; lines++) {
				for (int columns = 0; columns < size; columns++) {
					Console.Write("* ");
				}

				Console.WriteLine();
			}
		}
	}
}
