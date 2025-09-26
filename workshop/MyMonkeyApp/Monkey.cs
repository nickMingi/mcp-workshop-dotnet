namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey species with its characteristics
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the location where the monkey is found
    /// </summary>
    public string Location { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the population count of the monkey species
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets additional details about the monkey species
    /// </summary>
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// Returns a string representation of the monkey
    /// </summary>
    public override string ToString()
    {
        return $"{Name} - {Location} (Population: {Population:N0})";
    }
}