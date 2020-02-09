using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_04 {
	class Program {
		static void Main(string[] args) {
			// This is where the magic happens.

			#region CASTING
			// Quick recap:
			// Data types we know:
			// int
			// double
			// bool
			// string
			// char

			// Sometimes we have to convert between data types.
			// For example:
			// Everything the user inputs through the Console is a string.

			string input = "10";

			// If I want to do some math with this variable
			// I have to convert to int or double.

			// This is how a conversion between string and int happens:
			int integer = Convert.ToInt32(input); // or int.Parse(input);

			// This is how a conversion between string and double happens:
			double floatingPoint = Convert.ToDouble(input);

			// We can use Convert for other things:
			string trueOrFalse = "true";

			// I can convert a string into a bool:
			bool myBoolean = Convert.ToBoolean(trueOrFalse);


			// There are other ways to convert between data types:

			// Casting
			// Use it when you want to convert between data types
			// that are NOT strings.
			int myInteger = 40;

			// I want to convert to a double using casting
			double myDouble = (double)myInteger;

			// If I have a char
			char myCharVariable = 'd';

			// Can I convert a char to an int?
			int convertedInt = (int)myCharVariable;

			//Console.WriteLine(convertedInt);

			// Let's try another data type:
			string myString = "a";

			// I want to convert this to a char:
			char myChar = Convert.ToChar(myString); // Cannot use casting.

			int zeroOrOne = 27;

			// I want to convert this to a boolean
			// This does not work because zeroOrOne can assume ANY value.
			// This value can be 0 or 1, but can also be any other integer.
			//bool convertedBoolean = (bool)zeroOrOne;

			// In order to convert an integer to a boolean, we need other resources...
			#endregion

			#region CONDITIONAL STATEMENTS

			// There are two main types of conditional statements:
			// If Statements
			// Switch statements

			// I can use them when I want to control the flow of my code.

			#region IF STATEMENTS
			// Here is the syntax:
			bool isStudent = false;

			// A condition must exist inside the parenthesis.
			if (isStudent) {
				// If isStudent is true, this block is going to run.
				Console.WriteLine("You are a student.");
			}

			bool haveTools = false;

			if (haveTools) {
				// If I have tools...
				Console.WriteLine("I will change the tire.");
			}
			else {
				// If I do NOT have tools...
				Console.WriteLine("I will take the bus.");
			}


			// We can use conditional statements with variables
			// other than booleans.

			// I want to know whether someone is allowed to drive.
			int age = 15;

			// I need an if statement:
			// I am using a logical operator instead of bool variables.
			if (age >= 16) {
				// In this situation you can drive.
				Console.WriteLine("You can drive.");
			}
			else {
				// In this situation you cannot drive.
				Console.WriteLine("You cannot drive.");
			}

			// If Statements can have Else blocks.

			// Comparison operators:
			// ==
			// > or >=
			// < or <=


			// I want to write a program that says:
			// It is cold - If the temperature is less than 10.
			// It is hot - If the temperature is greater than 25.
			// It is moderate - Every other case.

			double temperature = 16;

			if (temperature < 10) {
				Console.WriteLine("It is cold.");
			}
			else if (temperature > 25) {
				Console.WriteLine("Is it hot.");
			}
			else {
				Console.WriteLine("It is moderate.");
			}
			#endregion

			#region SWITCH STATEMENTS

			// Here is the syntax:
			bool lampIsOn = true;

			// In the parenthesis I have to put the variable I want to switch on.
			switch (lampIsOn) {
				case true: // Possible values for my variable lampIsOn.
					Console.WriteLine("The lamp is on.");
					break;
				default:
					Console.WriteLine("The lamp is off.");
					break;
			}

			#endregion

			#endregion

			#region PRACTICE
			/*
			Write a program that prompts the user for their age.
			Gather the input and print a message saying if the user
			is allowed to drive.

			Solve using if statements
			*/

			// STEP 1: Declare variables
			int age;
			string message;

			// STEP 2: Prompt for input
			Console.WriteLine("Please input your age: ");
			age = Convert.ToInt32(Console.ReadLine());

			// STEP 3: Logic
			if (age >= 16) {
				message = "You can drive.";
			}
			else {
				message = "You cannot drive.";
			}

			// STEP 4: Display the result
			Console.WriteLine(message);


			/*
			Write a program that prompts the user for
			the number of courses they have this semester.

			Each course equals 4 hours a week of lectures.
			
			If the number of courses is 1, the tuition is $1,500.

			If the number of courses is 2, the tuition is $2,000.

			If the number of courses is 3, the tuition is $2,500.

			If the number of courses is 4, the tuition is $3,000.
			
			If the number of courses is greater than 4,
			the tuition is a fixed value of $5,000.

			Solve this problem using switch.
			*/

			// STEP 1: Declare variables
			int courses;
			double tuition;
			string message;

			// STEP 2: Prompt for input
			Console.WriteLine("PLease input the number of courses: ");
			courses = int.Parse(Console.ReadLine());

			// STEP 3: Logic
			switch (courses) {
				case 1:
					tuition = 1500;
					break;
				case 2:
					tuition = 2000;
					break;
				case 3:
					tuition = 2500;
					break;
				case 4:
					tuition = 3000;
					break;
				default:
					tuition = 5000;
					break;
			}

			// STEP 4: Display results
			message = string.Format("Your tuition is {0:C}", tuition);

			Console.WriteLine(message);
			#endregion
		}
	}
}
