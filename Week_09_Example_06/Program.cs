using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_09_Example_06 {
	class Program {
		static void Main(string[] args) {
			// I can use other methods to create arrays from strings.
			
			// ToCharArray()

			string letters = "abcdefg";
			char[] chars = letters.ToCharArray();

			foreach (var letter in letters) {
				Console.WriteLine(letter);
			}

			Console.WriteLine();

			// Split()

			string sentence = "I love programming with C#";
			string[] words = sentence.Split();
			
			foreach (var word in words) {
				Console.WriteLine(word);
			}

			Console.WriteLine();

			// You can define a separator, in case you dont want to use spaces.
			string arrayToBe = "647-123-1234";
			string[] elements = arrayToBe.Split('-');

			foreach (var element in elements) {
				Console.WriteLine(element);
			}
		}
	}
}
