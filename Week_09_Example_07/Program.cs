using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_07 {
	class Program {
		static void Main(string[] args) {
			// I can write a method that does not return anything.

			string letters = "I love C#";

			// Contains is a non-static method.
			letters.Contains("C");

			// WriteLine is a static method.
			Console.WriteLine(letters);

			// I can tell the Greet method is static because it is not being called
			// from an object.
			Greet();

			// This is how I can call a method with parameters:
			string user = "Luiz";
			GreetWithName(user);

			// Call a method without creating a helper variable:
			GreetWithName("World");
		}

		// This is a parameterless method
		public static void Greet() {
			Console.WriteLine($"Hello!");
		}

		// This is a method with paraters
		public static void GreetWithName(string name) {
			Console.WriteLine($"Hello, {name}!");
		}
	}
}
