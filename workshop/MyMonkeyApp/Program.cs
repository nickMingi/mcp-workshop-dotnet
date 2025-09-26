using MyMonkeyApp;

// Display welcome ASCII art
DisplayWelcomeArt();

// Main application loop
bool continueRunning = true;
while (continueRunning)
{
    DisplayMenu();
    
    Console.Write("Please select an option (1-4): ");
    string? input = Console.ReadLine();
    
    Console.WriteLine();
    
    switch (input)
    {
        case "1":
            ListAllMonkeys();
            break;
        case "2":
            GetMonkeyDetails();
            break;
        case "3":
            GetRandomMonkey();
            break;
        case "4":
            continueRunning = false;
            Console.WriteLine("Thanks for using the Monkey App! 🐵");
            break;
        default:
            Console.WriteLine("Invalid option. Please select 1-4.");
            break;
    }
    
    if (continueRunning)
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}

static void DisplayWelcomeArt()
{
    Console.Clear();
    
    // Randomly select ASCII art
    string[] asciiArts = {
        @"
    🐵 MONKEY APP 🐵
        
      .-""-. 
     /      \
    |  o    o |
     \   __  /
      '.____.'
        ||||
       (    )
      ^^    ^^
",
        @"
    🐒 MONKEY APP 🐒
    
     .-""-..-""-. 
    /           \
   |  o       o  |
    \     ^     /
     '.  ___  .'
       '-----'
        |||||
       (     )
      ^^^   ^^^
",
        @"
    🙈 MONKEY APP 🙈
    
      .-------.
     /         \
    | 👀     👀 |
     \    🐽   /
      '-.___.-'
         |||
        (   )
       ^^   ^^
"
    };
    
    Random random = new();
    Console.WriteLine(asciiArts[random.Next(asciiArts.Length)]);
    Console.WriteLine("Welcome to the Monkey Information System!");
    Console.WriteLine("=========================================\n");
}

static void DisplayMenu()
{
    Console.WriteLine("🐵 MAIN MENU 🐵");
    Console.WriteLine("================");
    Console.WriteLine("1. List all monkeys");
    Console.WriteLine("2. Get details for a specific monkey by name");
    Console.WriteLine("3. Get a random monkey");
    Console.WriteLine("4. Exit app");
    Console.WriteLine();
}

static void ListAllMonkeys()
{
    Console.WriteLine("📋 ALL AVAILABLE MONKEYS 📋");
    Console.WriteLine("============================\n");
    
    var monkeys = MonkeyHelper.GetAllMonkeys();
    
    for (int i = 0; i < monkeys.Count; i++)
    {
        Console.WriteLine($"{i + 1:D2}. {monkeys[i]}");
    }
    
    Console.WriteLine($"\nTotal species: {monkeys.Count}");
}

static void GetMonkeyDetails()
{
    Console.WriteLine("🔍 FIND MONKEY BY NAME 🔍");
    Console.WriteLine("==========================\n");
    
    Console.Write("Enter the monkey name: ");
    string? name = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("❌ Please enter a valid monkey name.");
        return;
    }
    
    var monkey = MonkeyHelper.FindMonkeyByName(name);
    
    if (monkey != null)
    {
        Console.WriteLine("✅ Monkey found!\n");
        DisplayMonkeyDetails(monkey);
    }
    else
    {
        Console.WriteLine($"❌ No monkey found with the name '{name}'.");
        Console.WriteLine("\nAvailable monkeys:");
        var allMonkeys = MonkeyHelper.GetAllMonkeys();
        foreach (var m in allMonkeys)
        {
            Console.WriteLine($"  • {m.Name}");
        }
    }
}

static void GetRandomMonkey()
{
    Console.WriteLine("🎲 RANDOM MONKEY SELECTION 🎲");
    Console.WriteLine("==============================\n");
    
    var monkey = MonkeyHelper.GetRandomMonkey();
    
    Console.WriteLine("🎉 Here's your random monkey:\n");
    DisplayMonkeyDetails(monkey);
    
    Console.WriteLine($"\n📊 Random selections made: {MonkeyHelper.GetAccessCount()}");
}

static void DisplayMonkeyDetails(Monkey monkey)
{
    Console.WriteLine($"🐵 Name: {monkey.Name}");
    Console.WriteLine($"🌍 Location: {monkey.Location}");
    Console.WriteLine($"👥 Population: {monkey.Population:N0}");
    Console.WriteLine($"📝 Details: {monkey.Details}");
}
