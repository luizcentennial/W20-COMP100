using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_OddsOrEvens {
	class Program {
		static void Main(string[] args) {
			string userChoice; // Odds or evens
			int userNumber; // Anything from zero to five.
			int computerNumber;

			Console.WriteLine("Odds or evens?");
			userChoice = Console.ReadLine();

			// Validating user input.
			if (userChoice.Substring(0, 1).ToUpper() != "O" && userChoice.Substring(0, 1).ToUpper() != "E") {
				Console.WriteLine("You cheated!");
				return; // Breaking out of the program.
			}

			Console.WriteLine("Select your number, between 0 and 5: ");
			userNumber = int.Parse(Console.ReadLine());

			// Validating user input.
			if (userNumber < 0 || userNumber > 5) {
				Console.WriteLine("You cheated!");
				return;
			}

			Random randomizer = new Random();
			computerNumber = randomizer.Next(0, 6);
			int result = userNumber + computerNumber;
			string selections = $"You selected {userNumber}, and the computer selected {computerNumber}.";
			string message;

			if (result % 2 == 0) { // Result is even.
				if (userChoice.Substring(0, 1).ToUpper() == "E") {
					message = "You win!";
				}
				else {
					message = "You lose.";
				}
			}
			else { // Result is odd.
				if (userChoice.Substring(0, 1).ToUpper() == "O") {
					message = "You win!";
				}
				else {
					message = "You lose.";
				}
			}

			Console.WriteLine($"{selections} {message}");
		}
	}
}
