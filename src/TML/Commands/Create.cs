namespace TML.Commands;

public static class Create
{
    [Command("create")]
    public static void Execute(string[] args)
    {
        var name = args[0];
    }
}