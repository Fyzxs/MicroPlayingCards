using MicroPlayingCards.Core;
using MicroPlayingCards.ValueCompares;

namespace MicroPlayingCards.SuitValueCompares
{
    public class SuitValueCompare : ISuitValueCompare
    {
        private readonly ISuitValueCompare _suitValueCompare;

        public SuitValueCompare() : this(
            new SameSuitValueCompare(
                new ChallengerClubValueCompare(
                    new ChampionClubValueCompare(
                        new ChallengerDiamondValueCompare(
                            new ChampionDiamondValueCompare(
                                new ChallengerHeartValueCompare(
                                    new ChampionHeartValueCompare(
                                        new NoOp()))))))))
        { }

        public SuitValueCompare(ISuitValueCompare suitValueCompare) => _suitValueCompare = suitValueCompare;

        public IValueCompare Compare(ISuit champion, ISuit challenger) => _suitValueCompare.Compare(champion, challenger);

        private class NoOp : ISuitValueCompare
        {
            public IValueCompare Compare(ISuit champion, ISuit challenger) => throw new System.Exception("SuitValueCompare NoOp was hit");
        }
    }
}