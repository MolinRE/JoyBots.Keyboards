using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards
{
    public interface IInlineKeyboardReply
    {
        InlineKeyboardMarkup GetMarkup();
    }
}
