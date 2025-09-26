
using System;

class Program
{
	static void Main()
	{
		var random = new Random();
		string[] asciiArts = MonkeyHelper.GetMonkeys()
			.Where(m => !string.IsNullOrWhiteSpace(m.AsciiArt))
			.Select(m => m.AsciiArt!).ToArray();

		while (true)
		{
			Console.Clear();
			// Display random ASCII art
			if (asciiArts.Length > 0)
			{
				Console.WriteLine(asciiArts[random.Next(asciiArts.Length)]);
				Console.WriteLine();
			}

			Console.WriteLine("Monkey Console Application");
			Console.WriteLine("=========================");
			Console.WriteLine("1. List all monkeys");
			Console.WriteLine("2. Get details for a specific monkey by name");
			Console.WriteLine("3. Get a random monkey");
			Console.WriteLine("4. Exit app");
			Console.Write("Select an option (1-4): ");

			var input = Console.ReadLine();
			Console.WriteLine();

			switch (input)
			{
				case "1":
					ListAllMonkeys();
					break;
				case "2":
					GetMonkeyByName();
					break;
				case "3":
					GetRandomMonkey();
					break;
				case "4":
					Console.WriteLine("Goodbye!");
					return;
				default:
					Console.WriteLine("Invalid option. Please try again.");
					break;
			}
			Console.WriteLine("\nPress Enter to continue...");
			Console.ReadLine();
		}
	}

	static void ListAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetMonkeys();
		Console.WriteLine("{0,-25} {1,-25} {2,10}", "Name", "Location", "Population");
		Console.WriteLine(new string('-', 65));
		foreach (var m in monkeys)
		{
			Console.WriteLine("{0,-25} {1,-25} {2,10}", m.Name, m.Location, m.Population);
		}
	}

	static void GetMonkeyByName()
	{
		Console.Write("Enter monkey name: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
		if (monkey != null)
		{
			Console.WriteLine($"Name: {monkey.Name}");
			Console.WriteLine($"Location: {monkey.Location}");
			Console.WriteLine($"Population: {monkey.Population}");
			if (!string.IsNullOrWhiteSpace(monkey.AsciiArt))
			{
				Console.WriteLine("ASCII Art:");
				Console.WriteLine(monkey.AsciiArt);
			}
		}
		else
		{
			Console.WriteLine("Monkey not found.");
		}
	}

	static void GetRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		Console.WriteLine($"Random Monkey: {monkey.Name}");
		Console.WriteLine($"Location: {monkey.Location}");
		Console.WriteLine($"Population: {monkey.Population}");
		if (!string.IsNullOrWhiteSpace(monkey.AsciiArt))
		{
			Console.WriteLine("ASCII Art:");
			Console.WriteLine(monkey.AsciiArt);
		}
		Console.WriteLine($"Random monkey picked {MonkeyHelper.GetRandomMonkeyAccessCount()} times.");
	}
}
