using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Example_03 {
	class Program {
		// Fields:
		// Fields are variables accessible inside the class.
		// All methods can access its value.
		static double balance = 0;

		static void Main(string[] args) {
			#region PROBLEM
			/*
			Write a Console App that mimicks the operation of an 
			ATM machine.
			When the application starts, it should ask the user to input 
			his/her account number and PIN.
			If the login succeeds, the app should display a menu, where 
			the user has to select an option.

			(1) View balance
			(2) Deposit
			(3) Withdraw
			(4) Log out

			After every transaction, the app should take the user back to 
			the main menu, and continue	doing transactions until he/she 
			logs out. 
			*/
			#endregion

			#region APPROACH
			/*			
			write StartATM() method.
			- prompt for login and password
			- if login succeeds, display menu
			- else, keep prompting for login and password

			write DisplayMenu() method.
			- print all menu options onto the console
			- asks the user what menu option they want to select
			- gathers user input, calling RunTransaction() with parameter

			write RunTransaction() method.
			- have a switch statement to run the appropriate operation based on user input
			- display message confirming operation successful

			write GetBalance() method
			- prints balance

			write Deposit() method
			- receives a parameter and adds to the balance

			write Withdraw() method
			- receives a parameter and subtracts from the balance

			no LogOut() method needed
			 */
			#endregion
			
			StartATM();
		}

		public static void StartATM() {
			/*
			- prompt for login and password
			- if login succeeds, display menu
			- else, keep prompting for login and password
			*/

			const string login = "luiz";
			const string password = "1234";
			string typedLogin;
			string typedPassword;

			while (true) {
				Console.WriteLine("\nPlease input your username: ");
				typedLogin = Console.ReadLine();

				Console.WriteLine("Please input your password: ");
				typedPassword = Console.ReadLine();

				if (typedLogin == login && typedPassword == password) {
					Console.WriteLine("Login successful!");
					DisplayMenu();
				}
				else {
					Console.WriteLine("Wrong credentials. Please try again.");
				}
			}
		}

		public static void DisplayMenu() {
			/*
			- print all menu options onto the console
			- asks the user what menu option they want to select
			- gathers user input, calling RunTransaction() with parameter
			*/
			int option;

			while (true) {
				Console.WriteLine("\nPlease select an option:");
				Console.WriteLine("(1) View balance \n" +
								  "(2) Deposit \n" +
								  "(3) Withdraw \n" +
								  "(4) Log out \n");

				option = int.Parse(Console.ReadLine());

				if (option != 4 && option > 0 && option < 5)
					RunTransaction(option);
				else
					break;
			}
		}

		public static void RunTransaction(int option) {
			/*
			- have a switch statement to run the appropriate operation based on user input
			- display message confirming operation successful
			*/

			switch (option) {
				case 1:
					GetBalance();
					break;
				case 2:
					Deposit();
					break;
				case 3:
					Withdraw();
					break;
				default:
					Console.WriteLine("Illegal option.");
					break;
			}

			Console.WriteLine("Done!");
		}

		private static void GetBalance() {
			Console.WriteLine($"Your balance is {balance:C}");
		}

		private static void Deposit() {
			double amount;

			Console.WriteLine("Please input the deposit amount: ");
			amount = double.Parse(Console.ReadLine());

			balance += amount;

			GetBalance();
		}

		private static void Withdraw() {
			double amount;

			Console.WriteLine("Please input the withdrawal amount: ");
			amount = double.Parse(Console.ReadLine());

			balance -= amount;

			GetBalance();
		}
	}
}
