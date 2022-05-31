using System.Collections.Generic;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards
{
    public class VerticalKeyboard
    {
        private List<KeyboardButton> Buttons { get; set; }

        public VerticalKeyboard()
        {
            Buttons = new List<KeyboardButton>();
        }

        public VerticalKeyboard(params string[] buttons)
            : this()
        {
            Buttons.AddRange(buttons.Select(s => new KeyboardButton(s)));
        }

        public void AddButton(KeyboardButton button)
        {
            Buttons.Add(button);
        }

        public void AddButton(string text)
        {
            Buttons.Add(new KeyboardButton(text));
        }

        public IReplyMarkup GetMarkup()
        {
            var keyboard = new List<List<KeyboardButton>>();

            foreach (var button in Buttons)
            {
                keyboard.Add(new List<KeyboardButton> { button });
            }

            return new ReplyKeyboardMarkup(keyboard);
        }
    }
}