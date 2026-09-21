namespace TML.Commands;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class OptionAttribute : Attribute
{
    /// <summary>
    ///     The name of the option.
    /// </summary>
    public readonly string Name;

    /// <summary>
    ///     The short name of the option.
    /// </summary>
    public readonly char Short;
    
    /// <summary>
    ///     Initializes a new instance of the <see cref="OptionAttribute"/> class.
    /// </summary>
    /// <param name="name">
    ///     The name of the option.
    /// </param>
    /// <exception cref="ArgumentException">
    ///     <paramref name="name"/> is <see langword="null"/> or empty.
    /// </exception>
    public OptionAttribute(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        Name = name;
        Short = name[0];
    }
}