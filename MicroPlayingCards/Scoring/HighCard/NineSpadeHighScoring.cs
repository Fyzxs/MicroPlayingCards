using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class NineSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public NineSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Nine)) return Score.NineSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}