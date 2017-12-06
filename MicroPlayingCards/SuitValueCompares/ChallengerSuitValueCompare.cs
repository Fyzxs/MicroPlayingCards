using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.SuitValueCompares
{
    public abstract class ChallengerSuitValueCompare : ISuitValueCompare
    {
        private readonly ISuitValueCompare _suitValueCompare;

        protected ChallengerSuitValueCompare(ISuitValueCompare suitValueCompare) => _suitValueCompare = suitValueCompare;

        public IValueCompare Compare(ISuit champion, ISuit challenger)
        {
            if (challenger == MatchSuit()) return ValueCompare.Greater;
            return _suitValueCompare.Compare(champion, challenger);
        }

        protected abstract ISuit MatchSuit();
    }

    public class ChallengerClubValueCompare : ChallengerSuitValueCompare
    {
        public ChallengerClubValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Club;
    }
    public class ChallengerDiamondValueCompare : ChallengerSuitValueCompare
    {
        public ChallengerDiamondValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Diamond;
    }
    public class ChallengerHeartValueCompare : ChallengerSuitValueCompare
    {
        public ChallengerHeartValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Heart;
    }
}