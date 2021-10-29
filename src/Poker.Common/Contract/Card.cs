namespace BluffinMuffin.Poker.Common.Contract
{
    class Card : ICard
    {
        public CardSuitEnum Suit { get; set; }
        public CardValueEnum Value { get; set; }
    }
}
