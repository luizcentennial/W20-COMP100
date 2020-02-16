using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_05 {
	class Program {
		static void Main(string[] args) {
			#region IF STATEMENTS
			// IF STATEMENTS
			// If statements make use of:
			// Comparison operators:
			// > or >=
			// < or <=
			// ==
			// !=
			// Logical operators
			// &&
			// ||
			// !

			const int myNumber = 5;

			if (myNumber > 0) { // A simple comparison operator
								// If myNumber is greater than 0
								// Do something here.
			}
			else if (myNumber > -10) {
				// If myNumber is not greater than 0:
				// myNumber is between 0 and -9.
				// Do something else.
			}
			else {
				// For every other case.
				// myNumber is less than -9.
			}

			// If statements can be used to compare strings

			string myString = "CENTENNIAL";

			if (myString.ToLower() == "centennial") {
				// Do something.
			}
			else if (myString.ToUpper() == "SENECA") {
				// Do something else.
			}
			else {
				// For every other case.
			}

			// If statements can also compare booleans

			bool myBoolean = true;

			if (myBoolean == true) {
				// Do something.
			}

			// Because myBoolean is of bool type,
			// There is a shorthand

			if (myBoolean) {
				// Do something.
			}

			// Or...

			if (!myBoolean) {
				// Do something.
			}
			#endregion

			#region SWITCH STATEMENTS
			// SWITCH STATEMENTS
			// Switch statements work like If Statements
			// But they work on the premise of cases.

			string myVariable = "COMP100";

			switch (myVariable) { // I am switching on myVariable's value
				case "COMP100":
					// Do something.
					break;
				case "COMP213":
					// Do something else.
					break;
				default:
					// For every other case.
					break;
			}
			#endregion

			#region PRACTICE
			/*
			 Write a program that prompts the user for their age.
			 If they are 40 or older, print a message "You are old".
			 If they are younger than 40, but older than 25, print a message "It's only downhill from now.".
			 If they are 25 or younger, print a message "You are young".
			 
			 Solve using If Statements.
			*/

			// STEP 1: Declare variables
			int age;
			string message;

			// STEP 2: Gather input
			Console.WriteLine("Please enter your age: ");
			age = Convert.ToInt32(Console.ReadLine());
			// age = int.Parse(Console.ReadLine());

			// STEP 3: Logic
			if (age >= 40) {
				message = "You're old";
			}
			else if (age > 25) {
				message = "It's only downhill from now.";
			}
			else {
				message = "You're young.";
			}

			// STEP 4: Display results
			Console.WriteLine(message);


			//========================================================================

			/*
			Write a program that prompts the user for the make of their car.
			If the input is "BMW", their maintenance fees are $500.
			If the input is "FORD", their maintenance fees are $200.
			For other brands, the maintenance is a flat fee of $250.

			Solve using Switch Statements.
			*/

			// STEP 1: Declare variables
			double fee;
			string make;
			string anotherMessage;

			// STEP 2: Gather input
			Console.WriteLine("Please enter the brand of your car: ");
			make = Console.ReadLine();

			// STEP 3: Logic
			switch (make.ToUpper()) {
				case "BMW": 
					fee = 500;
					break;
				case "FORD":
					fee = 200;
					break;
				default:
					fee = 250;
					break;
			}

			// STEP 4: Display results
			anotherMessage = $"Your maintenance fees are {fee:C}";

			#endregion
		}
	}
}
