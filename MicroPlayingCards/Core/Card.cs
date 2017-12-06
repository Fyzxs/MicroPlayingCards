using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.Core
{
    public interface ICard
    {
        IValueCompare Compare(ICard other);
        IValueCompare Compare(ISuit other);
        IValueCompare Compare(IRank other);
    }

    public class Card : ICard
    {
        private readonly ISuit _suit;
        private readonly IRank _rank;
        public Card(ISuit suit) : this(suit, Rank.Two) { }

        public Card(ISuit suit, IRank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public IValueCompare Compare(ICard other)
        {
            //Todo Chain?
            IValueCompare otherRankCompare = other.Compare(_rank);

            if (otherRankCompare.IsEqual()) return other.Compare(_suit);
            return new NegateValueCompare(otherRankCompare);
        }

        public IValueCompare Compare(ISuit other) => other.Compare(_suit);
        public IValueCompare Compare(IRank other) => new NegateValueCompare(other.Compare(_rank));
    }
}