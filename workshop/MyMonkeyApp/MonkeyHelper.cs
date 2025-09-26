namespace MyMonkeyApp;

/// <summary>
/// Static helper class to manage monkey data and provide utility methods
/// </summary>
public static class MonkeyHelper
{
    private static readonly Random _random = new();
    private static int _accessCount = 0;

    /// <summary>
    /// Collection of monkey data
    /// </summary>
    private static readonly List<Monkey> _monkeys = new()
    {
        new Monkey 
        { 
            Name = "Baboon", 
            Location = "Africa & Arabia", 
            Population = 200000,
            Details = "Large, terrestrial primates known for their distinctive dog-like snouts and complex social structures."
        },
        new Monkey 
        { 
            Name = "Capuchin", 
            Location = "Central & South America", 
            Population = 50000,
            Details = "Intelligent New World monkeys famous for their problem-solving abilities and tool use."
        },
        new Monkey 
        { 
            Name = "Golden Lion Tamarin", 
            Location = "Brazil", 
            Population = 3000,
            Details = "Endangered small monkeys with distinctive golden manes, found only in Brazil's Atlantic Forest."
        },
        new Monkey 
        { 
            Name = "Howler Monkey", 
            Location = "Central & South America", 
            Population = 100000,
            Details = "Known for their loud calls that can be heard up to 3 miles away, these are among the loudest land animals."
        },
        new Monkey 
        { 
            Name = "Japanese Macaque", 
            Location = "Japan", 
            Population = 120000,
            Details = "Also known as snow monkeys, famous for bathing in hot springs during winter."
        },
        new Monkey 
        { 
            Name = "Mandrill", 
            Location = "Equatorial Africa", 
            Population = 800000,
            Details = "The world's largest monkeys, males have colorful faces and are highly social."
        },
        new Monkey 
        { 
            Name = "Proboscis Monkey", 
            Location = "Borneo", 
            Population = 7000,
            Details = "Endangered monkeys with large noses, found only in the mangrove forests of Borneo."
        },
        new Monkey 
        { 
            Name = "Spider Monkey", 
            Location = "Central & South America", 
            Population = 250000,
            Details = "Agile primates with long limbs and prehensile tails, excellent at swinging through trees."
        },
        new Monkey 
        { 
            Name = "Squirrel Monkey", 
            Location = "Central & South America", 
            Population = 300000,
            Details = "Small, colorful monkeys that live in large troops and are known for their acrobatic abilities."
        },
        new Monkey 
        { 
            Name = "Vervet Monkey", 
            Location = "Eastern & Southern Africa", 
            Population = 500000,
            Details = "Medium-sized monkeys known for their distinct alarm calls for different types of predators."
        }
    };

    /// <summary>
    /// Gets all available monkeys
    /// </summary>
    /// <returns>List of all monkeys</returns>
    public static List<Monkey> GetAllMonkeys()
    {
        return _monkeys.ToList();
    }

    /// <summary>
    /// Finds a monkey by name (case-insensitive)
    /// </summary>
    /// <param name="name">The name of the monkey to find</param>
    /// <returns>The monkey if found, null otherwise</returns>
    public static Monkey? FindMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets a random monkey and increments the access count
    /// </summary>
    /// <returns>A randomly selected monkey</returns>
    public static Monkey GetRandomMonkey()
    {
        _accessCount++;
        int index = _random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Gets the current access count for random monkey selections
    /// </summary>
    /// <returns>The number of times a random monkey has been selected</returns>
    public static int GetAccessCount()
    {
        return _accessCount;
    }
}