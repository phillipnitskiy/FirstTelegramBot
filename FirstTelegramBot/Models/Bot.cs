using System.Collections.Generic;
using System.Threading.Tasks;
using FirstTelegramBot.Models.Commands;
using Telegram.Bot;

namespace FirstTelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient _client;
        private static List<Command> _commandsList;

        public static IReadOnlyList<Command> Commands => _commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> Get()
        {
            if (_client != null)
            {
                return _client;
            }

            _commandsList = new List<Command>();
            _commandsList.Add(new HelloCommand());
            //TODO: Add more commands

            _client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await _client.SetWebhookAsync(hook);

            return _client;
        }
    }
}