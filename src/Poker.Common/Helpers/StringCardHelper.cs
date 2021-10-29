using System;
using System.Linq;
using Poker.Common.Contract;

namespace Poker.Common.Helpers
{
    public interface IStringCardHelper
    {
        string CardToString(ICard card);
        ICard StringToCard(string s);
    }
    public class StringCardHelper : IStringCardHelper
    {
        private static readonly string[] _values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static readonly string[] _suits = { "C", "D", "H", "S" };

        public string CardToString(ICard card)
        {
            return $"{_values[(int)card.Value]}{_suits[(int)card.Suit]}";
        }

        public ICard StringToCard(string s)
        {
            if (s.Length < 2 || s.Length > 3)
                throw new InvalidStringRepresentationException(s, "Length");

            var value = s.Remove(s.Length - 1).ToUpper();
            if (!_values.Contains(value))
                throw new InvalidStringRepresentationException(s, "Value");

            var suit = s.Substring(s.Length - 1, 1).ToUpper();
            if (!_suits.Contains(suit))
                throw new InvalidStringRepresentationException(s, "Suit");

            return new Card { Suit = (CardSuitEnum)Array.IndexOf(_suits, suit), Value = (CardValueEnum)Array.IndexOf(_values, value) };
        }
    }
}
