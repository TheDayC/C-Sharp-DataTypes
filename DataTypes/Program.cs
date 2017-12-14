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

			Console.WriteLine();
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
	}
}
