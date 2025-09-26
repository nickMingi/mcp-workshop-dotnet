using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Provides helper methods for managing monkey data.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Capuchin", Location = "Central & South America", Population = 100000, AsciiArt = "(o.o)" },
        new Monkey { Name = "Mandrill", Location = "Central Africa", Population = 20000, AsciiArt = "(='.'=)" },
        new Monkey { Name = "Howler", Location = "South America", Population = 50000, AsciiArt = "(>_<)" },
        new Monkey { Name = "Golden Lion Tamarin", Location = "Brazil", Population = 3500, AsciiArt = "(o_O)" }
    };

    private static int randomMonkeyAccessCount = 0;
    private static readonly Random random = new();

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// Gets a monkey by its name (case-insensitive).
    /// </summary>
    public static Monkey? GetMonkeyByName(string name) =>
        monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    /// <summary>
    /// Gets a random monkey and increments the access count.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        randomMonkeyAccessCount++;
        return monkeys[random.Next(monkeys.Count)];
    }

    /// <summary>
    /// Gets the number of times a random monkey has been picked.
    /// </summary>
    public static int GetRandomMonkeyAccessCount() => randomMonkeyAccessCount;
}
