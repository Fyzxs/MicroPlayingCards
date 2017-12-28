using MicroPlayingCards.Core;

namespace MicroPlayingCards.Scoring.HighCard {
    public class AceSpadeHighScoring : IScoring
    {
        private readonly IScoring _next;

        public AceSpadeHighScoring(IScoring next) => _next = next;

        public IScore Scoring(IHand hand)
        {
            if (hand.HasCard(Deck.Spades.Ace)) return Score.AceSpadeHigh;

            return _next.Scoring(hand);
        }
    }
}