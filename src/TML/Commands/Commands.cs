namespace TML.Commands;

[AttributeUsage(AttributeTargets.Method)]
public sealed class CommandAttribute : Attribute
{
    /// <summary>
    ///     The name of the command.
    /// </summary>
    public readonly string Name;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CommandAttribute"/> class.
    /// </summary>
    /// <param name="name">
    ///     The name of the command.
    /// </param>
    /// <exception cref="ArgumentException">
    ///    <paramref name="name"/> is <see langword="null"/> or empty.
    /// </exception>
    public CommandAttribute(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        
        Name = name;
    }
}

internal static partial class CommandDispatcher
{
    /// <summary>
    ///     
    /// </summary>
    /// <param name="args">
    ///     
    /// </param>
    internal static partial void Execute(string[] args);
}