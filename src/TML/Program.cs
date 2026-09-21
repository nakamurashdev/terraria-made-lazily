namespace TML;

public static class Program
{
    private static void Main(string[] args) => Commands.CommandDispatcher.Execute(args);
}