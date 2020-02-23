using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06 {
	class Program {
		static void Main(string[] args) {
			#region COMPOUND STATEMENTS
			int a = 5;
			int b = 20;
			int c = 10;

			bool myBoolean = a > b || b < c;

			if (myBoolean) { // OR means that only one needs to be true.
							 // if (myBoolean) = if (myBoolean == true).
				Console.WriteLine("a is greater than b, or b is greater than c.");
			}

			// Maybe I want to do something different...

			if (!myBoolean) { // OR means that only one needs to be true.
							  // if (!myBoolean) = if (myBoolean == false).
				Console.WriteLine("a is not greater than b, or b is not greater than c.");
			}

			// Logical operators also have their precedence.
			int x = 1;
			int y = 2;
			int z = 3;

			//							+		 *
			bool myOtherBoolean = x > y || (y < z && x < z);

			if (myOtherBoolean) {
				Console.WriteLine("x > y || (y < z && x < z) is true.");
			}

			if (!myOtherBoolean) {
				Console.WriteLine("x > y || (y < z && x < z) is not true.");
			}

			Console.WriteLine();
			#endregion

			#region NESTED CONDITIONAL STATEMENTS
			/*
			 Write a program that prompts the user for their gender and age.
			 If they are 25 or younger, the program must say they are young.
			 If they are older than 25, but younger than 40, the program must say they are old.
			 If they are 40 or older, the program must say they are really old.

			 If the gender is male, the program must address the user as sir.
			 If the gender is female, the program must address the user as ma'am.
			*/

			Console.WriteLine("Please input your gender: ");
			string gender = Console.ReadLine();

			Console.WriteLine("Please input your age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			// In reality, the user might input male, Male, m, M, etc...
			if (gender.Substring(0, 1).ToLower() == "m") { // This covers all possible scenarios for males.
														   // If male...
				if (age <= 25) {
					Console.WriteLine("Sir, you are young.");
				}
				else if (age < 40) {
					Console.WriteLine("Sir, you are old.");
				}
				else {
					Console.WriteLine("Sir, you are really old.");
				}
			}
			else {
				// If female...
				if (age <= 25) {
					Console.WriteLine("Ma'am, you are young. All due respect.");
				}
				else if (age < 40) {
					Console.WriteLine("Ma'am, you are old. All due respect.");
				}
				else {
					Console.WriteLine("Ma'am, you are really old. All due respect.");
				}
			}

			Console.WriteLine();
			#endregion

			#region HANDLING CONDITIONALS IN DIFFERENT WAYS...
			int myAge = 30;
			string message;

			// What I want to do is have a string have different values, based on myAge.
			// If age is less than 35, then the message is "You are young".
			// Or else, the message is "You are old".

			// Using traditional if statements
			//if (myAge...) {
			//	message = "Something";				
			//}

			// There is an easier way.
			// Ternary Operators
			//		  condition		if true				if false
			message = myAge < 35 ? "You are young." : "You are old.";

			Console.WriteLine(message);

			/*
			 Write a program that calculates and displays the total price of a purchase.
			 If the purchase value is more than $100.00, include a 5% discount.
			 For all other purchases, the discount is 2%.
			*/

			Console.WriteLine("Enter the purchase value: ");
			double total = Convert.ToDouble(Console.ReadLine());

			double discount = total > 100 ? 0.05 : 0.02;
			double grandTotal = total * (1 - discount);

			Console.WriteLine($"Your total is {grandTotal:C}");

			Console.WriteLine();
			#endregion

			#region MORE OPERATORS 
			// Comparison Operators:
			// ==
			// > or >=
			// < or <=
			// !=
			// %: Modulus does a division and returns the remainder

			// For example:
			// 5 / 2 = 2.5
			// 5 % 2 = 1 Because 5 divided by 2 is 2, and the remainder is 1.

			// This helps you determine, for example, if a number is odd or even.
			Console.WriteLine("Input a whole number: ");
			int myNumber = int.Parse(Console.ReadLine());

			if (myNumber % 2 == 0) { // Determining whether a number is a multiple of 2.
				Console.WriteLine($"{myNumber} is even.");
			} 
			else {
				Console.WriteLine($"{myNumber} is odd.");
			}

			#endregion
		}
	}
}