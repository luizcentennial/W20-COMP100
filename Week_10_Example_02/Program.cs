using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Example_02 {
	class Program {
		static void Main(string[] args) {
			/*
			Write a Console App that starts a Guess The Number game with 
			the user.
			The computer should ask the user to input an integer number, 
			as an attempt to guess the number the computer is "thinking".
			After each turn, the app should ask the user if he/she wants 
			to play again. 
			*/

			StartGame();
		}

		public static void StartGame() {
			int userNumber;
			int pcNumber;
			Random randomizer = new Random();

			while (true) {
				pcNumber = randomizer.Next(0, 11);

				Console.WriteLine("Guess the number: ");
				userNumber = int.Parse(Console.ReadLine());

				if (pcNumber == userNumber)
					Console.WriteLine("Correct!");
				else
					Console.WriteLine($"Wrong! My number was {pcNumber}.");

				Console.WriteLine("Play again? (Y/N)");
				string playAgain = Console.ReadLine();

				if (playAgain.ToUpper() == "Y")
					continue;
				else if (playAgain.ToUpper() == "N")
					break;
				else
					Console.WriteLine("Invalid input.");
			}

			Console.WriteLine("Thanks for playing!");
		}
	}
}
