using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09 {
	class Program {
		static void Main(string[] args) {
			#region ARRAYS RECAP
			// Arrays are like multi-dimensional variables.
			// While a variable can hold one single value at a time,
			// Arrays are able to hold multiple values at the same time.

			// Declaring arrays:
			int[] numbers;

			// Initializing arrays:
			numbers = new int[5];

			// Initialize individual elements:
			numbers[0] = 1;
			numbers[1] = 2;

			// Declaring and initializing at the same time:
			string[] strings = { "hello", "world" };

			string[] array = new string[5];
			
			// The zero-th element of "array" is initialized to an empty string.
			// An empty string is a value.
			array[0] = "";

			// Other elements are automatically initialized to null.
			// null is the absence of values.
			// array[1] through array[4] are nulls.

			// Arrays have a property called Length. It returns the size of the array.
			// The Length property is get-only. That means you are not allowed to set it.
			int size = numbers.Length;

			//numbers.Length = 10; - This errors!

			// We can use loops to iterate over arrays:

			// for loop:
			for (int i = 0; i < numbers.Length; i++) {
				// I can do something with each element here.
				//i.e.: Console.WriteLine(numbers[i]);
			}

			// foreach loop:
			foreach (int number in numbers) {
				// I can do anything in there.
				// i.e.: Console.WriteLine(number);
			}

			#endregion

			#region METHODS
			// Methods are a powerful tool that we can use to organize our code.
			// A method is a piece of code, or logic, that runs every time the method is called.
	
			// Methods have 2 parts:
			// Header (also known as signature, or definition, although definition also refers to the method body).
			// Body

			// Header:
			// - Defines the access modifier (public, private, etc).
			// - Defines a return type (string, int, bool, void, etc).
			// - Defines the method name.
			// - Can define method parameters.
			// - Can define many other things (i.e. static).

			// Body:
			// - Defines the code that will run when the method is invoked.

			/*
			 Example:

			 public static int AddNumbers(int number1, int number2) {
				// Method body comes here.
				// I can write any code I want.

				int result = number1 + number2;

				return result;
			 }
			 
			 */
			#endregion
		}
	}
}
