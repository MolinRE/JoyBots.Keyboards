using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards.Inline
{
    public class MatrixInlineKeyboard : IInlineKeyboardReply
    {
        private List<List<InlineKeyboardButton>> Buttons { get; set; }

        public MatrixInlineKeyboard()
        {
            Buttons = new List<List<InlineKeyboardButton>>();
        }

        public void AddVertical(InlineKeyboardButton button)
        {
            Buttons.Add(new List<InlineKeyboardButton>() { button });
        }

        public void AddHorizontal(int index, InlineKeyboardButton button)
        {
            Buttons[index].Add(button);
        }

        public void AddVertical(string text, string callbackData)
        {
            AddVertical(InlineKeyboardButton.WithCallbackData(text, callbackData));
        }

        public void AddHorizontal(int index, string text, string callbackData)
        {
            AddHorizontal(index, InlineKeyboardButton.WithCallbackData(text, callbackData));
        }

        public InlineKeyboardMarkup GetMarkup() => new InlineKeyboardMarkup(Buttons);
    }
}