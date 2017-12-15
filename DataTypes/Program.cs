using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataTypes {
	class Program {
		static void Main(string[] args) {
			LocalVarDeclarations();
			ParseFromStrings();
			UseDatesAndTimes();
			StringFunctionality();
			StringBuilderExamples();
			StringInterpolation();

			// Cleanup
			Console.WriteLine();
			Console.ReadLine();
		}

		static void LocalVarDeclarations() {
			Console.WriteLine("=> Data Declarations:");

			// Format: dataType varName
			int myInt = 0;

			// Multiline declaration
			string myString;
			myString = "This is my character data";

			// Multi-variable declaration
			bool b1 = true, b2 = false, b3 = b1;

			// Declare boolean with relevant structure
			System.Boolean b4 = false;

			Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
		}

		static void ParseFromStrings() {
			Console.WriteLine("=> Data type parsing:");

			bool b = bool.Parse("True");
			Console.WriteLine("Value of b: {0}", b);

			double d = double.Parse("99.884");
			Console.WriteLine("Value of d: {0}", d);

			int i = int.Parse("8");
			Console.WriteLine("Value of i: {0}", i);

			char c = char.Parse("w");
			Console.WriteLine("Value of c: {0}", c);

			Console.WriteLine();
		}

		static void UseDatesAndTimes() {
			Console.WriteLine("=> Dates and Times:");

			// Constructor takes (year, month, day).
			DateTime dt = new DateTime(2015, 10, 17);

			// What day of the month is this?
			Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

			// Month is now December
			dt = dt.AddMonths(2);
			Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

			// Constructor takes (hours, minutes, seconds)
			TimeSpan ts = new TimeSpan(4, 30, 0);
			Console.WriteLine(ts);

			// Subtract 15 mins from current TimeSpan
			Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
		}

		static void StringFunctionality() {
			Console.WriteLine("=> Basic String functionality:");
			string firstName = "David", lastName = "C";
			
			// Base value
			Console.WriteLine("Value of firstName: {0}", firstName);

			// Character length
			Console.WriteLine("firstName has {0} characters", firstName.Length);

			// Case transformation
			Console.WriteLine("Uppercase: {0}", firstName.ToUpper());
			Console.WriteLine("Lowercase: {0}", firstName.ToLower());

			// String search
			Console.WriteLine("Contains the string y?: {0}", firstName.Contains("y"));

			// Replace
			Console.WriteLine("Shorten name with string replace. {0} to {1}", firstName, firstName.Replace("id", "e"));

			// Concatenation
			Console.WriteLine("First and Last names: {0}", firstName + " " + lastName);

			// Escapes
			Console.WriteLine("{0}\'s \"string\" with \n various \t escapes", firstName);

			// Verbatim string - useful for declaring file paths / anything using escape characters and for preserving whitespace / multi line strings.
			Console.WriteLine(@"String with escape chars: C:\MyApp\bin\Debug");

			// Comparison
			Console.WriteLine("firstName == lastName: {0}", firstName == lastName);
		}

		static void StringBuilderExamples() {
			// Games array
			string[] goodGames = new string[] { "Half Life 2", "Morrowind", "Deus Ex", "System Shock" };

			Console.WriteLine("=> Using the StringBuilder:");

			// Title
			StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
			sb.Append("\n");

			// Add games to string builder
			foreach (string game in goodGames) {
				sb.AppendLine(game);
			}

			// Output stringbuilder string
			Console.WriteLine(sb.ToString());
		}

		static void StringInterpolation() {
			int age = 27;
			string name = "Liliana";

			// String interpolation
			string greeting = $"Welcome {name}. You\'re {age} years old.";
			Console.WriteLine(greeting);
		}
	}
}
