using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards.Inline
{
    public class VerticalInlineKeyboard : IInlineKeyboardReply
    {
        private List<InlineKeyboardButton> Buttons { get; set; }

        public VerticalInlineKeyboard()
        {
            Buttons = new List<InlineKeyboardButton>();
        }

        public void AddButton(InlineKeyboardButton button)
        {
            Buttons.Add(button);
        }

        public void AddUrl(string text, string url)
        {
            Buttons.Add(InlineKeyboardButton.WithUrl(text, url));
        }

        public void AddCallback(string text, string callbackData)
        {
            Buttons.Add(InlineKeyboardButton.WithCallbackData(text, callbackData));
        }

        public void Clear()
        {
            Buttons.Clear();
        }

        public InlineKeyboardMarkup GetMarkup()
        {
            var keyboard = new List<List<InlineKeyboardButton>>();

            foreach (var button in Buttons)
            {
                keyboard.Add(new List<InlineKeyboardButton> { button });
            }

            return new InlineKeyboardMarkup(keyboard);
        }
    }
}