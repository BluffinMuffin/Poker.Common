using System.Collections.Generic;
using System.Linq;
using BluffinMuffin.Poker.Common.Contract;

namespace BluffinMuffin.Poker.Common.Helpers
{
    public interface IStringQualityHelper
    {
        string QualityToString(CardGroupQualityEnum quality, IEnumerable<ICard> cards);
    }
    public class StringQualityHelper : IStringQualityHelper
    {
        private readonly IStringCardHelper _stringCardHelper;

        public StringQualityHelper(IStringCardHelper stringCardHelper)
        {
            _stringCardHelper = stringCardHelper;
        }

        public string QualityToString(CardGroupQualityEnum quality, IEnumerable<ICard> cards)
        {
            var stringCards = string.Join(", ", cards.Select(_stringCardHelper.CardToString));
            return $"{quality} with cards [{stringCards}]";
        }
    }
}
