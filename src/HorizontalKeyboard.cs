using System.Collections.Generic;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards
{
    public class HorizontalKeyboard
    {
        private List<KeyboardButton> Buttons { get; set; }

        public HorizontalKeyboard()
        {
            Buttons = new List<KeyboardButton>();
        }

        public HorizontalKeyboard(params string[] buttons)
            : this()
        {
            Buttons.AddRange(buttons.Select(s => new KeyboardButton(s)));
        }

        public IReplyMarkup GetMarkup()
        {
            var keyboard = new List<List<KeyboardButton>>();
            keyboard.Add(new List<KeyboardButton>());

            foreach (var button in Buttons)
            {
                keyboard[0].Add(button);
            }

            return new ReplyKeyboardMarkup(keyboard);
        }
    }
}
