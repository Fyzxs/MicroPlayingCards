using MicroPlayingCards.SuitValueCompares;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.Core
{
    public interface ISuit
    {
        IValueCompare Compare(ISuit suit);
    }

    public class Suit : ISuit
    {
        public static readonly ISuit Club = new Suit();
        public static readonly ISuit Diamond = new Suit();
        public static readonly ISuit Heart = new Suit();
        public static readonly ISuit Spade = new Suit();

        private readonly ISuitValueCompare _suitValueCompare;

        private Suit() : this(new SuitValueCompare()) { }

        private Suit(ISuitValueCompare suitValueCompare) => _suitValueCompare = suitValueCompare;

        public IValueCompare Compare(ISuit other) => _suitValueCompare.Compare(this, other);
    }
}