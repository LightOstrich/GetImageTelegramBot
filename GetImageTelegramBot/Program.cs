namespace GetImageTelegramBot;

internal static class Program
{
    private static void Main()
    {
        var bot = new Bot("YOU API KEY");
        bot.CreateCommands();
        bot.StartReceiving();
        Console.ReadLine();
    }
}