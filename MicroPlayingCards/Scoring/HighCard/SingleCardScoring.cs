using System;
using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard
{
    public class SingleCardScoring : IScoring
    {
        private readonly IScoring _scoring;

        public SingleCardScoring() : this(
            new AceSpadeHighScoring(
                new AceHeartHighScoring(
                    new AceDiamondHighScoring(
                        new AceClubHighScoring(
                            new KingSpadeHighScoring(
                                new KingHeartHighScoring(
                                    new KingDiamondHighScoring(
                                        new KingClubHighScoring(
                                            new QueenSpadeHighScoring(
                                                new QueenHeartHighScoring(
                                                    new QueenDiamondHighScoring(
                                                        new QueenClubHighScoring(
                                                            new JackSpadeHighScoring(
                                                                new JackHeartHighScoring(
                                                                    new JackDiamondHighScoring(
                                                                        new JackClubHighScoring(
                                                                            new TenSpadeHighScoring(
                                                                                new TenHeartHighScoring(
                                                                                    new TenDiamondHighScoring(
                                                                                        new TenClubHighScoring(
                                                                                            new NineSpadeHighScoring(
                                                                                                new NineHeartHighScoring(
                                                                                                    new NineDiamondHighScoring(
                                                                                                        new NineClubHighScoring(
                                                                                                            new EightSpadeHighScoring(
                                                                                                                new EightHeartHighScoring(
                                                                                                                    new EightDiamondHighScoring(
                                                                                                                        new EightClubHighScoring(
                                                                                                                            new SevenSpadeHighScoring(
                                                                                                                                new SevenHeartHighScoring(
                                                                                                                                    new SevenDiamondHighScoring(
                                                                                                                                        new SevenClubHighScoring(
                                                                                                                                            new NoOp())))))))))))))))))))))))))))))))))
        { }
        public SingleCardScoring(IScoring scoring) => _scoring = scoring;

        public IScore Scoring(IHand hand) => _scoring.Scoring(hand);
        public class NoOp : IScoring
        {
            public IScore Scoring(IHand hand) => throw new NotImplementedException("We don't get here");
        }
    }
}