using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace JoyBots.Keyboards
{
    public class MatrixKeyboard
    {
        private List<List<KeyboardButton>> Buttons { get; set; }

        public MatrixKeyboard()
        {
            Buttons = new List<List<KeyboardButton>>();
        }

        public void AddVertical(KeyboardButton button)
        {
            Buttons.Add(new List<KeyboardButton>() { button });
        }

        public void AddHorizontal(int index, KeyboardButton button)
        {
            Buttons[index].Add(button);
        }

        public void AddVertical(string text) => AddVertical(new KeyboardButton(text));

        public void AddHorizontal(int index, string text) => AddHorizontal(index, new KeyboardButton(text));

        public IReplyMarkup GetMarkup() => new ReplyKeyboardMarkup(Buttons);
    }
}
