using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_03 {
	class Program {
		static void Main(string[] args) {
			#region Intro

			// Types of operators
			// +
			// -
			// /
			// *
			// %
			// and
			// or
			// not
			// comparison: ==, >, <, >=, <=
			// assignment: =

			// Examples:
			// Given the following variables:
			double distance = 14.5; // km
			double anotherDistance = 11.2; // km
			double time = 30.1;     // s

			// Division
			double kmPerSecond = distance / time;

			// Addition
			double totalDistance = distance + anotherDistance;

			// Subtraction
			double difference = distance - anotherDistance;

			// Multiplication
			double area = distance * anotherDistance;


			// Precedence:
			double volume = 1.4 + 2 * 15 - 2 / 3;

			#endregion

			#region Exercise 06
			/*
			 6.	Parker would like to get each of the females in his family the 
			 same gift for the holidays. He has an amount of money which he is 
			 willing to use up completely. Write a program that will prompt him 
			 for the price of the item and the amount of money that he has and 
			 then calculate and display the most items that he can buy and the 
			 left-over money. (There are 2 outputs for this question)
			*/

			// STEP 1: Declare variables
			double totalMoney;
			int numberOfFemales;
			double moneyLeft;
			int numberOfItems;
			double itemPrice;

			// STEP 2: Prompt for input
			Console.WriteLine("How many females are there in your family? ");
			numberOfFemales = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("What is the item price? ");
			itemPrice = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("How much money do you have? ");
			totalMoney = Convert.ToDouble(Console.ReadLine());

			// STEP 3: Calculation
			numberOfItems = Convert.ToInt32(Math.Floor(totalMoney / itemPrice));
			moneyLeft = totalMoney - numberOfItems * itemPrice;

			// STEP 4: Display the result
			string message = $"Number of items: { numberOfItems }. \nYou have ${ moneyLeft } left.";

			Console.WriteLine(message);
			#endregion

			Console.WriteLine("\n\n");

			#region Exercice 07
			/*
			7.	Quincy “The Plumber” bills customer for pipe installation based 
			on the length as well as the number of joins of the job. Build a 
			program that will prompt for length rate, join rate, the length, 
			the number of join and calculate and display the total cost. 
			[cost = (length * lengthRate) + (numberOfJoins * joinRate)] 
			*/

			// STEP 1: Declaration:
			double cost;
			double length;
			double lengthRate;
			int numberOfJoins;
			double joinRate;

			// STEP 2: Prompt for input:
			Console.WriteLine("Please enter the length rate: ");
			lengthRate = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the join rate: ");
			joinRate = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the length: ");
			length = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the number of joins: ");
			numberOfJoins = Convert.ToInt32(Console.ReadLine());

			// STEP 3: Calculate:
			cost = lengthRate * length + joinRate * numberOfJoins;

			// STEP 4: Display the result:
			message = $"The total cost is { cost }";
			Console.WriteLine(message);

			// STEP 5: Be happy!

			#endregion

			Console.WriteLine("\n\n");

			#region Exercise 08
			/*
			8.	Last year at the CNE, the Robert Family brought ride tickets. 
			If the Polar Express and the Ferris wheel cost 5 and 3 tickets 
			respectively. Write a program that prompts the user for the amount 
			of ticket bought, the number of times each of the two rides were 
			taken and then calculate how many tickets will remain at the end of the day.
			*/

			// STEP 1: Declaration
			int numberOfTickets;
			int timesPolarExpress;
			int timesFerrisWheel;
			int ticketsLeft;

			// STEP 2: Prompt for input
			Console.WriteLine("Please enter the number of tickets bought: ");
			numberOfTickets = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the number of times Polar Express was ridden: ");
			timesPolarExpress = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the number of times Ferris Wheel was ridden: ");
			timesFerrisWheel = Convert.ToInt32(Console.ReadLine());

			// STEP 3: Calculation
			ticketsLeft = numberOfTickets - timesPolarExpress * 5 - timesFerrisWheel * 3;

			// STEP 4: Display the result
			message = $"You have { ticketsLeft } tickets left.";
			Console.WriteLine(message);

			#endregion
		}
	}
}
