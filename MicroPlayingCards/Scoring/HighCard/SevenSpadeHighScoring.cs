using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class SevenSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;
        public SevenSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Seven)) return Score.SevenSpadeHigh;
            return _next.Scoring(hand);
        }
    }
}