namespace BluffinMuffin.Poker.Common.Contract
{
    public interface ICard
    {
        CardSuitEnum Suit { get; }
        CardValueEnum Value { get; }
    }
}
