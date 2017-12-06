using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.SuitValueCompares
{
    public abstract class ChampionSuitValueCompare : ISuitValueCompare
    {
        private readonly ISuitValueCompare _suitValueCompare;

        protected ChampionSuitValueCompare(ISuitValueCompare suitValueCompare) => _suitValueCompare = suitValueCompare;

        public IValueCompare Compare(ISuit champion, ISuit challenger)
        {
            if (champion == MatchSuit()) return ValueCompare.Lesser;
            return _suitValueCompare.Compare(champion, challenger);
        }

        protected abstract ISuit MatchSuit();
    }

    public class ChampionClubValueCompare : ChampionSuitValueCompare
    {
        public ChampionClubValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Club;
    }
    public class ChampionDiamondValueCompare : ChampionSuitValueCompare
    {
        public ChampionDiamondValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Diamond;
    }
    public class ChampionHeartValueCompare : ChampionSuitValueCompare
    {
        public ChampionHeartValueCompare(ISuitValueCompare suitValueCompare) : base(suitValueCompare) { }
        protected override ISuit MatchSuit() => Suit.Heart;
    }
}