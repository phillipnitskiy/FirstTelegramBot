using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FirstTelegramBot.Models.Commands
{
    public class HelloCommand : Command
    {
        protected override string Name => "hello";

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Command logic -_-

            await client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}