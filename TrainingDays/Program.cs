using System;

class Program
{
	// Method to get the number of sleep hours for a given day
	static int GetSleepHours(string day)
	{
		switch (day.ToLower())
		{
			case "monday":
				return 8;
			case "tuesday":
				return 8;
			case "wednesday":
				return 9;
			case "thursday":
				return 8;
			case "friday":
				return 10;
			case "saturday":
				return 6;
			case "sunday":
				return 8;
			default:
				throw new ArgumentException("Invalid day provided.");
		}
	}

	// Method to calculate the total sleep hours for the week
	static int GetActualSleepHours()
	{
		return GetSleepHours("monday") +
			   GetSleepHours("tuesday") +
			   GetSleepHours("wednesday") +
			   GetSleepHours("thursday") +
			   GetSleepHours("friday") +
			   GetSleepHours("saturday") +
			   GetSleepHours("sunday");
	}

	// Method to calculate the ideal sleep hours for the week
	static int GetIdealSleepHours()
	{
		int idealHours = 8; // Ideal sleep hours per night
		return idealHours * 7; // Ideal sleep hours for the week
	}

	// Method to calculate and display the sleep debt
	static void CalculateSleepDebt()
	{
		int actualSleepHours = GetActualSleepHours();
		int idealSleepHours = GetIdealSleepHours();

		Console.WriteLine($"Your total amount of hours sleep was {actualSleepHours}hrs.");

		if (actualSleepHours == idealSleepHours)
		{
			Console.WriteLine("You got the perfect amount of sleep.");
		}
		else if (actualSleepHours > idealSleepHours)
		{
			Console.WriteLine($"You got {actualSleepHours - idealSleepHours} hours more sleep than needed.");
		}
		else if (actualSleepHours < idealSleepHours)
		{
			Console.WriteLine($"You need to get {idealSleepHours - actualSleepHours} hours rest to reach the ideal amount of sleep.");
		}
		else
		{
			Console.WriteLine("Error calculating sleep debt.");
		}
	}

	static void Main()
	{
		// Calculate and display sleep debt
		CalculateSleepDebt();
	}
}