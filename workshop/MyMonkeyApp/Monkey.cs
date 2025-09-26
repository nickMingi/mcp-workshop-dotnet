/// <summary>
/// Represents a monkey species with details.
/// </summary>
public class Monkey
{
    /// <summary>
    /// The name of the monkey species.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The primary location or habitat of the monkey.
    /// </summary>
    public required string Location { get; set; }

    /// <summary>
    /// The estimated population of the monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Optional ASCII art for visual display.
    /// </summary>
    public string? AsciiArt { get; set; }
}
