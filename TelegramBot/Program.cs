namespace TelegramBot
{
    internal class Program
    {
        static async Task Main()
        {
            Bot bot = new Bot();
            await bot.Run();
        }
    }
}
