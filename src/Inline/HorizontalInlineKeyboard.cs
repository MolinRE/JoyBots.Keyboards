using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards.Inline
{
    public class HorizontalInlineKeyboard : IInlineKeyboardReply
    {
        private List<InlineKeyboardButton> Buttons { get; set; }

        public HorizontalInlineKeyboard()
        {
            Buttons = new List<InlineKeyboardButton>();
        }

        public void AddCallback(string text, string callbackData)
        {
            Buttons.Add(InlineKeyboardButton.WithCallbackData(text, callbackData));
        }

        public InlineKeyboardMarkup GetMarkup()
        {
            var keyboard = new List<List<InlineKeyboardButton>>()
            {
                Buttons
            };

            return new InlineKeyboardMarkup(keyboard);
        }
    }
}