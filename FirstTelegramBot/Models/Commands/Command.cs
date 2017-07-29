using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FirstTelegramBot.Models.Commands
{
    public abstract class Command
    {
        protected abstract string Name { get; }

        public abstract Task Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            return command.Contains(Name);
        }

    }
}